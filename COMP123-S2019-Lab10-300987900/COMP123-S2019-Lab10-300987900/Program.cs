﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_300987900
{
    static class Program
    {
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM, new MainForm());
            Forms.Add(FormName.END_FORM, new EndForm());


            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}