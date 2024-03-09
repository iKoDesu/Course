using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.Colecciones
{
    public class ClassDictionary : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        //  El tipo K es requerido, este son los valores que se utilizaran.
        //  El TKey es como se identificara ese elemento en el diccionario.
        //  Los diccionarios no se pueden serializar.
        [Header("Content")]
        public Dictionary<string, GameObject> characterDictionary;

        private void Start()
        {
            //  Init
            characterDictionary = new Dictionary<string, GameObject>();

            //  Add
            for(int i = 0; i < myContent.Length; i++)
            {
                characterDictionary.Add(myContent[i].name, myContent[i]);
            }

            //  Remove
            //  Remueve un objeto mediante su nombre de un diccionario.
            characterDictionary.Remove("Orc");

            //  Contains
            //  Si contiene un elemento en el diccionaro
            //  Da como resultado un boleano.
            bool contains = characterDictionary.ContainsKey("Orc");

            //  Read
            //  Con solo colocar su nombre se puede acceder a el.
            GameObject myValue = characterDictionary["Orc"];

            //  Lo bueno es los diccionarios es que los elementos no se pueden repetir.

            //  Amount
            int ammount = characterDictionary.Count;

            //  Remove
            characterDictionary.Clear();
        }
    }
}
