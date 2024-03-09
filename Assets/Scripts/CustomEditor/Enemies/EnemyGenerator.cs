using UnityEditor;
using UnityEngine;
using UnityEngine.ToolsEditorWindow;

namespace Cours.Enemy
{
    public class EnemyGenerator : ToolsEditorWindows
    {
        private string enemyName = null;
        private EnumsEnemies.TypeEnemy typeEnemy;
        private EnumsEnemies.TypeElement element;
        private EnumsEnemies.TypeElement debility;

        private float heal;
        private int damage;

        private GameObject model;
        private GameObject compareModel;

        private Editor gameObjectEditor;

        private EnemySO _data;

        private GUIStyle _styleButtons;

        private string _pathAndName = "Assets/Scriptable Object/Enemies/New enemy.asset";

        [MenuItem("Enemy/Enemy Generator")]
        static void Init()
        {
            EnemyGenerator window = (EnemyGenerator)GetWindow(typeof(EnemyGenerator));
            Texture2D iconTitle = EditorGUIUtility.Load("AvatarSelector") as Texture2D;

            GUIContent titleContent = new GUIContent("Enemy Generator", iconTitle);

            window.titleContent = titleContent;
            window.minSize = new Vector2(300, 650);

            window.Show();
        }

        private void OnGUI()
        {
            _styleButtons = new GUIStyle(GUI.skin.button)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 15,
                fixedHeight = 40,
                fontStyle = FontStyle.Bold
            };

            #region Values to complete
            GUILayout.Label("Data", EditorStyles.boldLabel);

            GUILayout.Space(10);

            enemyName = EditorGUILayout.TextField("Enemy Name", enemyName);

            EditorGUILayout.Space(10);
            typeEnemy = (EnumsEnemies.TypeEnemy)EditorGUILayout.EnumPopup("Type of enemy", typeEnemy);
            EditorGUILayout.Space(10);
            element = (EnumsEnemies.TypeElement)EditorGUILayout.EnumPopup("Type of element", element);
            EditorGUILayout.Space(10);
            debility = (EnumsEnemies.TypeElement)EditorGUILayout.EnumPopup("Debility", debility);
            EditorGUILayout.Space(10);

            GUILayout.Label("Heal");
            heal = (float)EditorGUILayout.Slider(heal, 0, 500);
            EditorGUILayout.Space(10);

            GUILayout.Label("Damage");
            damage = (int)EditorGUILayout.Slider(damage, 0, 500);
            EditorGUILayout.Space(10);

            #region Model
            compareModel = (GameObject)EditorGUILayout.ObjectField("Enemy Model", compareModel, typeof(GameObject), true);
            if(compareModel != model)
            {
                model = compareModel;
                gameObjectEditor = null;
            }

            GUILayout.Space(5);
            

            PreviewModel();

            EditorGUILayout.Space(10);

            #endregion

            DrawHorizontalLine();

            #endregion

            #region Buttons
            EditorGUILayout.BeginHorizontal();

            if (CanCreate())
            {
                if (GUILayout.Button("Create", _styleButtons))
                {
                    CreateEnemy();

                    string _enemyPathAndName = AssetDatabase.GenerateUniqueAssetPath(_pathAndName);

                    AssetDatabase.CreateAsset(_data, _enemyPathAndName);
                    AssetDatabase.RenameAsset(_enemyPathAndName, enemyName);
                    AssetDatabase.SaveAssets();
                    AssetDatabase.Refresh();
                    EditorUtility.FocusProjectWindow();
                    Selection.activeObject = _data;
                }
            }
            else
            {
                EditorGUILayout.HelpBox($"Error: {GetErrorMessage()}", MessageType.Warning);
            }

            if(GUILayout.Button("Clear", _styleButtons))
            {
                ClearEnemy();
            }

            EditorGUILayout.EndHorizontal();
            #endregion
        }

        private void CreateEnemy()
        {
            _data = CreateInstance<EnemySO>();

            _data.enemyName = enemyName;
            _data.type = typeEnemy;
            _data.element = element;
            _data.debility = debility;
            _data.heal = heal;
            _data.damage = damage;

            _data.model = model;
        }

        private void ClearEnemy()
        {
            enemyName = null;
            typeEnemy = EnumsEnemies.TypeEnemy.None;
            element = EnumsEnemies.TypeElement.None;
            debility = EnumsEnemies.TypeElement.None;
            heal = 0;
            damage = 0;
            PreviewModel();
            gameObjectEditor = null;
            model = null;
        }

        private bool CanCreate()
        {
            return enemyName != null &&
                heal != 0 &&
                model != null;
        }

        private string GetErrorMessage()
        {
            if (enemyName == null || enemyName == "") return "Name Empty";
            if (heal == 0) return "Heal can't be 0 ";
            if (model == null) return "Model Empty";

            return "Unknown";
        }

        private void PreviewModel()
        {
            GUIStyle bgColor = new GUIStyle();
            bgColor.normal.background = EditorGUIUtility.whiteTexture;

            if (model != null)
            {
                if (gameObjectEditor == null)
                    gameObjectEditor = Editor.CreateEditor(model);

                gameObjectEditor.OnInteractivePreviewGUI(GUILayoutUtility.GetRect(256, 256), bgColor);
            }
        }
    }
}