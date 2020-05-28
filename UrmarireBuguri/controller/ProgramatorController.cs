using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrmarireBuguri.domain;
using UrmarireBuguri.observer;
using UrmarireBuguri.service;

namespace UrmarireBuguri.controller
{
    public class ProgramatorController: IObserver
    {
        private Service Service;
        private DataTable dataTable;
        private DataGridView dataGridView;
        private List<IObserver> observers;

        public ProgramatorController(Service service)
        {
            this.Service = service;

            this.dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Denumire");
            dataTable.Columns.Add("Descriere");
        }

        public void setGridView(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }

        public void showAllBugs()
        {
            try
            {
                dataTable.Rows.Clear();
                foreach (Bug b in Service.findAllBug())
                {
                    dataTable.Rows.Add(b.id, b.denumire, b.descriere);
                }
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteBug(int id)
        {
            Service.deleteBug(id);
            showAllBugs();

            foreach(IObserver observer in observers)
            {
                observer.update();
            }
        }

        public void setObservers(List<IObserver> listOfObservers)
        {
            observers = listOfObservers;
        }

        public void update(){ showAllBugs(); }
    }
}
