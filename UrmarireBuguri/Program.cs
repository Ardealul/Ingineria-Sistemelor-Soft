using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrmarireBuguri.controller;
using UrmarireBuguri.repo;
using UrmarireBuguri.service;

namespace UrmarireBuguri
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

            BugRepo bugRepo = new BugRepo();
            ProgramatorRepo programatorRepo = new ProgramatorRepo();
            VerificatorRepo verificatorRepo = new VerificatorRepo();
            Service service = new Service(bugRepo, programatorRepo, verificatorRepo);
            LoginController loginController = new LoginController(service);

            Application.Run(new LoginWindow(loginController));
        }
    }
}
