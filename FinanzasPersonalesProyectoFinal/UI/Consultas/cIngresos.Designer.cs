
namespace FinanzasPersonalesProyectoFinal.UI.Consultas
{
    partial class cIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cIngresos));
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.IngresosConsultaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(206, 23);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(46, 15);
            this.CriterioLabel.TabIndex = 27;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Id",
            "Descripción",
            "Presupuesto id"});
            this.FiltroComboBox.Location = new System.Drawing.Point(52, 20);
            this.FiltroComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(148, 23);
            this.FiltroComboBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Filtro";
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Location = new System.Drawing.Point(258, 20);
            this.CriterioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(405, 23);
            this.CriterioTextBox.TabIndex = 24;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(669, 20);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 23;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // IngresosConsultaDataGridView
            // 
            this.IngresosConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresosConsultaDataGridView.Location = new System.Drawing.Point(12, 55);
            this.IngresosConsultaDataGridView.Name = "IngresosConsultaDataGridView";
            this.IngresosConsultaDataGridView.RowTemplate.Height = 25;
            this.IngresosConsultaDataGridView.Size = new System.Drawing.Size(732, 313);
            this.IngresosConsultaDataGridView.TabIndex = 28;
            // 
            // cIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 380);
            this.Controls.Add(this.IngresosConsultaDataGridView);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Name = "cIngresos";
            this.Text = "Consultar Ingresos";
            ((System.ComponentModel.ISupportInitialize)(this.IngresosConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView IngresosConsultaDataGridView;
    }
}