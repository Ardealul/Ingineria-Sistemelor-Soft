namespace UrmarireBuguri
{
    partial class ProgramatorWindow
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
            this.bugDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.eliminaBugButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bugDataGridView
            // 
            this.bugDataGridView.AllowUserToAddRows = false;
            this.bugDataGridView.AllowUserToDeleteRows = false;
            this.bugDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bugDataGridView.Location = new System.Drawing.Point(54, 71);
            this.bugDataGridView.Name = "bugDataGridView";
            this.bugDataGridView.ReadOnly = true;
            this.bugDataGridView.RowTemplate.Height = 24;
            this.bugDataGridView.Size = new System.Drawing.Size(461, 329);
            this.bugDataGridView.TabIndex = 0;
            this.bugDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bugDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista bug-uri";
            // 
            // eliminaBugButton
            // 
            this.eliminaBugButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminaBugButton.Location = new System.Drawing.Point(366, 433);
            this.eliminaBugButton.Name = "eliminaBugButton";
            this.eliminaBugButton.Size = new System.Drawing.Size(118, 36);
            this.eliminaBugButton.TabIndex = 2;
            this.eliminaBugButton.Text = "Elimina";
            this.eliminaBugButton.UseVisualStyleBackColor = true;
            this.eliminaBugButton.Click += new System.EventHandler(this.eliminaBugButton_Click);
            // 
            // ProgramatorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 496);
            this.Controls.Add(this.eliminaBugButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bugDataGridView);
            this.Name = "ProgramatorWindow";
            this.Text = "ProgramatorWindow";
            ((System.ComponentModel.ISupportInitialize)(this.bugDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bugDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminaBugButton;
    }
}