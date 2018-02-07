using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC_Voice_Developer
{
    public class FormManager
    {
        private UIForm1 ui;


        public FormManager(UIForm1 arg)
        {
            ui = arg;
        }

        public void show(String s)
        {
            switch (s)
            {
                case "main":
                    ui.Show();
                    break;

            }
        }



    }
}
