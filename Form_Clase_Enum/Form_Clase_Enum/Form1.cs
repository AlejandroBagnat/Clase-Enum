using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public class Alumno
        {
            public tipodocumento tipodocumento { get; set; }
           

            public string Nombre { get; set; }
            public int NumDocumento { get; set; }
            

            enum tipodocumento  {DNI,cedula,DU };
            enum notadescripcion {aprobado, desaprobado };

            
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();
            Alumno Alu = new Alumno();
          

            Alu.Nombre = TxtNombre.Text;
            CmdTipo.Items.Add("DNI");
            CmdTipo.Items.Add("Cedula");
            CmdTipo.Items.Add("DU");
            Alu.tipodocumento = CmdTipo.SelectedIndex ;
            
            
         
           
            Alu.NumDocumento =int.Parse(TxtNumDoc.Text);




        }

    

     
    }
}
