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
using UrmarireBuguri.domain;
using UrmarireBuguri.service;

namespace UrmarireBuguri
{
    public partial class VerificatorWindow : Form
    {
        private VerificatorController verificatorController;

        public VerificatorWindow(VerificatorController verificatorController)
        {
            InitializeComponent();
            this.verificatorController = verificatorController;
        }

        private void clearFields()
        {
            denumireTextBox.Clear();
            descriereTextBox.Clear();
        }

        private void adaugaBugButton_Click(object sender, EventArgs e)
        {
            string denumire = denumireTextBox.Text;
            string descriere = descriereTextBox.Text;
            verificatorController.addBug(denumire, descriere);
            clearFields();
        }
    }
}
