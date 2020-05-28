using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrmarireBuguri.domain;
using UrmarireBuguri.service;

namespace UrmarireBuguri.controller
{
    public class AdminController
    {
        private Service Service;
        private DataTable dataTable;
        private DataGridView dataGridView;
        private ComboBox comboBox;
        private int programatorMaxID = 0;
        private int verificatorMaxID = 0;

        public AdminController(Service service)
        {
            this.Service = service;

            this.dataTable = new DataTable();
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Password");
        }

        public void setGridView(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
        }
        public void setComboBox(ComboBox comboBox)
        {
            this.comboBox = comboBox;
            List<string> joburi = new List<string>();
            joburi.Add("Programator");
            joburi.Add("Verificator");
            comboBox.DataSource = joburi;
            showAll(comboBox.SelectedItem.ToString());
        }

        public void showAll(string job)
        {
            if(job == "Programator")
            {
                showAllProgramator();
            }
            else if(job == "Verificator")
            {
                showAllVerificator();
            }
        }

        private void showAllProgramator()
        {
            try
            {
                dataTable.Rows.Clear();
                foreach (Programator programator in Service.findAllProgramator())
                {
                    dataTable.Rows.Add(programator.id, programator.username, programator.password);
                    programatorMaxID = programator.id;
                }
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showAllVerificator()
        {
            try
            {
                dataTable.Rows.Clear();
                foreach (Verificator verificator in Service.findAllVerificator())
                {
                    dataTable.Rows.Add(verificator.id, verificator.username, verificator.password);
                    verificatorMaxID = verificator.id;
                }
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addCont(string username, string password, string job)
        {
            try
            {
                if (username == "" || password == "")
                    throw new Exception("Username & password nu pot fi campuri goale!");
                if (job == "Verificator")
                {
                    int id = verificatorMaxID + 1;
                    Service.addVerificator(id, username, password);
                    showAllVerificator();
                }
                else if (job == "Programator")
                {
                    int id = programatorMaxID + 1;
                    Service.addProgramator(id, username, password);
                    showAllProgramator();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void deleteCont(string username, string password, string job)
        {
            try
            {
                if (job == "Verificator")
                {
                    Service.deleteVerificator(username, password);
                    showAllVerificator();
                }
                else if (job == "Programator")
                {
                    Service.deleteProgramator(username, password);
                    showAllProgramator();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void updateCont(int id, string username, string password, string job)
        {
            try
            {
                if(job == "Verificator")
                {
                    Service.updateVerificator(id, username, password);
                    showAllVerificator();
                }
                else if(job == "Programator")
                {
                    Service.updateProgramator(id, username, password);
                    showAllProgramator();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
