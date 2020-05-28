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
    public class VerificatorController: IObserver
    {
        public Service Service;
        private List<IObserver> observers;

        public VerificatorController(Service service)
        {
            this.Service = service;
        }

        public int getID()
        {
            int id = 0;
            foreach (Bug b in Service.findAllBug())
            {
                id = b.id;
            }
            return id;
        }

        public void addBug(string denumire, string descriere)
        {
            try
            {
                int id = getID() + 1;
                if (denumire == "" || descriere == "")
                    throw new Exception("Denumirea & descrierea bug-ului nu pot fi campuri goale!");
                Service.addBug(id, denumire, descriere);

                foreach (IObserver observer in observers)
                {
                    observer.update();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setObservers(List<IObserver> listOfObservers)
        {
            observers = listOfObservers;
        }

        public void update() { }
    }
}
