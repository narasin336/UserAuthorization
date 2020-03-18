using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserAuthorization
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
            Application.Run(new UserAuthorization() );
        }
    }

    public static class MyGlobal
    {     
        public static string GlobalUserAuthority = "";
        public static string GlobalUserID = "";
        public static string GlobalUserName = "";
        public static string GlobalProgramID = "";
        public static string GlobalProgram = "";

        public static string GlobalDataBase = "";
        public static string GlobalServer = "";
        public static string GlobalDataBaseUserID = "";
        public static string GlobalDataBasePassword = "";
    }
}
