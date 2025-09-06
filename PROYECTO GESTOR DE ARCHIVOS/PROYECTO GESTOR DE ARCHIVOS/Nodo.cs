using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_GESTOR_DE_ARCHIVOS
{
    public class Nodo
    {
        public object[] Datos { get; set; }
                
        public Nodo anterior { get; set; }

        public Nodo siguiente { get; set; }

        public Nodo (int cantidaddecolumnas) 
        { 

            Datos = new object[cantidaddecolumnas]; // mi idea es que reciba de la clase lista la cantidad de columnas, si ponia aca la creacion de columnas cada nodo iba a tener una cantidad distintas de columnas... es interesante hacerlo, pero no practico para lo que necesito ahora...

            anterior = null;

            siguiente = null;
        
        
        
        }



    }



}
