using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.Colecciones
{
    public class ClassStack : MonoBehaviour
    {
        [Header("Content")]
        public GameObject[] myContent;

        [Header("Stack")]
        public Stack<GameObject> cardsStacks;

        private void Start()
        {
            //  Init
            cardsStacks = new Stack<GameObject>();

            //  Add
            //  Para añadir elementos se utiliza un Push
            for (int i = 0; i < myContent.Length; i++)
            {
                cardsStacks.Push(myContent[i]);
            }

            //  Dos formas de obtener valores
            //  Return first and Remove
            //  Toma el primer objeto y lo elimina de la lista.
            GameObject myGameObjectPop = cardsStacks.Pop();

            //  Return first
            //  Solo lee el primer objeto
            GameObject myGameObjectPeek = cardsStacks.Peek();

            //  Contains
            //  Pregunta si tiene un cierto objeto.
            bool contains = cardsStacks.Contains(myGameObjectPeek);

            //  Amount
            int amount = cardsStacks.Count;

            //  Remove
            cardsStacks.Clear();

        }

    }
}
