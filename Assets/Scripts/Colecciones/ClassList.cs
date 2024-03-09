using UnityEngine;
using System.Collections.Generic;

namespace Cours.Colecciones
{
    public class ClassList : MonoBehaviour
    {
        [Header("Content")]
        public int[] myContent;
        [Header("Lista")]
        public List<int> weaponsList;

        private void Start()
        {
            //  Inicializar - Init
            //  Se debe inicializar para poder utilizar
            weaponsList = new List<int>();

            //  Add - Agregar elementos a la lista
            //  Para agregar uno por uno a la lista.
            for(int i = 0; i < myContent.Length; i++)
            {
                weaponsList.Add(myContent[i]);
            }

            //  Para agregar todos los elementos de golpe a la lista.
            weaponsList.AddRange(myContent);

            //  Remove
            //  Remueve un determinado elemento y sacar el valor 2 de la lista.
            weaponsList.Remove(myContent[2]);

            //  Read
            //  Para leer

            int tempValue = weaponsList[2];

            //  Amount
            //  Para saber su cantidad
            int amount = weaponsList.Count;

            //  Clear
            //  Para eliminar toda la lista
            weaponsList.Clear();




        }
    }
}
