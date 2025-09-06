using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROYECTO_GESTOR_DE_ARCHIVOS
{
    public class Lista
    {
        #region PROPIEDADES


        public int CANTIDADDECOLUMNAS {  get; private set; } // uso private porque solo quiero que pueda ser usada por mi propia clase lista
    
        public Nodo INICIO { get; set; }

        public Nodo FINAL { get; set; }

        #endregion



        public Lista(int cantidaddecolumnas) 
        { 
            CANTIDADDECOLUMNAS = cantidaddecolumnas;

            INICIO = null;

            FINAL = null;
              
        }

        #region METODOS



        public void Agregaralinicio () 
        {
            Nodo nuevonodo = new Nodo(CANTIDADDECOLUMNAS);

            if (INICIO == null)
            {

                INICIO = nuevonodo;

                FINAL = INICIO;

            }


            else
            {
                INICIO.anterior = nuevonodo;

                nuevonodo.siguiente = INICIO;

                INICIO = nuevonodo;
            }


        }




        public void Agregaralfinal()
        {
            Nodo nuevonodo = new Nodo(CANTIDADDECOLUMNAS);

            if (INICIO == null)
            {

                INICIO = nuevonodo;

                FINAL = INICIO;

            }


            else
            {
                nuevonodo.anterior = FINAL;

                FINAL.siguiente = nuevonodo;

                FINAL = nuevonodo;
            }


        }


        public int Contadordenodos ()
        {


            Nodo Recorredor = INICIO;
             int CantidadDeNodos = 0;

            if ( Recorredor == null)
            {
                CantidadDeNodos = 0;
                return 0;
            }



            while (Recorredor.siguiente!=null) 
            { 
                Recorredor = Recorredor.siguiente;

                CantidadDeNodos++;
                
            }

            return CantidadDeNodos;

        }


        public void Agregarendetermiando(int elegido)
        {
            Nodo nuevonodo = new Nodo(CANTIDADDECOLUMNAS);

          
            Nodo Recorredor = INICIO;

            int indice = 0;

                       
            if (Recorredor == null) 
            {
                INICIO = nuevonodo;

                FINAL = INICIO;

                return;
            }

            if (elegido < indice) 
            {

                MessageBox.Show("INDICE FUERA DE RANGO ");

                return;
            
            }

            while (indice != elegido) 
            {
                Recorredor = Recorredor.siguiente;
                        
                indice++;
            }

            if (Recorredor == null)
            {
                MessageBox.Show("INDICE FUERA DE RANGO");
                return;

            }



            if (Recorredor.anterior == null)
            {
                nuevonodo.siguiente = Recorredor;
                Recorredor.anterior = nuevonodo;
                INICIO = nuevonodo;
            }
            else
            {
                Recorredor.anterior.siguiente = nuevonodo;
                nuevonodo.anterior = Recorredor.anterior;
                nuevonodo.siguiente = Recorredor;
                Recorredor.anterior = nuevonodo;
            }


        }




        public void eliminarultimo()
        {

            Nodo Recorredor = INICIO;

            if (INICIO == null)
            {
                MessageBox.Show("NO HAY ELEMENTOS PARA ELIMINAR");
                return;
            }

            if (INICIO.siguiente == null) // PRO LAS DUDAS POR SI HAY UN SOLO NODO
            {
                
                INICIO = null;
                FINAL = null;
                return;
            }


            while (Recorredor.siguiente!=null) 
            { 
                Recorredor = Recorredor .siguiente;
                            
            }


            Recorredor.anterior.siguiente = null;

            FINAL = Recorredor.anterior;


        }


        public void Eliminarprimero()
        {

            Nodo Recorredor = INICIO;

            if (INICIO == null)
            {
                MessageBox.Show("NO HAY ELEMENTOS PARA ELIMINAR");
                return;
            }

            if (INICIO.siguiente == null) // PRO LAS DUDAS POR SI HAY UN SOLO NODO
            {

                INICIO = null;
                FINAL = null;
                return;
            }


            INICIO = INICIO.siguiente;
            INICIO.anterior = null;

           

        }

        public void Eliminarseleccionado(int seleccionado)
        {
            if (INICIO == null)
            {
                MessageBox.Show("NO HAY ELEMENTOS PARA ELIMINAR");
                return;
            }

            int indice = 0;
            Nodo recorredor = INICIO;

            while (recorredor != null && indice != seleccionado)
            {
                recorredor = recorredor.siguiente;
                indice++;
            }

            if (recorredor == null)
            {
                MessageBox.Show("ÍNDICE FUERA DE RANGO");
                return;
            }

            if (recorredor.anterior == null && recorredor.siguiente == null)
            {
                INICIO = null;
                FINAL = null;
            }

            else if (recorredor.anterior == null)
            {
                INICIO = recorredor.siguiente;
                INICIO.anterior = null;
            }

            else if (recorredor.siguiente == null)
            {
                FINAL = recorredor.anterior;
                FINAL.siguiente = null;
            }

            else
            {
                recorredor.anterior.siguiente = recorredor.siguiente;
                recorredor.siguiente.anterior = recorredor.anterior;
            }

            MessageBox.Show("ELEMENTO ELIMINADO CORRECTAMENTE");
        }


        public DataTable convertiradatatable() 
        { 
         DataTable TABLA = new DataTable();
            for (int i = 0; i < CANTIDADDECOLUMNAS; i++) 
            {

                TABLA.Columns.Add("COLUMNA " + (i + 1));
            }

            Nodo actual = INICIO;

            while (actual != null)
            {
                TABLA.Rows.Add(actual.Datos);
                actual = actual.siguiente;
            }

            return TABLA;
        }


    

        #endregion


    }

}
