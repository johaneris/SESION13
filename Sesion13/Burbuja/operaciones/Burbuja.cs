using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja.operaciones
{
    internal class Burbujita
    {
        //metodo burbuja, que ordena arreglos
        //el parametro es un arreglo
        //recorrer cada parte del arreglo, el segundo se encarga de la comparación
        //la tempral le pasa el valor a i
        public void OrdenarBurbuja(int[] arreglo)
        {

            for(int i = 0; i < arreglo.Length; i++)
            {
                for(int j = i + 1;  j < arreglo.Length; j++)
                {
                    if (arreglo[j] < arreglo[i])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[i];
                        arreglo[i] = temp;
                    }
                }
            }

        }
     



    }
}
