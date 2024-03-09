using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.InterfacesYGenerics
{
    public class Chest : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Chest");
        }
    }
}
