using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compo
{
    static class Program
    {
        public static string Autoriz_Sotr;
        public static int ID_Position;
        public static int ID_Sotr;
        public static int ID_Dolj;
        public static int ID_Zayavka;
        public static int ID_TT;
        public static int ID_Group;
        public static int ID_Status;
        public static int ID;
        public static int ID_TipRabot;
        public static int ID_Vip_no_Rabot;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zastavka());
            Application.Run(new SignInForm());
        }
    }
}
