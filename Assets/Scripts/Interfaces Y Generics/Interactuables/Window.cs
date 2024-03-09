using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.InterfacesYGenerics
{
    public class Window : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log("Interactable Window");
        }
    }
}
