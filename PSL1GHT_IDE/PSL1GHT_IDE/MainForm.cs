/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 1 jun. 2020
 * Hora: 14:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DarkUI.Forms;

namespace PSL1GHT_IDE
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmPrincipal : DarkForm
	{
		public frmPrincipal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ArchivoToolStripMenuItemClick(object sender, EventArgs e)
		{
			DarkUI.Forms.DarkOpenFileDialog frmAbrir = new DarkOpenFileDialog();
			
			frmAbrir.ShowDialog();
		}
		
	}
}
