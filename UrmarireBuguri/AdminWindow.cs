using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrmarireBuguri.controller;

namespace UrmarireBuguri
{
    public partial class AdminWindow : Form
    {
        private AdminController adminController;
        int currentID = -1;

        public AdminWindow(AdminController adminController)
        {
            InitializeComponent();
            passwordTextBox.MaxLength = 20;
            usernameTextBox.MaxLength = 20;
            this.adminController = adminController;
            adminController.setGridView(angajatiDataGridView);
            adminController.setComboBox(jobComboBox);
        }

        private void clearFields()
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }

        private void jobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string job = jobComboBox.SelectedItem.ToString();
            adminController.showAll(job);
        }

        private void angajatiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index == -1)
            {
                usernameTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                DataGridViewRow selectedRow = angajatiDataGridView.Rows[index];
                currentID = int.Parse(selectedRow.Cells[0].Value.ToString());
                usernameTextBox.Text = selectedRow.Cells[1].Value.ToString();
                passwordTextBox.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void adaugaContButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string job = jobComboBox.SelectedItem.ToString();
            adminController.addCont(username, password, job);
            clearFields();
        }

        private void stergeContButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string job = jobComboBox.SelectedItem.ToString();
            adminController.deleteCont(username, password, job);
            clearFields();
        }

        private void modificaContButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string job = jobComboBox.SelectedItem.ToString();
            adminController.updateCont(currentID, username, password, job);
            clearFields();
        }
    }
}
