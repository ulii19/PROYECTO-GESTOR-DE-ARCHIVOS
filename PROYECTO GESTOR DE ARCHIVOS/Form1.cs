using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_GESTOR_DE_ARCHIVOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string RUTA;

        int Cont = 0;

        public DataTable TABLAGLOBAL = new DataTable();

        public DataRow Filanueva = null;

        public bool control = false;

        public bool Reciclaconfirmar = false;

        
        

        private void Btnabrirexistente_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("csv, txt|*.csv;*.txt");

            if (openFileDialog1.ShowDialog() !=DialogResult.OK) 
            {
                MessageBox.Show("Ocurrió un problema al intentar abrir el archivo");
            }

            dataGridView1.Visible = true;

            dataGridView1.AutoSize = true;

            Btnmodificar.Visible=true;
            
          

            RUTA = openFileDialog1.FileName;


            
            
            using (var lector = new StreamReader(RUTA)) 
            {
                DataTable tablavirtual = new DataTable();
                string Columnas = lector.ReadLine();

                foreach (var Nombrescolumnas in Columnas.Split(',',';'))
                {
                    tablavirtual.Columns.Add(Nombrescolumnas);

                }

                while (!lector.EndOfStream)
                {
                    string Datos = lector.ReadLine();

                    var datoseparados = Datos.Split(',',';');


                    tablavirtual.Rows.Add(datoseparados);

                }

                TABLAGLOBAL = tablavirtual;

                dataGridView1.DataSource = TABLAGLOBAL;

              
                /*NOTA1 REVISAR DESDE ACA*/

                // Autoajustar el ancho total del control al ancho total de las columnas
                int anchoTotal = dataGridView1.RowHeadersWidth;

                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    anchoTotal += col.Width;
                }

                dataGridView1.Width = anchoTotal;

                // Autoajustar el alto total del control al alto total de las filas
                int altoTotal = dataGridView1.ColumnHeadersHeight;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    altoTotal += row.Height;
                }

                dataGridView1.Height = altoTotal;

                /*DE NOTA1 HASTA ACÁ*/

            }






        }

        private void Btnmodificar_Click(object sender, EventArgs e)
        {
            DialogResult RESPUESTA = MessageBox.Show("CONFIRMAR MODIFICACIÓN", "DESEA REALIZAR UNA MODIFICACIÓN?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (RESPUESTA == DialogResult.Yes)
            {
                
                panel1.Visible = true;

            }

            else 
            {
                return;
            }

        }

        private void Btnagregaralfinal_Click(object sender, EventArgs e)
        {
                Btnagregaralprincipio.Visible = false;
                Btneliminarseleccionado.Visible = false;
                Btneliminarultimo.Visible = false;
                Btnagregarcolumna.Visible = false;

          


                if (dataGridView1.DataSource is DataTable)
                {
                    Cont = 0;

                    control = true;

                    Filanueva = TABLAGLOBAL.NewRow();

                    textBox1.Visible = true;

                    int cantidaddecolumnas = TABLAGLOBAL.Columns.Count;


                    string Nombredecolumna = TABLAGLOBAL.Columns[Cont].ToString();

                    MessageBox.Show("PORFAVOR ESCRIBA EL " + Nombredecolumna);

                    textBox1.Focus();

                    textBox1.Location = new Point(250, 60);

                    Btnconfirmar.Location = new Point(250, 12);


                    if (textBox1.Text != null)
                    {
                        Btnconfirmar.Visible = true;
                        Reciclaconfirmar = false;

                    }
                   


                }
                else
                {
                    MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                    return;
                }

           





        }

        private void Btnconfirmar_Click(object sender, EventArgs e)
        {
            if (Reciclaconfirmar == false)
            {           

            int contadorcolumnas = TABLAGLOBAL.Columns.Count;
                
            if (textBox1.Text==null || textBox1.Text=="") 
                {
                    MessageBox.Show("PORFAVOR PARA CONFIRMAR COMPLETE EL " + TABLAGLOBAL.Columns[Cont].ToString());
                    textBox1.BackColor = Color.Red;
                    return;
            
                }

                else 
                {

                    Filanueva[Cont] = textBox1.Text;
                    textBox1.Clear();
                    Cont++;

                }

                if (Cont < contadorcolumnas)
                {


                    string Nombredecolumna = TABLAGLOBAL.Columns[Cont].ToString();

                    MessageBox.Show("PORFAVOR ESCRIBA EL " + Nombredecolumna);

                    textBox1.Focus();

                }

                else
                {
                    if (control == true) 
                    {
                        TABLAGLOBAL.Rows.Add(Filanueva);
                        MOSTRARBOTONES();


                    }
                
                    else 
                    {
                        TABLAGLOBAL.Rows.InsertAt(Filanueva,0);
                        MOSTRARBOTONES();
                    }

                    Filanueva = null;


                    MessageBox.Show("SE HA AGREGADO LA FILA CORRECTAMENTE");
                    MOSTRARBOTONES();


                    DialogResult respuesta = MessageBox.Show("DESEA sSEGUIR EDITANDO?","PREGUNTA", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes) 
                    {
                        MOSTRARBOTONES();
                        return;
                    }

                    else
                    {
                        Btnagregaralfinal.Visible = false;
                        Btnagregaralprincipio.Visible = false;
                        Btneliminarseleccionado.Visible = false;
                        Btneliminarultimo.Visible = false;
                        Btnagregarcolumna.Visible = false;
                        panel1.Visible = false;

                    }



                    textBox1.Visible = false;
                    Btnconfirmar.Visible=false;
                
            
                }

            }

            if (Reciclaconfirmar == true)
            {
                string nuevoNombre = textBox1.Text;

                if (string.IsNullOrEmpty(nuevoNombre) || TABLAGLOBAL.Columns.Contains(nuevoNombre))
                {
                    MessageBox.Show("NOMBRE DE COLUMNA VACIÓ, O YA UTILIZADO. ELIJA OTRO NOMBRE");
                    return;

                }


                else
                {

                    TABLAGLOBAL.Columns.Add(nuevoNombre);
                    MOSTRARBOTONES();


                    textBox1.Clear();
                }


            }


        }

        private void Btnagregaralprincipio_Click(object sender, EventArgs e)
        {
            Btnagregaralfinal.Visible = false;
            Btneliminarseleccionado.Visible = false;
            Btneliminarultimo.Visible = false;
            Btnagregarcolumna.Visible = false;


            if (dataGridView1.DataSource is DataTable)
            {

                Cont = 0;

                control = false;

                Filanueva = TABLAGLOBAL.NewRow();

                textBox1.Visible = true;

                int cantidaddecolumnas = TABLAGLOBAL.Columns.Count;


                string Nombredecolumna = TABLAGLOBAL.Columns[Cont].ToString();

                MessageBox.Show("PORFAVOR ESCRIBA EL " + Nombredecolumna);

                textBox1.Focus();

                textBox1.Location = new Point(250, 60);

                Btnconfirmar.Location = new Point(250, 12);



                if (textBox1.Text != null)
                {
                    Btnconfirmar.Visible = true;
                    Reciclaconfirmar = false;
                }

            }

            else
            {
                MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                return;
            }

           

            
       
        
        }

   

      

        private void Btneliminarseleccionado_Click(object sender, EventArgs e)
        {
            Btnagregaralprincipio.Visible = false;
            Btnagregaralfinal.Visible = false;
            Btneliminarultimo.Visible = false;
            Btnagregarcolumna.Visible = false;


            if (dataGridView1.DataSource is DataTable) 
            {

                while (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("PORFAVOR PARA SELECCIONAR UNA FILA HAGA CLICK SOBRE CUALQUIER CELDA");

                    return ;
                }
                

                int indicedelseleccionado = dataGridView1.CurrentRow.Index;

                int cantidaddefilas = TABLAGLOBAL.Rows.Count;

                /* -------MARCADOR---------- */



                DataRow FILAELIMINADA = TABLAGLOBAL.Rows[indicedelseleccionado];

                string DATOSDEFILA = string.Join(" ", FILAELIMINADA.ItemArray);


                DialogResult respuesta = MessageBox.Show("ESTA A PUNTO DE ELIMINAR EL ELEMENTO: \n" + DATOSDEFILA, "CONFIRMAR LA ELIMINACIÓN", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {

                    if (indicedelseleccionado > cantidaddefilas)
                    {
                        MessageBox.Show(" NO FUE POSIBLE REALIZAR LA OPERACIÓN SELECION FUERA DE RANGO");
                        return;

                    }

                    else
                    {
                        TABLAGLOBAL.Rows.RemoveAt(indicedelseleccionado);

                        MessageBox.Show("SE HA ELIMINADO EL REGISTRO NÚMERO: " + (indicedelseleccionado+1));

                        MOSTRARBOTONES();
                    }

                    

                }

                else
                {
                    MessageBox.Show("OPERACIÓN CANCELADA");
                    MOSTRARBOTONES();

                }


               
            }

            else
            {
                MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                MOSTRARBOTONES();
                return;
            }





        }

        private void Btneliminarultimo_Click(object sender, EventArgs e)
        {
            Btnagregaralprincipio.Visible = false;
            Btneliminarseleccionado.Visible = false;
            Btnagregaralfinal.Visible = false;
            Btnagregarcolumna.Visible = false;


            if (dataGridView1.DataSource is DataTable)
            {

                int cantidaddefilas = TABLAGLOBAL.Rows.Count;

                DataRow FILAELIMINADA = TABLAGLOBAL.Rows[TABLAGLOBAL.Rows.Count - 1];

                string DATOSDEFILA = string.Join(" ",FILAELIMINADA.ItemArray);


                DialogResult respuesta = MessageBox.Show("ESTA A PUNTO DE ELIMINAR EL ELEMENTO: \n" + DATOSDEFILA,"CONFIRMAR LA ELIMINACIÓN",MessageBoxButtons.OKCancel);

               if (respuesta == DialogResult.OK) 
               { 

                TABLAGLOBAL.Rows.RemoveAt(cantidaddefilas-1);
                MessageBox.Show("SE HA ELIMINADO EL REGISTRO EXITOSAMENTE");

                MOSTRARBOTONES();

               }

               else 
               {
                MessageBox.Show("OPERACIÓN CANCELADA");
                MOSTRARBOTONES();

               }

            }

            else
            {
                MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                MOSTRARBOTONES();
                return;
            }
        }

        private void Btnagregarcolumna_Click(object sender, EventArgs e)
        {
            Btnagregaralprincipio.Visible = false;
            Btneliminarseleccionado.Visible = false;
            Btnagregaralfinal.Visible = false;
            Btneliminarultimo.Visible = false;


            if (dataGridView1.DataSource is DataTable)
            {

                


                DialogResult respuesta = MessageBox.Show("A CONTINUACIÓN DEBERÁ INGRESAR EL NOMBRE DE LA COLUMNA A AGREGAR","SOLICITUD NOMBRE COLUMNA", MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    textBox1.Visible = true;

                    textBox1.BackColor = Color.Green;

                    Point Retorno = textBox1.Location;

                    textBox1.Location = new Point(110, 300);

                    int totalcolumnas = TABLAGLOBAL.Columns.Count;

                    Reciclaconfirmar = true;

                    Btnconfirmar.Visible = true;

                    Btnconfirmar.Location = new Point(200, 290);

                    if (TABLAGLOBAL.Columns.Count == 0)
                    {
                        MessageBox.Show("NO HAY NINGUNA COLUMNA");
                        return;
                    }

                                    

                    

                }

                else
                {
                    MessageBox.Show("OPERACIÓN CANCELADA");
                    
                    return;

                }

               

            }

            else
            {
                MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                return;
            }





        }



        public void MOSTRARBOTONES() 
        {
            Btnagregaralprincipio.Visible = true;
            Btneliminarseleccionado.Visible = true;
            Btneliminarultimo.Visible = true;
            Btnagregarcolumna.Visible = true;
            Btnagregaralfinal.Visible = true;

        }

        private void Btneliminarcolumna_Click(object sender, EventArgs e)
        {
            Btnagregaralprincipio.Visible = false;
            Btnagregaralfinal.Visible=false;
            Btneliminarseleccionado.Visible = false;
            Btneliminarultimo.Visible = false;
            Btnagregarcolumna.Visible = false;

            if (dataGridView1.DataSource is DataTable)
            {

                int cantcolum = (TABLAGLOBAL.Columns.Count-1);

                DialogResult respuesta3 = MessageBox.Show("USTED ESTA A PUNTO DE ELIMINAR LA COLUMNA: "+ TABLAGLOBAL.Columns[cantcolum].ToString(),"CONFIRMAR",MessageBoxButtons.OKCancel);

                if (respuesta3 == DialogResult.OK) 
                { 
                    TABLAGLOBAL.Columns.RemoveAt(cantcolum);
                    Btnagregaralprincipio.Visible = true;
                    Btnagregaralfinal.Visible = true;
                    Btneliminarseleccionado.Visible = true;
                    Btneliminarultimo.Visible = true;
                    Btnagregarcolumna.Visible = true;


                }

                else 
                {
                    MessageBox.Show("OPERACIÓN CANCELADA");
                    
                }

            }

            else
            {
                MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                return;

            }


        }

        private void Btnagregendeterminado_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable)
            {

                while (dataGridView1.CurrentRow.Index!=0)
                {
                    MessageBox.Show("PORFAVOR SELECCIONE DONDE VA A AGREGAR LA FILA");
                    return;

                }



                int ELEGIDO = dataGridView1.CurrentRow.Index;

            }








            else
            {
                MessageBox.Show("NO HAY NINGUN ARCHIVO CARGADO");
                return;

            }



        }

        private void Btnagregariniciolista_Click(object sender, EventArgs e)
        {
            
        }

        private void Btncreararchivo_Click(object sender, EventArgs e)
        {
            DialogResult RESPUESTA = MessageBox.Show("DESEA CREAR UN NUEVO ARCHIVO","CONFIRMACION NUEVO ARCHIVO",MessageBoxButtons.OKCancel);

           
            if (RESPUESTA == DialogResult.OK)
            {
                MessageBox.Show("INGRESE LA CANTIDAD DE COLUMNAS");

                numericUpDown1.Visible = true;

               


            }

            else 
            {
                return;
            }


        }

        private void Btnconfirmarcrear_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <0 || numericUpDown1.Value <10) 
            {
                MessageBox.Show("PORFAVOR INGRESE ENTRE 1 Y 10 COLUMNAS");
            
            }

            else 
            { 
            
                int CANTIDADDEDOLUMNAS = Convert.ToByte(numericUpDown1.Value);

                Lista ListaNueva = new Lista(CANTIDADDEDOLUMNAS);


            
            }

            


        }





        /* NOTA 2 VERIFICACION ES TABLA

          if (dataGridView1.DataSource is DataTable)
            {


            }

            else
            {


            }

        */ /*CIERRE NOTA 2*/



    } /*CIERRA EL FORM*/
}
