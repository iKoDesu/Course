using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.OrganizacionProyecto
{
    public class Validacion : MonoBehaviour
    {
        [SerializeField] private Sprite sprite;
        [SerializeField] private SpriteRenderer spriteRenderer;
        private void OnValidate()
        {
            if(!spriteRenderer != null)
            {
                spriteRenderer = GetComponent<SpriteRenderer>();
            }

            if (!sprite)
            {
                Debug.Log("Missing Sprite");
                return;
            }

            spriteRenderer.sprite = sprite;
        }
    }
}
