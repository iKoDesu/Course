using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours
{
    public class CadenasDeTexto : MonoBehaviour
    {
        string myString;

        private void Start()
        {
            myString = "Jose";
            myString = "Jose" + " " + "Diaz";

            int age = 26;

            myString = "Jose's Birthday: " + age.ToString();

            myString = string.Format("{0}'s Birthday : {1}", "Jose", age);
            myString = $"Jose's Birthday: {age}";

            myString = "26_Jose_Rifle";
            string[] characterInfo = myString.Split('_');
        }
    }
}
