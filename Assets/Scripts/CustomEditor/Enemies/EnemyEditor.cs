using TMPro;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;

namespace Cours.Enemy
{
    [UnityEditor.CustomEditor(typeof(Enemy))]
    public class EnemyEditor : Editor
    {
        private Enemy currentTarget;

        private GUIStyle styleText;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            styleText = new GUIStyle(GUI.skin.textField) { alignment = TextAnchor.MiddleLeft };

            currentTarget = (Enemy)target;

            if (IsTargetReady())
            {
                if (!EditorApplication.isPlaying)
                {
                    GUILayout.Box($"Enemy: {currentTarget.data.enemyName}\n" +
                        $"Element: {currentTarget.data.element}\n" +
                        $"Debility: {currentTarget.data.debility}\n" +
                        $"Heal: {currentTarget.data.heal}\n" +
                        $"Damage: {currentTarget.data.damage}\n" +
                        $"Model: {currentTarget.data.model.name}", styleText);
                }

                EditorGUI.BeginDisabledGroup(EditorApplication.isPlaying);

                string buttonText = EditorApplication.isPlaying ? "Constume (Only in Editor)" : "Consume";

                GUILayout.Space(10);

                if (GUILayout.Button(buttonText, GUILayout.Height(20)))
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

        private string GetErrorMessage()
        {
            if (!currentTarget.data) return "Data Empty";
            if (!currentTarget.nameEnemyTxt) return "Name reference Empty";
            if (!currentTarget.typeElementTxt) return "Name reference Empty";
            if (!currentTarget.typeDebilityTxt) return "Debility reference Empty";
            if (!currentTarget.healTxt) return "Heal reference Empty";
            if (!currentTarget.damageTxt) return "Damage reference Empty";

            return "Unknown";
        }

        private bool IsTargetReady()
        {
            return currentTarget.data &&
                currentTarget.nameEnemyTxt &&
                currentTarget.typeElementTxt &&
                currentTarget.typeDebilityTxt &&
                currentTarget.healTxt &&
                currentTarget.damageTxt;
        }
    }
}