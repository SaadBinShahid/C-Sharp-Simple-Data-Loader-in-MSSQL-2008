﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Simple_Data_Loader_in_MSSQL2008
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
            Application.Run(new Form1());
        }
    }
}
