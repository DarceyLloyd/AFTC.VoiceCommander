using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFTC_Voice_Developer
{
    public class WindowHandler
    {
        private UIForm1 ui;

        public WindowHandler(UIForm1 arg)
        {
            ui = arg;
            ui.log("WindowHandler()");
        }
    }
}
