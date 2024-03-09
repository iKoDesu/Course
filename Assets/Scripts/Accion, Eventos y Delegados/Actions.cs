using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

namespace Cours.AccionesEventosDelegados
{
    public class Actions : MonoBehaviour
    {
        public Action myActionVar;
        public UnityAction myUnityActionVar;

        public Action<int> myActioNoneParamVar;
        public UnityAction<int> myUnityActioNoneParamVar;

        public Action<int, bool, string> myActionThreeParamVar;
        public UnityAction<int, bool, string> myUnityActionThreeParamVar;

        private void Start()
        {
            //  Action
            myActionVar = PrintMessage;
            myActionVar += PrintMessage;

            myActionVar();
            myActionVar.Invoke();


            //  UnityAction
            myUnityActionVar = PrintMessage;
            myUnityActionVar += PrintMessage;

            myUnityActionVar();
            myUnityActionVar.Invoke();

            //  Se aplican igual que los delegados y eventos.

            //  Delegados y acciones son el sistema general de este tipo de comunicaciones.
            //  Ambos tienen el mismo fin y trabajan de la misma manera.
            //  Los eventos son los mas utilizados debido a que pueden ser utilizados desde el editor.
            //  En caso de requerir algo similar es mas comun usar los delegados.

            printMessage();

        }

        Action printMessage = () => Debug.Log("Este es un delegado de acción");
        private void PrintMessage()
        {
            Debug.Log("Hello world!");
        }
    }
}
