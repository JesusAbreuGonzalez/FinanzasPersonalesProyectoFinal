
namespace FinanzasPersonalesProyectoFinal.UI.Registros
{
    partial class rGastos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rGastos));
            this.GastosErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IdGastosLabel = new System.Windows.Forms.Label();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.PresupuestoLabel = new System.Windows.Forms.Label();
            this.DetalleGastosGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.GastosDataGridView = new System.Windows.Forms.DataGridView();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.GastoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescipcionTextBox = new System.Windows.Forms.TextBox();
            this.PresupuestoIdComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GastosErrorProvider)).BeginInit();
            this.DetalleGastosGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GastosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GastoIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GastosErrorProvider
            // 
            this.GastosErrorProvider.ContainerControl = this;
            // 
            // IdGastosLabel
            // 
            this.IdGastosLabel.AutoSize = true;
            this.IdGastosLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdGastosLabel.Location = new System.Drawing.Point(20, 9);
            this.IdGastosLabel.Name = "IdGastosLabel";
            this.IdGastosLabel.Size = new System.Drawing.Size(25, 23);
            this.IdGastosLabel.TabIndex = 0;
            this.IdGastosLabel.Text = "Id";
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionLabel.Location = new System.Drawing.Point(18, 64);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(98, 23);
            this.DescripcionLabel.TabIndex = 1;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // PresupuestoLabel
            // 
            this.PresupuestoLabel.AutoSize = true;
            this.PresupuestoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PresupuestoLabel.Location = new System.Drawing.Point(292, 64);
            this.PresupuestoLabel.Name = "PresupuestoLabel";
            this.PresupuestoLabel.Size = new System.Drawing.Size(104, 23);
            this.PresupuestoLabel.TabIndex = 2;
            this.PresupuestoLabel.Text = "Presupuesto";
            // 
            // DetalleGastosGroupBox
            // 
            this.DetalleGastosGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGastosGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGastosGroupBox.Controls.Add(this.GastosDataGridView);
            this.DetalleGastosGroupBox.Controls.Add(this.MontoTextBox);
            this.DetalleGastosGroupBox.Controls.Add(this.MontoLabel);
            this.DetalleGastosGroupBox.Location = new System.Drawing.Point(12, 115);
            this.DetalleGastosGroupBox.Name = "DetalleGastosGroupBox";
            this.DetalleGastosGroupBox.Size = new System.Drawing.Size(517, 301);
            this.DetalleGastosGroupBox.TabIndex = 3;
            this.DetalleGastosGroupBox.TabStop = false;
            this.DetalleGastosGroupBox.Text = "Detalle del Gasto";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(408, 41);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(103, 26);
            this.RemoverButton.TabIndex = 8;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(280, 41);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(103, 26);
            this.AgregarButton.TabIndex = 7;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // GastosDataGridView
            // 
            this.GastosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GastosDataGridView.Location = new System.Drawing.Point(6, 75);
            this.GastosDataGridView.Name = "GastosDataGridView";
            this.GastosDataGridView.RowHeadersWidth = 51;
            this.GastosDataGridView.RowTemplate.Height = 25;
            this.GastosDataGridView.Size = new System.Drawing.Size(505, 220);
            this.GastosDataGridView.TabIndex = 6;
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(6, 41);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(261, 29);
            this.MontoTextBox.TabIndex = 5;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MontoLabel.Location = new System.Drawing.Point(6, 21);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(61, 23);
            this.MontoLabel.TabIndex = 3;
            this.MontoLabel.Text = "Monto";
            // 
            // GastoIdNumericUpDown
            // 
            this.GastoIdNumericUpDown.Location = new System.Drawing.Point(20, 30);
            this.GastoIdNumericUpDown.Name = "GastoIdNumericUpDown";
            this.GastoIdNumericUpDown.Size = new System.Drawing.Size(192, 29);
            this.GastoIdNumericUpDown.TabIndex = 4;
            // 
            // DescipcionTextBox
            // 
            this.DescipcionTextBox.Location = new System.Drawing.Point(18, 84);
            this.DescipcionTextBox.Name = "DescipcionTextBox";
            this.DescipcionTextBox.Size = new System.Drawing.Size(261, 29);
            this.DescipcionTextBox.TabIndex = 5;
            // 
            // PresupuestoIdComboBox
            // 
            this.PresupuestoIdComboBox.FormattingEnabled = true;
            this.PresupuestoIdComboBox.Location = new System.Drawing.Point(292, 84);
            this.PresupuestoIdComboBox.Name = "PresupuestoIdComboBox";
            this.PresupuestoIdComboBox.Size = new System.Drawing.Size(231, 29);
            this.PresupuestoIdComboBox.TabIndex = 6;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(218, 30);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(61, 26);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(333, 422);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 40);
            this.EliminarButton.TabIndex = 22;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(225, 422);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(90, 40);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(117, 422);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(90, 40);
            this.NuevoButton.TabIndex = 20;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // rGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 477);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.PresupuestoIdComboBox);
            this.Controls.Add(this.DescipcionTextBox);
            this.Controls.Add(this.GastoIdNumericUpDown);
            this.Controls.Add(this.DetalleGastosGroupBox);
            this.Controls.Add(this.PresupuestoLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.IdGastosLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "rGastos";
            this.Text = "Registro de Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.GastosErrorProvider)).EndInit();
            this.DetalleGastosGroupBox.ResumeLayout(false);
            this.DetalleGastosGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GastosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GastoIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider GastosErrorProvider;
        private System.Windows.Forms.Label IdGastosLabel;
        private System.Windows.Forms.Label PresupuestoLabel;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ComboBox PresupuestoIdComboBox;
        private System.Windows.Forms.TextBox DescipcionTextBox;
        private System.Windows.Forms.NumericUpDown GastoIdNumericUpDown;
        private System.Windows.Forms.GroupBox DetalleGastosGroupBox;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.DataGridView GastosDataGridView;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button RemoverButton;
    }
}