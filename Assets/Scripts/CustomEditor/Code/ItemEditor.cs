using UnityEngine;
using UnityEditor;

namespace Cours.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(Item))]
    public class ItemEditor : Editor
    {
        private Item currentTarget;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            currentTarget = (Item)target;

            //  Crea un spacio entre el boton y lo que tiene antes.
            GUILayout.Space(10);


            if (IsTargeReady())
            {
                //  Sirve para ver que información hay en el data base.
                if(!EditorApplication.isPlaying )
                    GUILayout.Box($"Data: {currentTarget.data.title} ($ {currentTarget.data.price})");

                //  Desabilita todo lo que hay debajo si se cumple una condición
                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);


                //  Analiza si el editor esta en Play o no y da un texto u otro
                string buttonText = EditorApplication.isPlaying ? "Consume (Only en Editor Mode)" : "Consume";

                GUILayout.Space(10);
                //  Le asigna ese texto y con Height se le modifica el alto al boton.
                if (GUILayout.Button(buttonText, GUILayout.Height(30)))
                {
                    currentTarget.Consume();
                }

                //  Desabilita hasta esta aqui y deja el mensaje de el botón.
                EditorGUI.EndDisabledGroup();
            }
            //  Que muestre los errores si no esta listo.
            else
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Error);
            }

        }

        private bool IsTargeReady()
        {
            //  Revisa todas las referencias
            return 
                currentTarget.data &&
                currentTarget.itemImg &&
                currentTarget.itemTitleTxt &&
                currentTarget.itemPriceTxt;
        }

        private string GetErrorMessage()
        {
            //  Revisa todas las referencias.
            if (!currentTarget.data) return "Data Empty";
            if (!currentTarget.itemImg) return "Image Reference Empty";
            if (!currentTarget.itemTitleTxt) return "Title reference Empty";
            if (!currentTarget.itemPriceTxt) return "Price reference Empty";

            return "Unknown";
        }
    }
}
