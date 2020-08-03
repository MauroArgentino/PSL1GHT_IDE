/*
 * Creado por SharpDevelop.
 * Usuario: Alumno
 * Fecha: 1 jun. 2020
 * Hora: 14:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using DarkUI.Forms;

namespace PSL1GHT_IDE
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmPrincipal());
		}
		
	}
}
