
namespace FinanzasPersonalesProyectoFinal.UI.Consultas
{
    partial class cRoles
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
            this.ActivoGroupBox = new System.Windows.Forms.GroupBox();
            this.InactivosRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivosRadioButton = new System.Windows.Forms.RadioButton();
            this.TodosRadioButton = new System.Windows.Forms.RadioButton();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.RolesConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupBox.SuspendLayout();
            this.ActivoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.Location = new System.Drawing.Point(14, 36);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(163, 24);
            this.FechaCheckBox.TabIndex = 14;
            this.FechaCheckBox.Text = "Usar filtro de fechas";
            this.FechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Descripción"});
            this.FiltroComboBox.Location = new System.Drawing.Point(63, 77);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(121, 28);
            this.FiltroComboBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Filtro";
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.HastaDateTimePicker);
            this.GroupBox.Controls.Add(this.label2);
            this.GroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Location = new System.Drawing.Point(208, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(521, 59);
            this.GroupBox.TabIndex = 12;
            this.GroupBox.TabStop = false;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(359, 20);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(156, 27);
            this.HastaDateTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(63, 20);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(156, 27);
            this.DesdeDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(208, 77);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(521, 27);
            this.CriterioTextBox.TabIndex = 10;
            // 
            // ActivoGroupBox
            // 
            this.ActivoGroupBox.Controls.Add(this.InactivosRadioButton);
            this.ActivoGroupBox.Controls.Add(this.ActivosRadioButton);
            this.ActivoGroupBox.Controls.Add(this.TodosRadioButton);
            this.ActivoGroupBox.Location = new System.Drawing.Point(735, 12);
            this.ActivoGroupBox.Name = "ActivoGroupBox";
            this.ActivoGroupBox.Size = new System.Drawing.Size(123, 99);
            this.ActivoGroupBox.TabIndex = 9;
            this.ActivoGroupBox.TabStop = false;
            this.ActivoGroupBox.Text = "EsActivo?";
            // 
            // InactivosRadioButton
            // 
            this.InactivosRadioButton.AutoSize = true;
            this.InactivosRadioButton.Location = new System.Drawing.Point(6, 67);
            this.InactivosRadioButton.Name = "InactivosRadioButton";
            this.InactivosRadioButton.Size = new System.Drawing.Size(82, 24);
            this.InactivosRadioButton.TabIndex = 2;
            this.InactivosRadioButton.Text = "Inactivo";
            this.InactivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // ActivosRadioButton
            // 
            this.ActivosRadioButton.AutoSize = true;
            this.ActivosRadioButton.Location = new System.Drawing.Point(6, 43);
            this.ActivosRadioButton.Name = "ActivosRadioButton";
            this.ActivosRadioButton.Size = new System.Drawing.Size(78, 24);
            this.ActivosRadioButton.TabIndex = 1;
            this.ActivosRadioButton.Text = "Activos";
            this.ActivosRadioButton.UseVisualStyleBackColor = true;
            // 
            // TodosRadioButton
            // 
            this.TodosRadioButton.AutoSize = true;
            this.TodosRadioButton.Checked = true;
            this.TodosRadioButton.Location = new System.Drawing.Point(6, 19);
            this.TodosRadioButton.Name = "TodosRadioButton";
            this.TodosRadioButton.Size = new System.Drawing.Size(70, 24);
            this.TodosRadioButton.TabIndex = 0;
            this.TodosRadioButton.TabStop = true;
            this.TodosRadioButton.Text = "Todos";
            this.TodosRadioButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::FinanzasPersonalesProyectoFinal.Properties.Resources.lupa;
            this.BuscarButton.Location = new System.Drawing.Point(864, 24);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(115, 85);
            this.BuscarButton.TabIndex = 8;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // RolesConsultaDataGridView
            // 
            this.RolesConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolesConsultaDataGridView.Location = new System.Drawing.Point(14, 120);
            this.RolesConsultaDataGridView.Name = "RolesConsultaDataGridView";
            this.RolesConsultaDataGridView.RowHeadersWidth = 51;
            this.RolesConsultaDataGridView.RowTemplate.Height = 29;
            this.RolesConsultaDataGridView.Size = new System.Drawing.Size(965, 435);
            this.RolesConsultaDataGridView.TabIndex = 7;
            // 
            // cRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 572);
            this.Controls.Add(this.FechaCheckBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.ActivoGroupBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.RolesConsultaDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "cRoles";
            this.Text = "Consultar Roles";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ActivoGroupBox.ResumeLayout(false);
            this.ActivoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolesConsultaDataGridView)).EndInit();
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
        private System.Windows.Forms.GroupBox ActivoGroupBox;
        private System.Windows.Forms.RadioButton InactivosRadioButton;
        private System.Windows.Forms.RadioButton ActivosRadioButton;
        private System.Windows.Forms.RadioButton TodosRadioButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView RolesConsultaDataGridView;
    }
}