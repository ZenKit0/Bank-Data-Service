﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Data_Service {
    static class Program {
        public enum CurrentState {
            Auth,
            Management,
        }

        public static CurrentState ProgramState { get; set; }

        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ManagementWindow());
            
            Application.Run(new AuthWindow());
            
            if (ProgramState == CurrentState.Management)
                Application.Run(new ManagementWindow());
            
        }
    }
}
