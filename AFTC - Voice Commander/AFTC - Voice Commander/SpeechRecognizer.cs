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

namespace AFTC___Voice_Commander
{
    public class SpeechRecognizer
    {
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;

        public Boolean listening = false;
        public SpeechRecognitionEngine sre;

        public String hypothesizedSpeech = "";
        public float hypothesizedConfidence = 0f;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public SpeechRecognizer()
        {
            // Class specific debug
            t = new T(true);
            t.log("SpeechRecognizer()");

            fm = Vars.formMain;
            sre = setupSpeechRecognitionEngine();
            sre.SetInputToDefaultAudioDevice();

            sre.MaxAlternates = 10;
            
            sre.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioLevelHandler);
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognizedHandler);

            sre.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(speechHypothesizedHandler);
            //sre.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(speechDetectedHandler);
            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -


        

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private SpeechRecognitionEngine setupSpeechRecognitionEngine()
        {
            t.log("SpeechRecognizer.setupSpeechRecognitionEngine()");


            /*
            foreach (RecognizerInfo c in SpeechRecognitionEngine.InstalledRecognizers())
            {
                t.log("SpeechRecognizer.setupSpeechRecognitionEngine(): " + c.Culture.ToString());
            }
            */

            String cfgCulture = "";
            Console.WriteLine("\n\nAvailable cultures on this machine");
            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                cfgCulture = config.Culture.ToString();
                Console.WriteLine("\t\t" + cfgCulture);
            }
            Console.WriteLine("\n");
            cfgCulture = "";
            

            SpeechRecognitionEngine s = null;
            String targetCulture = "en-US";
            //String targetCulture = "en-GB"; // DO NOT USE! "en-US" is the most accurate!

            foreach (RecognizerInfo config in SpeechRecognitionEngine.InstalledRecognizers())
            {
                cfgCulture = config.Culture.ToString();
                Console.WriteLine("cfgCulture = " + cfgCulture);
                if (cfgCulture == targetCulture)
                {
                    s = new SpeechRecognitionEngine(config);
                    break;
                }
            }


            // if the desired culture is not found, then load default
            if (s == null)
            {
                MessageBox.Show("The desired culture is not installed on this machine, the speech-engine will continue using "
                    + SpeechRecognitionEngine.InstalledRecognizers()[0].Culture.ToString() + " as the default culture.",
                    "Culture " + targetCulture + " not found!");
                s = new SpeechRecognitionEngine(SpeechRecognitionEngine.InstalledRecognizers()[0]);
            }

            

            return s;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void loadGrammar()
        {
            t.log("SpeechRecognizer.loadGrammar()");

            fm.setStatus("Loading voice commands into recognition engine, please wait...");

            sre.UnloadAllGrammars();

            if (fm.grammarHandler.g1 != null) { 
                sre.LoadGrammar(fm.grammarHandler.g1);
            }
            if (fm.grammarHandler.g2 != null)
            {
                sre.LoadGrammar(fm.grammarHandler.g2);
            }

            startListening();
            //sre.RecognizeAsync(RecognizeMode.Multiple);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -







        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void speechDetectedHandler(Object o, SpeechDetectedEventArgs e)
        {
            t.log("\n\n\n" + "speechDetectedHandler = " + e.ToString());
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void speechHypothesizedHandler(Object o, SpeechHypothesizedEventArgs e)
        {
            if (e.Result.Grammar.Name == "grammar to ignore")
            {
                hypothesizedSpeech = "";
                hypothesizedConfidence = 0;
                return;
            }

            t.log("speechHypothesizedHandler:  confidence = " + e.Result.Confidence + "    grammar = " + e.Result.Grammar.Name + "     Speech = " + e.Result.Text);
            hypothesizedSpeech = e.Result.Text;
            hypothesizedConfidence = e.Result.Confidence;

            /*
            Int16 conf = fm.getConfidenceLevel();

            String percent = Math.Round(Math.Round(e.Result.Confidence * 100)).ToString();
            Int16 p = Int16.Parse(percent);

            if (p < conf)
            {
                return;
            }
            else
            {
                processingHypothesized = true;
                processAcceptedCommand(e.Result.Text);
            }
            //t.log(e.Result.Audio.ToString());
            */
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        private bool processingHypothesized = false;
        private int commandCount = 0;

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        void speechRecognizedHandler(object sender, SpeechRecognizedEventArgs e)
        {
            //ui.log("Recognizer.speechRecognititionHandler()");
            //ui.setInputVolumeMetere(e.AudioLevel);
            //ui.log(e.Result.Confidence.ToString());
            
            // We dont process anything in the grammar to ignore!
            if (e.Result.Grammar.Name == "grammar to ignore")
            {
                return;
            }

            
            t.log("speechRecognizedHandler:  confidence = " + e.Result.Confidence + "    grammar = " + e.Result.Grammar.Name + "     Speech = " + e.Result.Text);


            Boolean like = DTools.StringQueryLike(e.Result.Text, hypothesizedSpeech);
            t.log("speechRecognizedHandler:  like = " + like);


            // Check that hypothesizedSpeech matches recognized speech
            if (!like)
            {
                t.log("speechRecognizedHandler:  REJECTED - Hypothesized speech and Recognized speech do not match or not alike!");
                return;
            }

            /*
            if (hypothesizedSpeech != e.Result.Text)
            {
                t.log("speechRecognizedHandler:  REJECTED - Hypothesized speech and Recognized speech do not math!");
                return;
            }
             */


            Int16 conf = fm.getConfidenceLevel();

            String percent = Math.Round(Math.Round(e.Result.Confidence * 100)).ToString();
            Int16 p = Int16.Parse(percent);

            if (p < conf)
            {
                t.log("speechRecognizedHandler:  REJECTED - Confidence level is below level set by the user! " + e.Result.Confidence + "/" + conf);
                return;
            }
            else
            {
                processingHypothesized = true;
                processAcceptedCommand(e.Result.Text);
            }



            /*

            if (e.Result.Grammar.Name == "grammar to ignore")
            {
                t.log("speechRecognizedHandler: Rejecting speech command as it only matches grammar to ignore!");
                hypothesizedSpeech = "";
                hypothesizedConfidence = 0f;
                return;
            }

            if (hypothesizedSpeech != e.Result.Text)
            {
                t.log("speechRecognizedHandler: Rejecting speech command as hypothesized speech doesn't match recognized speech!");
                hypothesizedSpeech = "";
                hypothesizedConfidence = 0f;
                return;
            }

            String percent = Math.Round(Math.Round(e.Result.Confidence * 100)).ToString();
            Int16 p = Int16.Parse(percent);


            //Console.WriteLine("speechRecognititionHandler(): e.Result.Grammar.Name = " + e.Result.Grammar.Name);
            //Console.WriteLine("speechRecognititionHandler(): e.Result.Text = " + e.Result.Text);

            Int16 conf = fm.getConfidenceLevel();
            commandCount++;

            if (p < conf)
            {
                String msg = commandCount + ". command: \"" + e.Result.Text + "\"\n";
                msg += "COMMAND REJECTED with a " + percent + "% confidence level...";
                fm.setStatus(msg);
                //t.log("\n" + msg);
            }
            else
            {
                String msg = commandCount + ". command: \"" + e.Result.Text + "\"\n";
                msg += "COMMAND ACCEPTED with a " + percent + "% confidence level!";
                fm.setStatus(msg);
                //t.log("\n" + msg);

                fm.commandExecutionHandler.processCommand(e.Result.Text);
            }


            hypothesizedSpeech = "";
            hypothesizedConfidence = 0f;
             */
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -





        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private void processAcceptedCommand(String speechText)
        {
            t.log("SpeechRecognizer.processAcceptedCommand(speechText)");

            commandCount++;
            String msg = commandCount + ". command: \"" + speechText + "\"\n";
            msg += "COMMAND ACCEPTED with a " + Math.Round((hypothesizedConfidence*100)) + "% confidence level!";
            fm.setStatus(msg);

            fm.commandExecutionHandler.processCommand(speechText);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

        





        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void audioLevelHandler(object sender, AudioLevelUpdatedEventArgs e)
        {
            //ui.log("Recognizer.audioLevelHandler()");
            fm.setInputVolumeMetere(e.AudioLevel);
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void stopListening()
        {
            try
            {
                sre.RecognizeAsyncStop();
            }
            catch { }
            listening = false;
            fm.setStatus("Listening is now disabled.");
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void startListening()
        {
            try
            {
                sre.RecognizeAsync(RecognizeMode.Multiple);
                fm.setStatus("Listening is now enabled.");
                listening = true;
            }
            catch
            {
                fm.setStatus("Listening is already enabled.");
                listening = true;
            }
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        

    }
}
