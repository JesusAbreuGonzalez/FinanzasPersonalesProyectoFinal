
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CorreoTextBox = new System.Windows.Forms.TextBox();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CorreoPictureBox = new System.Windows.Forms.PictureBox();
            this.ClavePictureBox = new System.Windows.Forms.PictureBox();
            this.TituloPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CorreoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TituloPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorreoTextBox.Location = new System.Drawing.Point(51, 129);
            this.CorreoTextBox.Multiline = true;
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(311, 31);
            this.CorreoTextBox.TabIndex = 0;
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClaveTextBox.Location = new System.Drawing.Point(51, 178);
            this.ClaveTextBox.Multiline = true;
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.PasswordChar = '*';
            this.ClaveTextBox.Size = new System.Drawing.Size(311, 31);
            this.ClaveTextBox.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(296, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Mostrar ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CorreoPictureBox
            // 
            this.CorreoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CorreoPictureBox.Image")));
            this.CorreoPictureBox.Location = new System.Drawing.Point(17, 129);
            this.CorreoPictureBox.Name = "CorreoPictureBox";
            this.CorreoPictureBox.Size = new System.Drawing.Size(28, 31);
            this.CorreoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CorreoPictureBox.TabIndex = 3;
            this.CorreoPictureBox.TabStop = false;
            // 
            // ClavePictureBox
            // 
            this.ClavePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ClavePictureBox.Image")));
            this.ClavePictureBox.Location = new System.Drawing.Point(17, 178);
            this.ClavePictureBox.Name = "ClavePictureBox";
            this.ClavePictureBox.Size = new System.Drawing.Size(28, 31);
            this.ClavePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClavePictureBox.TabIndex = 4;
            this.ClavePictureBox.TabStop = false;
            // 
            // TituloPictureBox
            // 
            this.TituloPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TituloPictureBox.Image")));
            this.TituloPictureBox.Location = new System.Drawing.Point(125, 12);
            this.TituloPictureBox.Name = "TituloPictureBox";
            this.TituloPictureBox.Size = new System.Drawing.Size(132, 104);
            this.TituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.TituloPictureBox.TabIndex = 5;
            this.TituloPictureBox.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.Location = new System.Drawing.Point(125, 235);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(132, 36);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Entrar";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 283);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TituloPictureBox);
            this.Controls.Add(this.ClavePictureBox);
            this.Controls.Add(this.CorreoPictureBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.CorreoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.CorreoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClavePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TituloPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CorreoTextBox;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox CorreoPictureBox;
        private System.Windows.Forms.PictureBox ClavePictureBox;
        private System.Windows.Forms.PictureBox TituloPictureBox;
        private System.Windows.Forms.Button LoginButton;
    }
}