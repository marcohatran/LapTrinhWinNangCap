using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiemWindows
{
    static class Program
    {
        public static FrmMain mainform = null;
        public static Login loginform = null;
        public static FrmTTSV ttsv = null;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
            UserLookAndFeel.Default.SetSkinStyle("Office 2007 Blue");
            loginform = new Login();
            //Application.Run(new FrmMain());
            Application.Run(loginform);
        }
    }
}
