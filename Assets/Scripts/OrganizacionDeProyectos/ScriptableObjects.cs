using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Cours.OrganizacionProyecto
{
    //  Para poder utilizar un scriptableObject se debe reemplazar por el MonoBehaviour
    //  Debe contener si o si este parametro para ser utilizado.
    //  Su nombre, donde se encuentra y orden en alguna lista.
    [CreateAssetMenu(fileName = "Example", menuName = "SO/Example", order = 5)]
    public class Valida : MonoBehaviour
    {
        //  Sirve para crear templates
        public DataSO data;

        //  Sirve para craer plantillas de enemigos y configuraciones
        private void Start()
        {
            Debug.Log(data.health);
        }
    }
}
