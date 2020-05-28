namespace UrmarireBuguri
{
    partial class AdminWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jobComboBox = new System.Windows.Forms.ComboBox();
            this.angajatiDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.adaugaContButton = new System.Windows.Forms.Button();
            this.stergeContButton = new System.Windows.Forms.Button();
            this.modificaContButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // jobComboBox
            // 
            this.jobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobComboBox.FormattingEnabled = true;
            this.jobComboBox.Location = new System.Drawing.Point(181, 21);
            this.jobComboBox.Name = "jobComboBox";
            this.jobComboBox.Size = new System.Drawing.Size(180, 28);
            this.jobComboBox.TabIndex = 2;
            this.jobComboBox.SelectedIndexChanged += new System.EventHandler(this.jobComboBox_SelectedIndexChanged);
            // 
            // angajatiDataGridView
            // 
            this.angajatiDataGridView.AllowUserToAddRows = false;
            this.angajatiDataGridView.AllowUserToDeleteRows = false;
            this.angajatiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.angajatiDataGridView.Location = new System.Drawing.Point(26, 67);
            this.angajatiDataGridView.Name = "angajatiDataGridView";
            this.angajatiDataGridView.ReadOnly = true;
            this.angajatiDataGridView.RowTemplate.Height = 24;
            this.angajatiDataGridView.Size = new System.Drawing.Size(464, 316);
            this.angajatiDataGridView.TabIndex = 3;
            this.angajatiDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.angajatiDataGridView_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Job:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(710, 67);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(157, 24);
            this.usernameTextBox.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(710, 112);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(157, 24);
            this.passwordTextBox.TabIndex = 6;
            // 
            // adaugaContButton
            // 
            this.adaugaContButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaContButton.Location = new System.Drawing.Point(696, 165);
            this.adaugaContButton.Name = "adaugaContButton";
            this.adaugaContButton.Size = new System.Drawing.Size(147, 38);
            this.adaugaContButton.TabIndex = 7;
            this.adaugaContButton.Text = "Adauga cont";
            this.adaugaContButton.UseVisualStyleBackColor = true;
            this.adaugaContButton.Click += new System.EventHandler(this.adaugaContButton_Click);
            // 
            // stergeContButton
            // 
            this.stergeContButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeContButton.Location = new System.Drawing.Point(533, 324);
            this.stergeContButton.Name = "stergeContButton";
            this.stergeContButton.Size = new System.Drawing.Size(152, 46);
            this.stergeContButton.TabIndex = 8;
            this.stergeContButton.Text = "Sterge cont";
            this.stergeContButton.UseVisualStyleBackColor = true;
            this.stergeContButton.Click += new System.EventHandler(this.stergeContButton_Click);
            // 
            // modificaContButton
            // 
            this.modificaContButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaContButton.Location = new System.Drawing.Point(741, 324);
            this.modificaContButton.Name = "modificaContButton";
            this.modificaContButton.Size = new System.Drawing.Size(150, 46);
            this.modificaContButton.TabIndex = 9;
            this.modificaContButton.Text = "Modifica cont";
            this.modificaContButton.UseVisualStyleBackColor = true;
            this.modificaContButton.Click += new System.EventHandler(this.modificaContButton_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 430);
            this.Controls.Add(this.modificaContButton);
            this.Controls.Add(this.stergeContButton);
            this.Controls.Add(this.adaugaContButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.angajatiDataGridView);
            this.Controls.Add(this.jobComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            ((System.ComponentModel.ISupportInitialize)(this.angajatiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jobComboBox;
        private System.Windows.Forms.DataGridView angajatiDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button adaugaContButton;
        private System.Windows.Forms.Button stergeContButton;
        private System.Windows.Forms.Button modificaContButton;
    }
}