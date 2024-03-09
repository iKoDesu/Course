using UnityEngine;
using UnityEditor;

namespace Cours.ShootGame
{
    [UnityEditor.CustomEditor(typeof(Weapon))]
    public class WeaponEditor : Editor
    {
        private Weapon currentTarget;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            currentTarget = (Weapon)target;

            if (IsTargetReady())
            {
                if(!EditorApplication.isPlaying)
                    GUILayout.Box($"Weapon: {currentTarget.data.weaponName} ($ {currentTarget.data.price})");

                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

                string buttonText = EditorApplication.isPlaying ? "Consume (Only in Editor Mode)" : "Consume";

                GUILayout.Space(10);

                if(GUILayout.Button(buttonText, GUILayout.Height(30))) 
                {
                    currentTarget.Consume();
                }

                EditorGUI.EndDisabledGroup();
            }
            else
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Error);
            }
        }

        private bool IsTargetReady()
        {
            return
                currentTarget.data &&
                currentTarget.weaponImage &&
                currentTarget.weaponNameTxt &&
                currentTarget.ammoTxt &&
                currentTarget.typeTxt &&
                currentTarget.priceTxt;
        }

        private string GetErrorMessage()
        {
            if (!currentTarget.data) return "Data Empty";
            if (!currentTarget.weaponImage) return "Image reference Empty";
            if (!currentTarget.weaponNameTxt) return "Name reference Empty";
            if (!currentTarget.ammoTxt) return "Ammo reference Empty";
            if (!currentTarget.typeTxt) return "Type reference Empty";
            if (!currentTarget.priceTxt) return "Price reference Empty";

            return "Unknown";
        }
    }
}
