
namespace FinanzasPersonalesProyectoFinal.UI.Registros
{
    partial class rPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rPresupuestos));
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.MontoPresupuestoTextBox = new System.Windows.Forms.TextBox();
            this.CategoriasLabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.PresupuestosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.UsuarioIdLabel = new System.Windows.Forms.Label();
            this.CategoriasComboBox = new System.Windows.Forms.ComboBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.RegistroPresupuestosErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroPresupuestosErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(301, 21);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(63, 27);
            this.BuscarButton.TabIndex = 22;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(104, 76);
            this.NombresTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(260, 27);
            this.NombresTextBox.TabIndex = 20;
            // 
            // MontoPresupuestoTextBox
            // 
            this.MontoPresupuestoTextBox.Location = new System.Drawing.Point(104, 132);
            this.MontoPresupuestoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MontoPresupuestoTextBox.Name = "MontoPresupuestoTextBox";
            this.MontoPresupuestoTextBox.Size = new System.Drawing.Size(260, 27);
            this.MontoPresupuestoTextBox.TabIndex = 19;
            // 
            // CategoriasLabel
            // 
            this.CategoriasLabel.AutoSize = true;
            this.CategoriasLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriasLabel.Location = new System.Drawing.Point(16, 189);
            this.CategoriasLabel.Name = "CategoriasLabel";
            this.CategoriasLabel.Size = new System.Drawing.Size(91, 23);
            this.CategoriasLabel.TabIndex = 18;
            this.CategoriasLabel.Text = "Categorías";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombresLabel.Location = new System.Drawing.Point(16, 77);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(73, 23);
            this.NombresLabel.TabIndex = 17;
            this.NombresLabel.Text = "Nombre";
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MontoLabel.Location = new System.Drawing.Point(16, 133);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(61, 23);
            this.MontoLabel.TabIndex = 16;
            this.MontoLabel.Text = "Monto";
            // 
            // PresupuestosIdNumericUpDown
            // 
            this.PresupuestosIdNumericUpDown.Location = new System.Drawing.Point(104, 21);
            this.PresupuestosIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PresupuestosIdNumericUpDown.Name = "PresupuestosIdNumericUpDown";
            this.PresupuestosIdNumericUpDown.Size = new System.Drawing.Size(190, 27);
            this.PresupuestosIdNumericUpDown.TabIndex = 15;
            // 
            // UsuarioIdLabel
            // 
            this.UsuarioIdLabel.AutoSize = true;
            this.UsuarioIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsuarioIdLabel.Location = new System.Drawing.Point(16, 24);
            this.UsuarioIdLabel.Name = "UsuarioIdLabel";
            this.UsuarioIdLabel.Size = new System.Drawing.Size(25, 23);
            this.UsuarioIdLabel.TabIndex = 14;
            this.UsuarioIdLabel.Text = "Id";
            // 
            // CategoriasComboBox
            // 
            this.CategoriasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriasComboBox.FormattingEnabled = true;
            this.CategoriasComboBox.Location = new System.Drawing.Point(104, 188);
            this.CategoriasComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoriasComboBox.Name = "CategoriasComboBox";
            this.CategoriasComboBox.Size = new System.Drawing.Size(260, 28);
            this.CategoriasComboBox.TabIndex = 23;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(262, 240);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(103, 53);
            this.EliminarButton.TabIndex = 26;
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
            this.GuardarButton.Location = new System.Drawing.Point(141, 240);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(103, 53);
            this.GuardarButton.TabIndex = 25;
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
            this.NuevoButton.Location = new System.Drawing.Point(16, 240);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(103, 53);
            this.NuevoButton.TabIndex = 24;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RegistroPresupuestosErrorProvider
            // 
            this.RegistroPresupuestosErrorProvider.ContainerControl = this;
            // 
            // rPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 315);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.CategoriasComboBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.MontoPresupuestoTextBox);
            this.Controls.Add(this.CategoriasLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.MontoLabel);
            this.Controls.Add(this.PresupuestosIdNumericUpDown);
            this.Controls.Add(this.UsuarioIdLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(399, 362);
            this.MinimumSize = new System.Drawing.Size(399, 362);
            this.Name = "rPresupuestos";
            this.Text = "Registro de Presupuestos";
            this.Load += new System.EventHandler(this.rPresupuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistroPresupuestosErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.TextBox MontoPresupuestoTextBox;
        private System.Windows.Forms.Label CategoriasLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.NumericUpDown PresupuestosIdNumericUpDown;
        private System.Windows.Forms.Label UsuarioIdLabel;
        private System.Windows.Forms.ComboBox CategoriasComboBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider RegistroPresupuestosErrorProvider;
    }
}