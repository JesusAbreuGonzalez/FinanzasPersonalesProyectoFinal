
namespace FinanzasPersonalesProyectoFinal.UI.Registros
{
    partial class rRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rRoles));
            this.ActivoCheckBox = new System.Windows.Forms.CheckBox();
            this.RolIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.RolIdLabel = new System.Windows.Forms.Label();
            this.DetalleGroupBox = new System.Windows.Forms.GroupBox();
            this.RolDataGridView = new System.Windows.Forms.DataGridView();
            this.AsignadoCheckBox = new System.Windows.Forms.CheckBox();
            this.PermisoIdComboBox = new System.Windows.Forms.ComboBox();
            this.PermisoIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).BeginInit();
            this.DetalleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivoCheckBox
            // 
            this.ActivoCheckBox.AutoSize = true;
            this.ActivoCheckBox.Location = new System.Drawing.Point(483, 53);
            this.ActivoCheckBox.Name = "ActivoCheckBox";
            this.ActivoCheckBox.Size = new System.Drawing.Size(60, 19);
            this.ActivoCheckBox.TabIndex = 26;
            this.ActivoCheckBox.Text = "Activo";
            this.ActivoCheckBox.UseVisualStyleBackColor = true;
            // 
            // RolIdNumericUpDown
            // 
            this.RolIdNumericUpDown.Location = new System.Drawing.Point(94, 15);
            this.RolIdNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RolIdNumericUpDown.Name = "RolIdNumericUpDown";
            this.RolIdNumericUpDown.Size = new System.Drawing.Size(136, 23);
            this.RolIdNumericUpDown.TabIndex = 24;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(94, 51);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(203, 23);
            this.DescripcionTextBox.TabIndex = 23;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescripcionLabel.Location = new System.Drawing.Point(18, 52);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(76, 17);
            this.DescripcionLabel.TabIndex = 22;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // RolIdLabel
            // 
            this.RolIdLabel.AutoSize = true;
            this.RolIdLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RolIdLabel.Location = new System.Drawing.Point(18, 15);
            this.RolIdLabel.Name = "RolIdLabel";
            this.RolIdLabel.Size = new System.Drawing.Size(19, 17);
            this.RolIdLabel.TabIndex = 21;
            this.RolIdLabel.Text = "Id";
            // 
            // DetalleGroupBox
            // 
            this.DetalleGroupBox.Controls.Add(this.RemoverButton);
            this.DetalleGroupBox.Controls.Add(this.AgregarButton);
            this.DetalleGroupBox.Controls.Add(this.RolDataGridView);
            this.DetalleGroupBox.Controls.Add(this.AsignadoCheckBox);
            this.DetalleGroupBox.Controls.Add(this.PermisoIdComboBox);
            this.DetalleGroupBox.Controls.Add(this.PermisoIdLabel);
            this.DetalleGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetalleGroupBox.Location = new System.Drawing.Point(12, 79);
            this.DetalleGroupBox.Name = "DetalleGroupBox";
            this.DetalleGroupBox.Size = new System.Drawing.Size(542, 312);
            this.DetalleGroupBox.TabIndex = 27;
            this.DetalleGroupBox.TabStop = false;
            this.DetalleGroupBox.Text = "Detalle de Roles";
            // 
            // RolDataGridView
            // 
            this.RolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RolDataGridView.Location = new System.Drawing.Point(6, 66);
            this.RolDataGridView.Name = "RolDataGridView";
            this.RolDataGridView.RowTemplate.Height = 25;
            this.RolDataGridView.Size = new System.Drawing.Size(525, 240);
            this.RolDataGridView.TabIndex = 4;
            // 
            // AsignadoCheckBox
            // 
            this.AsignadoCheckBox.AutoSize = true;
            this.AsignadoCheckBox.Location = new System.Drawing.Point(230, 38);
            this.AsignadoCheckBox.Name = "AsignadoCheckBox";
            this.AsignadoCheckBox.Size = new System.Drawing.Size(82, 21);
            this.AsignadoCheckBox.TabIndex = 2;
            this.AsignadoCheckBox.Text = "Asignado";
            this.AsignadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermisoIdComboBox
            // 
            this.PermisoIdComboBox.FormattingEnabled = true;
            this.PermisoIdComboBox.Location = new System.Drawing.Point(82, 35);
            this.PermisoIdComboBox.Name = "PermisoIdComboBox";
            this.PermisoIdComboBox.Size = new System.Drawing.Size(142, 25);
            this.PermisoIdComboBox.TabIndex = 1;
            // 
            // PermisoIdLabel
            // 
            this.PermisoIdLabel.AutoSize = true;
            this.PermisoIdLabel.Location = new System.Drawing.Point(6, 38);
            this.PermisoIdLabel.Name = "PermisoIdLabel";
            this.PermisoIdLabel.Size = new System.Drawing.Size(70, 17);
            this.PermisoIdLabel.TabIndex = 0;
            this.PermisoIdLabel.Text = "Permiso Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(236, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(61, 29);
            this.BuscarButton.TabIndex = 28;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarButton.Image")));
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(313, 34);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(103, 26);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoverButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoverButton.Image")));
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(428, 34);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(103, 26);
            this.RemoverButton.TabIndex = 9;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(342, 397);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(90, 40);
            this.EliminarButton.TabIndex = 31;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(234, 397);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(90, 40);
            this.GuardarButton.TabIndex = 30;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(126, 397);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(90, 40);
            this.NuevoButton.TabIndex = 29;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // rRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 451);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DetalleGroupBox);
            this.Controls.Add(this.ActivoCheckBox);
            this.Controls.Add(this.RolIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.RolIdLabel);
            this.Name = "rRoles";
            this.Text = "Registro de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.RolIdNumericUpDown)).EndInit();
            this.DetalleGroupBox.ResumeLayout(false);
            this.DetalleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ActivoCheckBox;
        private System.Windows.Forms.NumericUpDown RolIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label RolIdLabel;
        private System.Windows.Forms.GroupBox DetalleGroupBox;
        private System.Windows.Forms.DataGridView RolDataGridView;
        private System.Windows.Forms.CheckBox AsignadoCheckBox;
        private System.Windows.Forms.ComboBox PermisoIdComboBox;
        private System.Windows.Forms.Label PermisoIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}