/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 1 ago. 2020
 * Hora: 06:32
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PSL1GHT_IDE
{
	partial class frmAbout
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
		private DarkUI.Controls.DarkToolStrip darkToolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.darkToolStrip1 = new DarkUI.Controls.DarkToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.darkToolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// darkMenuStrip1
			// 
			this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.darkMenuStrip1.Name = "darkMenuStrip1";
			this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
			this.darkMenuStrip1.Size = new System.Drawing.Size(284, 24);
			this.darkMenuStrip1.TabIndex = 0;
			this.darkMenuStrip1.Text = "darkMenuStrip1";
			// 
			// darkToolStrip1
			// 
			this.darkToolStrip1.AutoSize = false;
			this.darkToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkToolStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkToolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
			this.darkToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripButton1});
			this.darkToolStrip1.Location = new System.Drawing.Point(0, 24);
			this.darkToolStrip1.Name = "darkToolStrip1";
			this.darkToolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
			this.darkToolStrip1.Size = new System.Drawing.Size(284, 28);
			this.darkToolStrip1.TabIndex = 1;
			this.darkToolStrip1.Text = "darkToolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// frmAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 259);
			this.Controls.Add(this.darkToolStrip1);
			this.Controls.Add(this.darkMenuStrip1);
			this.Name = "frmAbout";
			this.Text = "Form1";
			this.darkToolStrip1.ResumeLayout(false);
			this.darkToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
