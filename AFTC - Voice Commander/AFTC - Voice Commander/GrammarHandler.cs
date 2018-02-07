using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Globalization;
using System.IO;

namespace AFTC___Voice_Commander
{
    public class GrammarHandler
    {

        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        private T t;
        private FormMain fm;

        public GrammarBuilder gb1 = null;
        public Grammar g1 = null;

        public GrammarBuilder gb2 = null;
        public Grammar g2 = null;

        public Choices speechCommands;
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public GrammarHandler()
        {
            // Class specific debug
            t = new T(false);
            t.log("GrammarHandler()");

            fm = Vars.formMain;
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void loadCommands()
        {
            t.log("GrammarHandler.loadCommands()");

            fm.setStatus("Setting up voice recognition grammar commands...");

            // Clean up old if not empty
            if (speechCommands != null)
            {
                speechCommands = null;
            }
            speechCommands = new Choices();





            foreach (CommandVO cvo in fm.commandManager.commands)
            {
                //t.log("GrammarHandler.loadCommands: [" + cvo.speech + "]");
                speechCommands.Add(cvo.speech);
            }



            // We are going to load multiple grammars into the recognizer to prevent incorrect word detection
            //CultureInfo targetCultureInfo = new CultureInfo("en-GB");
            CultureInfo targetCultureInfo = new CultureInfo("en-US");

            g1 = null;
            gb1 = null;

            gb1 = new GrammarBuilder(speechCommands);
            gb1.Culture = targetCultureInfo;
            g1 = new Grammar(gb1);
            g1.Name = "user grammar commands";
            g1.Priority = 10;
            t.log("GrammarHandler.loadCommands: " + fm.commandManager.commands.Count.ToString() + " user commands items added!");

            
            Choices wordsEn = new Choices();
            //const Int32 BufferSize = 128;
            //var fileStream = File.OpenRead("GrammarToIgnore.txt");
            //var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);

            var lines = File.ReadLines(Vars.dictionaryPath);
            int cnt = 0;
            foreach (String line in lines)
            {
                if (line != "")
                {
                    cnt++;
                    //Console.WriteLine(line.ToString());
                    wordsEn.Add(line);
                    fm.setStatus(cnt.ToString());
                }
            }



            

            g2 = null;
            gb2 = null;

            if (cnt > 0) 
            {
                gb2 = new GrammarBuilder(wordsEn);
                gb2.Culture = targetCultureInfo;
                g2 = new Grammar(gb2);
                g2.Name = "grammar to ignore";
                g2.Priority = 1;
            }
            t.log("GrammarHandler.loadCommands: " + cnt.ToString() + " dictionary items added!");



            fm.speechRecognizer.loadGrammar();
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -



        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void grammarLoadedHandler(object o, EventArgs e)
        {
            t.log("GrammarHandler.grammarLoadedHandler()");

        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -




        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -
        public void clearRecognizedWords()
        {
            t.log("clearRecognizedWords()");


            
        }
        // -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -  -

    }
}
