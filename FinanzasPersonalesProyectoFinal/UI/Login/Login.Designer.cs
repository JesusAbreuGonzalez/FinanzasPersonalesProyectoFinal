
namespace FinanzasPersonalesProyectoFinal.UI.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.NombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.MostrarCheckBox = new System.Windows.Forms.CheckBox();
            this.CorreoPictureBox = new System.Windows.Forms.PictureBox();
            this.ClavePictureBox = new System.Windows.Forms.PictureBox();
            this.TituloPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CorreoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TituloPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreCompletoTextBox
            // 
            this.NombreCompletoTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NombreCompletoTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.NombreCompletoTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.NombreCompletoTextBox.Location = new System.Drawing.Point(58, 172);
            this.NombreCompletoTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombreCompletoTextBox.Multiline = true;
            this.NombreCompletoTextBox.Name = "NombreCompletoTextBox";
            this.NombreCompletoTextBox.Size = new System.Drawing.Size(355, 40);
            this.NombreCompletoTextBox.TabIndex = 0;
            this.NombreCompletoTextBox.Text = "Nombre Completo";
            this.NombreCompletoTextBox.Enter += new System.EventHandler(this.NombreCompletoTextBox_Enter);
            this.NombreCompletoTextBox.Leave += new System.EventHandler(this.NombreCompletoTextBox_Leave);
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClaveTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ClaveTextBox.Location = new System.Drawing.Point(58, 237);
            this.ClaveTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClaveTextBox.Multiline = true;
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(355, 40);
            this.ClaveTextBox.TabIndex = 1;
            this.ClaveTextBox.Text = "Contraseña";
            this.ClaveTextBox.Enter += new System.EventHandler(this.ClaveTextBox_Enter);
            this.ClaveTextBox.Leave += new System.EventHandler(this.ClaveTextBox_Leave);
            // 
            // MostrarCheckBox
            // 
            this.MostrarCheckBox.AutoSize = true;
            this.MostrarCheckBox.Location = new System.Drawing.Point(338, 287);
            this.MostrarCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MostrarCheckBox.Name = "MostrarCheckBox";
            this.MostrarCheckBox.Size = new System.Drawing.Size(86, 24);
            this.MostrarCheckBox.TabIndex = 2;
            this.MostrarCheckBox.Text = "Mostrar ";
            this.MostrarCheckBox.UseVisualStyleBackColor = true;
            this.MostrarCheckBox.CheckedChanged += new System.EventHandler(this.MostrarCheckBox_CheckedChanged);
            // 
            // CorreoPictureBox
            // 
            this.CorreoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CorreoPictureBox.Image")));
            this.CorreoPictureBox.Location = new System.Drawing.Point(19, 172);
            this.CorreoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CorreoPictureBox.Name = "CorreoPictureBox";
            this.CorreoPictureBox.Size = new System.Drawing.Size(32, 41);
            this.CorreoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CorreoPictureBox.TabIndex = 3;
            this.CorreoPictureBox.TabStop = false;
            // 
            // ClavePictureBox
            // 
            this.ClavePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClavePictureBox.Image")));
            this.ClavePictureBox.Location = new System.Drawing.Point(19, 237);
            this.ClavePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClavePictureBox.Name = "ClavePictureBox";
            this.ClavePictureBox.Size = new System.Drawing.Size(32, 41);
            this.ClavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClavePictureBox.TabIndex = 4;
            this.ClavePictureBox.TabStop = false;
            // 
            // TituloPictureBox
            // 
            this.TituloPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TituloPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TituloPictureBox.Image")));
            this.TituloPictureBox.Location = new System.Drawing.Point(143, 16);
            this.TituloPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TituloPictureBox.Name = "TituloPictureBox";
            this.TituloPictureBox.Size = new System.Drawing.Size(151, 139);
            this.TituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TituloPictureBox.TabIndex = 5;
            this.TituloPictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.Location = new System.Drawing.Point(143, 313);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(151, 48);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Entrar";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 377);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TituloPictureBox);
            this.Controls.Add(this.ClavePictureBox);
            this.Controls.Add(this.CorreoPictureBox);
            this.Controls.Add(this.MostrarCheckBox);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.NombreCompletoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(450, 424);
            this.MinimumSize = new System.Drawing.Size(450, 424);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CorreoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TituloPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreCompletoTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.CheckBox MostrarCheckBox;
        private System.Windows.Forms.PictureBox CorreoPictureBox;
        private System.Windows.Forms.PictureBox ClavePictureBox;
        private System.Windows.Forms.PictureBox TituloPictureBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
    }
}