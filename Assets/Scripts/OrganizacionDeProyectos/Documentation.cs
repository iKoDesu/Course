using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.OrganizacionProyecto
{
    public class Documentation : MonoBehaviour
    {
        /// <summary>
        /// Summary: Numero importante
        /// </summary>
        public int numbers;
        private void Start()
        {
            
            int myValue;
            myValue = GetId("Mariano");
        }

        /// <summary>
        /// Sumary: Descripcion corta.
        /// </summary>
        /// <remarks>
        /// Remarks: Descripci�n mas detallada de la funci�n.
        /// </remarks>
        /// <param name="characterName"> Param: Descripci�n de la variable</param>
        /// <returns>
        /// Return: Descripci�n del tipo de valor que devuelve.
        /// </returns>
        private int GetId(string characterName)
        {
            return 1;
        }
    }
}
