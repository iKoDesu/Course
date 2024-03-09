using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.InterfacesYGenerics
{
    public interface IInteractable
    {
        void Interact();
    }

    public class Interfaces : MonoBehaviour
    {
        public GameObject[] myInteractables;
        //public Door interactableDoor;
        //public Chest interactableChest;
        //public Lever interactableLever;

        private void Start()
        {
            ////  Door
            //interactableDoor.OpenDoor();

            ////  Chest
            //interactableChest.OpenChest();

            ////  Lever
            //interactableLever.UseLever();

            for (int i = 0; i < myInteractables.Length; i++)
            {
                IInteractable myInteractable = myInteractables[i].GetComponent<IInteractable>();
                myInteractable.Interact();
            }
        }
    }
}
