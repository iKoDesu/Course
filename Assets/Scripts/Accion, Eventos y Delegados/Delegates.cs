using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cours.AccionesEventosDelegados
{
    public class Delegates : MonoBehaviour
    {
        #region Void
        //  Como se declaran?
        //  Void
        //  De tipo void ya que no devuelve ningun valor.
        //  Luego de crear el delegado se debe crear como variable.
        public delegate void MyDelegate();
        public MyDelegate myDelegateVar;

        #endregion

        #region Return
        //  Return
        //  Este devuelve un valor
        public delegate int MyDelegateInt();
        public MyDelegateInt myDelegateIntVar;

        #endregion

        #region Params
        //  Params
        //  Sirve para pasar parametros
        public delegate void MyDelegateOneParam(string myString);
        public MyDelegateOneParam myDelegateOneParamVar;
        #endregion

        #region Multicast
        //  Multicast
        //  Forma de agregar mas de una función
        //  Es similar a la primera.
        public delegate void MyDelegateMulticast();
        public MyDelegateMulticast myDelegateMulticastVar;
        #endregion

        #region Callback
        //  Callback
        //  Devolución de una llamada
        public delegate void MyDelegateCallback(bool success);
        public MyDelegateCallback myDelegateCallbackVar;
        #endregion

        private void Start()
        {
            #region Void example
            //  Para llamar la funcion deseada.
            myDelegateVar = PrintMassage;
            //  Para ejecutarla...
            myDelegateVar();
            //  Otro metodo:
            myDelegateVar.Invoke();

            #endregion

            #region Return Example
            //  Return
            myDelegateIntVar = GetWeaponId;
            //  Dos metodos para llamar esta funcion
            int myWeapon;
            myWeapon = myDelegateIntVar();
            myWeapon = myDelegateIntVar.Invoke();
            #endregion

            //  Params
            //  Este delegado almacena esta funcion
            myDelegateOneParamVar = PrintMassageWithValue;
            //  Luego dentro de se pasa el parametro a utilizar.
            //myDelegateOneParamVar("World");
            //myDelegateOneParamVar.Invoke("World");

            //  Multicast
            //  Con += Se le suman los metodos al delegado.
            //  Metodo para suscribir metodos al delegado.
            myDelegateMulticastVar += PrintMassage;
            myDelegateMulticastVar += ChangeWeapon;
            myDelegateMulticastVar += Heal;
            //  Los metodos se ejecutan todos a la vez cuando se ejecuta.
            myDelegateMulticastVar();
            myDelegateMulticastVar.Invoke();

            //  Y para desuscribir algun metodo al multicast es con -=
            myDelegateMulticastVar -= Heal;

            //  Callback
            //  Primero se le asigna un callback a la variable.
            //  Luego habra un metodo que puede recibir como variable el callback y así
            //  poder ejecutar dentro del metodo al callback y ejecutarlo.
            myDelegateCallbackVar = RequestCompleted;
            RequestConnection(myDelegateCallbackVar);
        }

        private void PrintMassage()
        {
            Debug.Log("Hello World");
        }

        private void PrintMassageWithValue(string message)
        {
            Debug.Log($"Hello {message}");
        }

        private int GetWeaponId()
        {
            return 5;
        }

        private void ChangeWeapon()
        {
            Debug.Log("Change Weapon!");
        }

        private void Heal()
        {
            Debug.Log("Heal!");
        }

        //  Callback se utiliza con temas relacionado el network o base de datos.
        bool connectionReady = true;

        private void RequestConnection(MyDelegateCallback callback)
        {
            if(connectionReady)
            {
                callback(true);
                callback.Invoke(true);
            }
            else
            {
                callback(false);
                callback.Invoke(false);
            }
        }

        private void RequestCompleted(bool success)
        {
            Debug.Log($"Connection ready: {success}");
        }
    }
}
