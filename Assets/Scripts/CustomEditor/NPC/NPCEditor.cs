using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

namespace Cours.Citizen
{
    [UnityEditor.CustomEditor(typeof(NPC))]
    public class NPCEditor : Editor
    {
        private NPC currentTarget;

        private GUIStyle textStyle;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            currentTarget = (NPC)target;

            if (IsTargetReady())
            {
                textStyle = new GUIStyle(GUI.skin.textArea) { alignment = TextAnchor.MiddleCenter };

                if(!EditorApplication.isPlaying)
                    GUILayout.Box($"NPC: {currentTarget.data.npcName} \n"
                                  + $"Type: {currentTarget.data.typeCitizen} \n"
                                  + $"Heal: {currentTarget.data.heal}", textStyle);
                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

                
                string buttonText = EditorApplication.isPlaying ? "Consume (Only in editor)" : "Consume";


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
                currentTarget.npcImage &&
                currentTarget.npcNameTxt &&
                currentTarget.npctypeTxt &&
                currentTarget.npcHealTxt;
        }

        private string GetErrorMessage()
        {
            if (!currentTarget.data) return "Data Empty";
            if (!currentTarget.npcImage) return "Image reference Emtpy";
            if (!currentTarget.npcNameTxt) return "Name reference Emtpy";
            if (!currentTarget.npctypeTxt) return "Type reference Emtpy";
            if (!currentTarget.npcHealTxt) return "Heal reference Emtpy";

            return "Unknown";
        }
    }
}
