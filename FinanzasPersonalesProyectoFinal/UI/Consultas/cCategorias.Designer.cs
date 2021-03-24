﻿
namespace FinanzasPersonalesProyectoFinal.UI.Consultas
{
    partial class cCategorias
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
            this.FechaCheckBox = new System.Windows.Forms.CheckBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CategoriasConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.Location = new System.Drawing.Point(10, 26);
            this.FechaCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(130, 19);
            this.FechaCheckBox.TabIndex = 14;
            this.FechaCheckBox.Text = "Usar filtro de fechas";
            this.FechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Nombre"});
            this.FiltroComboBox.Location = new System.Drawing.Point(53, 58);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(106, 23);
            this.FiltroComboBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtro";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.HastaDateTimePicker);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Location = new System.Drawing.Point(180, 9);
            this.GroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupBox.Size = new System.Drawing.Size(456, 44);
            this.GroupBox.TabIndex = 12;
            this.GroupBox.TabStop = false;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(314, 15);
            this.HastaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(137, 23);
            this.HastaDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(55, 15);
            this.DesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(137, 23);
            this.DesdeDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(180, 58);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(456, 23);
            this.CriterioTextBox.TabIndex = 10;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(641, 17);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(101, 64);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CategoriasConsultaDataGridView
            // 
            this.CategoriasConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriasConsultaDataGridView.Location = new System.Drawing.Point(10, 90);
            this.CategoriasConsultaDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoriasConsultaDataGridView.Name = "CategoriasConsultaDataGridView";
            this.CategoriasConsultaDataGridView.RowHeadersWidth = 51;
            this.CategoriasConsultaDataGridView.RowTemplate.Height = 29;
            this.CategoriasConsultaDataGridView.Size = new System.Drawing.Size(732, 326);
            this.CategoriasConsultaDataGridView.TabIndex = 7;
            // 
            // cCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 426);
            this.Controls.Add(this.FechaCheckBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CategoriasConsultaDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "cCategorias";
            this.Text = "Consuta de Categorias";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriasConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FechaCheckBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView CategoriasConsultaDataGridView;
    }
}