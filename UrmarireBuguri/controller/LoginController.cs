using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrmarireBuguri.domain;
using UrmarireBuguri.observer;
using UrmarireBuguri.service;

namespace UrmarireBuguri.controller
{
    public class LoginController: IObservable
    {
        public Service Service;
        private List<IObserver> observers = new List<IObserver>();

        public LoginController(Service service)
        {
            this.Service = service;
        }

        public void loginAdmin(string username, string password)
        {
            try
            {
                if(username == "admin" && password == "admin")
                {
                    AdminController ctrl = new AdminController(Service);
                    AdminWindow adminWindow = new AdminWindow(ctrl);
                    adminWindow.Text = "Admin: " + username;
                    adminWindow.Show();
                }
                else
                    throw new Exception("Username & password nu corespund niciunui admin!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void loginProgramator(string username, string password)
        {
            try
            {
                Programator programator = Service.findOneProgramator(username, password);
                if (programator == null)
                    throw new Exception("Username & password nu corespund niciunui programator!");
                ProgramatorController programatorController = new ProgramatorController(Service);
                ProgramatorWindow programatorWindow = new ProgramatorWindow(programatorController);

                addObserver(programatorController);
                notifyObservers();

                programatorWindow.Text = "Programator: " + programator.username;
                programatorWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void loginVerificator(string username, string password)
        {
            try
            {
                Verificator verificator = Service.findOneVerificator(username, password);
                if (verificator == null)
                    throw new Exception("Username & password nu corespund niciunui verificator!");
                VerificatorController verificatorController = new VerificatorController(Service);
                VerificatorWindow verificatorWindow = new VerificatorWindow(verificatorController);

                addObserver(verificatorController);
                notifyObservers();

                verificatorWindow.Text = "Verificator: " + verificator.username;
                verificatorWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.setObservers(observers);
            }
        }


    }
}
