﻿
namespace FinanzasPersonalesProyectoFinal.UI.Consultas
{
    partial class cGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cGastos));
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GastosConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GastosConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Descripción",
            "Presupuesto id"});
            this.FiltroComboBox.Location = new System.Drawing.Point(50, 20);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(148, 23);
            this.FiltroComboBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Filtro";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(256, 20);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(405, 23);
            this.CriterioTextBox.TabIndex = 17;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(667, 20);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 16;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GastosConsultaDataGridView
            // 
            this.GastosConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GastosConsultaDataGridView.Location = new System.Drawing.Point(10, 56);
            this.GastosConsultaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GastosConsultaDataGridView.Name = "GastosConsultaDataGridView";
            this.GastosConsultaDataGridView.RowHeadersWidth = 51;
            this.GastosConsultaDataGridView.RowTemplate.Height = 29;
            this.GastosConsultaDataGridView.Size = new System.Drawing.Size(732, 313);
            this.GastosConsultaDataGridView.TabIndex = 15;
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(204, 23);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(46, 15);
            this.CriterioLabel.TabIndex = 22;
            this.CriterioLabel.Text = "Criterio";
            // 
            // cGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 380);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GastosConsultaDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cGastos";
            this.Text = "Consulta de Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.GastosConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView GastosConsultaDataGridView;
        private System.Windows.Forms.Label CriterioLabel;
    }
}