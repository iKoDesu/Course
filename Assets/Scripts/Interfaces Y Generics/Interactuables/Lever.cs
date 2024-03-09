using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.InterfacesYGenerics
{
    public class Lever : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interaction: Lever");
        }
    }
}
