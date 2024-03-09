using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.Atributos
{
    public class TextAreaMultiline : MonoBehaviour
    {
        [TextArea(1, 5)]
        public string description;

        [Multiline(6)]
        public string note;
    }
}
