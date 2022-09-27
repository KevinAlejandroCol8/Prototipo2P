
namespace CapaVista
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTENIMIENTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSIGNACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAMBIOCONTRASEÑAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bITACORAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.mANTENIMIENTOSToolStripMenuItem,
            this.aSIGNACIONESToolStripMenuItem,
            this.cAMBIOCONTRASEÑAToolStripMenuItem,
            this.bITACORAToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.iNICIOToolStripMenuItem.Text = "ABRIR";
            // 
            // mANTENIMIENTOSToolStripMenuItem
            // 
            this.mANTENIMIENTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.aplicacionesToolStripMenuItem});
            this.mANTENIMIENTOSToolStripMenuItem.Name = "mANTENIMIENTOSToolStripMenuItem";
            this.mANTENIMIENTOSToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.mANTENIMIENTOSToolStripMenuItem.Text = "CATALOGOS";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Maestros";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // aplicacionesToolStripMenuItem
            // 
            this.aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            this.aplicacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aplicacionesToolStripMenuItem.Text = "Facultades";
            this.aplicacionesToolStripMenuItem.Click += new System.EventHandler(this.aplicacionesToolStripMenuItem_Click);
            // 
            // aSIGNACIONESToolStripMenuItem
            // 
            this.aSIGNACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem});
            this.aSIGNACIONESToolStripMenuItem.Name = "aSIGNACIONESToolStripMenuItem";
            this.aSIGNACIONESToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.aSIGNACIONESToolStripMenuItem.Text = "PROCESOS";
            // 
            // asignacionesDeAplicacionesAUsuariosToolStripMenuItem
            // 
            this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem.Name = "asignacionesDeAplicacionesAUsuariosToolStripMenuItem";
            this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem.Text = "Asignaciones  Curso Maestros";
            this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem.Click += new System.EventHandler(this.asignacionesDeAplicacionesAUsuariosToolStripMenuItem_Click);
            // 
            // cAMBIOCONTRASEÑAToolStripMenuItem
            // 
            this.cAMBIOCONTRASEÑAToolStripMenuItem.Name = "cAMBIOCONTRASEÑAToolStripMenuItem";
            this.cAMBIOCONTRASEÑAToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cAMBIOCONTRASEÑAToolStripMenuItem.Text = "INFORMES";
            // 
            // bITACORAToolStripMenuItem
            // 
            this.bITACORAToolStripMenuItem.Name = "bITACORAToolStripMenuItem";
            this.bITACORAToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.bITACORAToolStripMenuItem.Text = "HERRAMIENTAS";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 626);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSIGNACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionesDeAplicacionesAUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAMBIOCONTRASEÑAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bITACORAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
    }
}