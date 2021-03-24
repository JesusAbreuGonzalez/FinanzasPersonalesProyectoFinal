﻿
namespace FinanzasPersonalesProyectoFinal
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroGastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultaCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrosToolStripMenuItem,
            this.ConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegistrosToolStripMenuItem
            // 
            this.RegistrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroRolesToolStripMenuItem,
            this.RegistroUsuariosToolStripMenuItem,
            this.RegistroPresupuestosToolStripMenuItem,
            this.RegistroCategoriasToolStripMenuItem,
            this.RegistroGastosToolStripMenuItem,
            this.RegistroIngresosToolStripMenuItem});
            this.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem";
            this.RegistrosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.RegistrosToolStripMenuItem.Text = "&Registros";
            // 
            // RegistroRolesToolStripMenuItem
            // 
            this.RegistroRolesToolStripMenuItem.Name = "RegistroRolesToolStripMenuItem";
            this.RegistroRolesToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.RegistroRolesToolStripMenuItem.Text = "&Roles";
            // 
            // RegistroUsuariosToolStripMenuItem
            // 
            this.RegistroUsuariosToolStripMenuItem.Name = "RegistroUsuariosToolStripMenuItem";
            this.RegistroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.RegistroUsuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // RegistroPresupuestosToolStripMenuItem
            // 
            this.RegistroPresupuestosToolStripMenuItem.Name = "RegistroPresupuestosToolStripMenuItem";
            this.RegistroPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.RegistroPresupuestosToolStripMenuItem.Text = "&Presupuetos";
            // 
            // RegistroCategoriasToolStripMenuItem
            // 
            this.RegistroCategoriasToolStripMenuItem.Name = "RegistroCategoriasToolStripMenuItem";
            this.RegistroCategoriasToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.RegistroCategoriasToolStripMenuItem.Text = "&Categoría";
            // 
            // RegistroGastosToolStripMenuItem
            // 
            this.RegistroGastosToolStripMenuItem.Name = "RegistroGastosToolStripMenuItem";
            this.RegistroGastosToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.RegistroGastosToolStripMenuItem.Text = "&Gastos";
            // 
            // RegistroIngresosToolStripMenuItem
            // 
            this.RegistroIngresosToolStripMenuItem.Name = "RegistroIngresosToolStripMenuItem";
            this.RegistroIngresosToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.RegistroIngresosToolStripMenuItem.Text = "&Ingresos";
            // 
            // ConsultasToolStripMenuItem
            // 
            this.ConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConsultaUsuariosToolStripMenuItem,
            this.ConsultaCategoriasToolStripMenuItem});
            this.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem";
            this.ConsultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.ConsultasToolStripMenuItem.Text = "&Consultas";
            // 
            // ConsultaUsuariosToolStripMenuItem
            // 
            this.ConsultaUsuariosToolStripMenuItem.Name = "ConsultaUsuariosToolStripMenuItem";
            this.ConsultaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.ConsultaUsuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // ConsultaCategoriasToolStripMenuItem
            // 
            this.ConsultaCategoriasToolStripMenuItem.Name = "ConsultaCategoriasToolStripMenuItem";
            this.ConsultaCategoriasToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.ConsultaCategoriasToolStripMenuItem.Text = "&Categorías";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroPresupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroGastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaCategoriasToolStripMenuItem;
    }
}

