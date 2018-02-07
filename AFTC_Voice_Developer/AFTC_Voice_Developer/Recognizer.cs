using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace AFTC_Voice_Developer
{
    public class Recognizer
    {
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private UIForm1 ui;

        public SpeechRecognitionEngine sre;
        public CommandHandler commandHandler;
        private GrammarHandler grammarHandler;
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public Recognizer(UIForm1 arg)
        {
            ui = arg;
            ui.log("Recognizer()");
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        public void init()
        {
            ui.log("Recognizer.init()");

            commandHandler = ui.commandHandler;
            grammarHandler = ui.grammarHandler;
            grammarHandler.init();

            // Setup speech recognition engine
            sre = setupSpeechRecognitionEngine();
            sre.MaxAlternates = 0;
            sre.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevelHandler);
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognititionHandler);
            
            

            //setupGrammarAndCommands();

            sre.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevelHandler);


            
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        /*
        private void setupGrammarAndCommands()
        {
            ui.log("Recognizer.setupGrammarAndCommands()");

            Choices colors = new Choices();
            colors.Add(new string[] { 
                "move left", 
                "move right",
                "move up",
                "move down",
                "select previous word",
                "select next word",
                "press alt",
                "press f",
                "press s"
            });

            gb = new GrammarBuilder(colors);
            //gb.Append(colors);

            g = new Grammar(gb);
            g.Name = "colours";

            sre.LoadGrammar(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);
        }
         */
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -


        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        private SpeechRecognitionEngine setupSpeechRecognitionEngine()
        {
            ui.log("Recognizer.setupSpeechRecognitionEngine()");

            SpeechRecognitionEngine s = null;
            String culture = "en-US";

            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                if (config.Culture.ToString() == culture)
                {
                    s = new SpeechRecognitionEngine(config);
                    break;
                    ui.log("foreach found something!");
                }
            }


            // if the desired culture is not found, then load default
            if (s == null)
            {
                MessageBox.Show("The desired culture is not installed on this machine, the speech-engine will continue using "
                    + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + " as the default culture.",
                    "Culture " + culture + " not found!");
                s = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }

            s.SetInputToDefaultAudioDevice();

            return s;
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -




        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        void audioLevelHandler(object sender, AudioLevelUpdatedEventArgs e)
        {
            //ui.log("Recognizer.audioLevelHandler()");
            ui.setInputVolumeMetere(e.AudioLevel);
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -



        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        void speechRecognititionHandler(object sender, SpeechRecognizedEventArgs e)
        {
            //ui.log("Recognizer.speechRecognititionHandler()");
            //ui.setInputVolumeMetere(e.AudioLevel);
            //ui.log(e.Result.Confidence.ToString());

            String percent = Math.Round(Math.Round(e.Result.Confidence * 100)).ToString();
            Int16 p = Int16.Parse(percent);


            //Console.WriteLine("speechRecognititionHandler(): e.Result.Grammar.Name = " + e.Result.Grammar.Name);
            //Console.WriteLine("speechRecognititionHandler(): e.Result.Text = " + e.Result.Text);

            Int16 conf = ui.getConfidenceLevel();

            if (p < conf)
            {
                ui.clearStatus();
                String msg = "Command: \"" + e.Result.Text + "\"\n";
                msg += "REJECTED with a " + percent + "% confidence level (minimum acceptance level is " + conf + "%)";
                ui.setStatus(msg);
            }
            else
            {
                ui.clearStatus();
                String msg = "Command \"" + e.Result.Text + "\"\n";
                msg += "ACCEPTED with a " + percent + "% confidence level (minimum acceptance level is " + conf + "%)";
                ui.setStatus(msg);

                commandHandler.processCommand(e.Result.Text);
            }

            
        }
        // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        







    }
}
