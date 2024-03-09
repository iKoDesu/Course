using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.ToolsEditorWindow;

namespace Cours.Citizen
{
    public class NPCGenerator : ToolsEditorWindows
    {
        private string citizenName;
        private int heal;
        private TypeCitizen typeCitizen;
        public Sprite sprite;

        public NPCSO _data;

        private GUIStyle _styleButtons;

        private string _pathAndName = "Assets/Scripts/CustomEditor/NPC/Citizen/New Citizen.asset";

        [MenuItem("Citizen/Citizen Generator")]
        static void Init()
        {
            NPCGenerator window = (NPCGenerator)GetWindow(typeof(NPCGenerator));
            Texture2D iconTitle = EditorGUIUtility.Load("BodySilhouette") as Texture2D;

            GUIContent titleContent = new GUIContent("NPC Generator", iconTitle);

            window.titleContent = titleContent;
            window.minSize = new Vector2(300, 300);

            window.Show();
        }

        private void OnGUI()
        {
            _styleButtons = new GUIStyle(GUI.skin.button)
            { alignment = TextAnchor.MiddleCenter, fontSize = 15, fixedHeight = 40};
            GUILayout.Label("Data", EditorStyles.boldLabel);

            EditorGUILayout.Space(10);

            citizenName = EditorGUILayout.TextField("Citizen name", citizenName);

            typeCitizen = (TypeCitizen)EditorGUILayout.EnumPopup("Type of Citizen", typeCitizen);

            heal = (int)EditorGUILayout.Slider(heal, 0, 100);

            sprite = (Sprite)EditorGUILayout.ObjectField("Sprite", sprite, typeof(Sprite), true);

            EditorGUILayout.Space(20);

            DrawHorizontalLine();

            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();

            if(GUILayout.Button("Create", _styleButtons))
            {
                CreateCitizen();

                string _citizenPathAndName = AssetDatabase.GenerateUniqueAssetPath(_pathAndName);

                AssetDatabase.CreateAsset(_data, _citizenPathAndName);
                AssetDatabase.RenameAsset(_citizenPathAndName, citizenName);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = _data;
            }

            if(GUILayout.Button("Clear", _styleButtons))
            {
                ClearCitizen();
            }
            EditorGUILayout.EndHorizontal();

            DrawSize();
        }

        private void CreateCitizen()
        {
            _data = CreateInstance<NPCSO>();

            _data.npcName = citizenName;
            _data.heal = heal;
            _data.typeCitizen = typeCitizen;
            _data.sprite = sprite;
        }

        private void ClearCitizen()
        {
            citizenName = null;
            heal = 0;
            typeCitizen = TypeCitizen.None;
            sprite = null;
        }
    }
}
