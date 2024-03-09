using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cours.ShootGame
{
    public class WeaponGenerator : EditorWindow
    {
        private string weaponName;
        private float ammo;
        public int price;
        public typeWeapon type;
        public Sprite sprite;

        public WeaponSO _data;

        private GUIStyle _styleButtons;

        private string _pathAndName = "Assets/Scripts/CustomEditor/WeaponData/New Weapon.asset";

        [MenuItem("Tools/Weapon Generator")]
        static void Init()
        {
            WeaponGenerator window = (WeaponGenerator)GetWindow(typeof(WeaponGenerator));
            Texture2D iconTitle = EditorGUIUtility.Load("_Popup@2x\t") as Texture2D;
            GUIContent titleContent = new GUIContent("Weapon Generator", iconTitle);

            window.titleContent = titleContent;
            window.minSize = new Vector2(350, 350);

            window.Show();
        }

        private void OnGUI()
        {
            _styleButtons = new GUIStyle(GUI.skin.button) { alignment = TextAnchor.MiddleCenter, fontSize = 15, fixedHeight = 40 };
            GUILayout.Label("Data", EditorStyles.boldLabel);

            EditorGUILayout.Space(10);

            weaponName = EditorGUILayout.TextField("Weapon",weaponName);

            type = (typeWeapon)EditorGUILayout.EnumPopup("Type", type);

            GUILayout.Label("Price");
            price = (int)EditorGUILayout.Slider(price, 0, 999);

            GUILayout.Label("Ammo");
            ammo = (int)EditorGUILayout.Slider(ammo, 0, 50);

            sprite = (Sprite)EditorGUILayout.ObjectField("Sprite", sprite, typeof(Sprite), true);

            EditorGUILayout.Space(20);

            DrawHorizontalLine();
            DrawSize();

            EditorGUILayout.Space(20);

            EditorGUILayout.BeginHorizontal();

            if(GUILayout.Button("Create", _styleButtons))
            {
                CreateWeapon();

                string _weaponPathAndName = AssetDatabase.GenerateUniqueAssetPath(_pathAndName);
                AssetDatabase.CreateAsset(_data, _weaponPathAndName);
                AssetDatabase.RenameAsset(_weaponPathAndName, weaponName);
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
                EditorUtility.FocusProjectWindow();
                Selection.activeObject = _data;
            }
            if(GUILayout.Button("Clear", _styleButtons))
            {
                ClearItem();
            }
            EditorGUILayout.EndHorizontal();
        }

        private void CreateWeapon()
        {
            _data = CreateInstance<WeaponSO>();

            _data.weaponName = weaponName;
            _data.price = price;
            _data.ammo = ammo;
            _data.sprite = sprite;
            _data.type = type;
        }

        private void ClearItem()
        {
            weaponName = null;
            price = 0;
            sprite = null;
            type = typeWeapon.None;
            ammo = 0;
        }

        private void DrawHorizontalLine()
        {
            Rect rect = EditorGUILayout.GetControlRect();
            rect.height = 1;
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        private void DrawSize()
        {
            EditorGUILayout.LabelField("X: " + base.position.width.ToString());
            EditorGUILayout.LabelField("Y: "+base.position.height.ToString());
        }
    }
}
