﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrameForm());
        }

        public static Auxillary auxForm = null;
        
        public static int forms = 0;

        public static FrameForm parentForm = null;

        public static ListFromOrder list = null;
    }
}
