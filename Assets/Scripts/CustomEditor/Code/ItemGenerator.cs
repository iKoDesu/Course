using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cours.CustomEditor
{
    //  Este hereda de EditorWindow
    public class ItemGenerator : EditorWindow
    {
        //  Item Data
        //  Se le asigna un titulo, si da error se crea un new string.
        private new string title;
        private float price;
        private Sprite sprite;
        private ItemSO _data;

        //  Para darle estilo a los botones
        private GUIStyle _styleButtons;

        //  Ubicación en donde se guardara el Scriptable Object
        private string _pathAndName = "Assets/Scripts/CustomEditor/ItemData/New Item.asset";


        //  Se le añade un atributo que designa una dirección en donde encontrarlo.
        [MenuItem("Tools/Item Generator")]
        static void Init()
        {
            //  Ahora debemos crear esa ventana
            ItemGenerator window = (ItemGenerator)GetWindow(typeof(ItemGenerator));

            //  Ahora se le asigna un icono
            //  URL: https://github.com/halak/unity-editor-icons
            Texture2D iconTitle = EditorGUIUtility.Load("d_Prefab Icon") as Texture2D;

            //  Luego se le añade toda la información
            //  Titulo e icono
            GUIContent titleContent = new GUIContent("Item Generator", iconTitle);

            //  Pasar toda esta información a window
            window.titleContent = titleContent;

            //  Tamaño minimo en un vector 2 (x, y)
            window.minSize = new Vector2(350, 350);

            //  Y para mostrar la ventana
            window.Show();
        }

        //  Para comenzar a dibujar en la ventana
        private void OnGUI()
        {
            //  Aquí se define el estilo que tendran los botones con esta configuración
            //  Se le asigna dondee estara el boton (alignment = TextAnchor.MiddleCenter)
            //  Tamaño de la letra (fontSize = 15)
            //  Largo del boton (fixedHeight = 40 )
            _styleButtons = new GUIStyle(GUI.skin.button) {alignment = TextAnchor.MiddleCenter, fontSize = 15, fixedHeight = 40 };
            //  Para asignar un nombre, con letra negrita.
            GUILayout.Label("Data", EditorStyles.boldLabel);

            EditorGUILayout.Space(10);

            //  Crea un campo donde se le puede agregar texto
            //  Como se va a llamar el apartado y en donde se guarda la información
            title = EditorGUILayout.TextField("Title", title);
            GUILayout.Label("Price");

            //  Se creara una barra con un valor minimo y maximo
            //  Quiero que la información se guarde en price, valor minimo 0 y maximo 999
            price = EditorGUILayout.Slider(price, 0, 999);

            //  ObjectField permite crear un campo para cualquier tipo de objeto.
            //  (Sprite) hace un casteo para definir que tipo de objeto sera
            //  Nombre, donde se guardara el valor, el typeof y siempr debe ser true.
            sprite = (Sprite)EditorGUILayout.ObjectField("Sprite", sprite, typeof(Sprite), true);

            EditorGUILayout.Space();
            EditorGUILayout.Space();
            EditorGUILayout.Space();

            DrawHorizontalLine();
            DrawSize();

            EditorGUILayout.Space();
            EditorGUILayout.Space();

            //  Para que toda la información que este dentro se almacene de forma horizontal
            EditorGUILayout.BeginHorizontal();
            //  Se crea boton y se le asigna el estilo
            if (GUILayout.Button("Create", _styleButtons))
            {
                CreateItem();

                //  Obtiene la ruta unica para almacendar el asset a crear.
                string _itemPathAndName = AssetDatabase.GenerateUniqueAssetPath(_pathAndName);

                //  Crea el asset en la ubicación escogida
                AssetDatabase.CreateAsset(_data, _itemPathAndName);

                //  Ese asset le cambia el nombre al que tiene en title.
                AssetDatabase.RenameAsset(_itemPathAndName, title);

                //  Guarda el asset
                AssetDatabase.SaveAssets();

                //  Hace un Refresh para evitar errores.
                AssetDatabase.Refresh();

                //  Obtiene utilidades de unity.
                //  Focus Project window hace que no importa en donde estemos, enfoque en la ventana
                EditorUtility.FocusProjectWindow();

                //  Y se seleccionara el objeto que se haya creado.
                Selection.activeObject = _data;
            }
            
            if (GUILayout.Button("Clear", _styleButtons))
            {
                ClearItem();
            }

            EditorGUILayout.EndHorizontal();
        }

        private void CreateItem()
        {
            //  Crea una instancia del ScriptableObject
            _data = CreateInstance<ItemSO>();

            //  Cuando se crea le agregaremos la información
            _data.title = title;
            _data.price = price;
            _data.sprite = sprite;
        }

        //  Volver todos los parametros a cero o nulo.
        private void ClearItem()
        {
            title = null;
            price = 0;
            sprite = null;
        }

        //  Crea una linea en horizontal
        private void DrawHorizontalLine()
        {
            //  GetControlRect Fuerza a crear una linea.
            Rect rect = EditorGUILayout.GetControlRect();
            //  Dibuja una linea de tamaño 1
            rect.height = 1;
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        //  Para dibujar el tamaño que tiene la ventana, sirve para poder ajustar bien
        //  el min size
        private void DrawSize()
        {
            EditorGUILayout.LabelField("X: " + base.position.width.ToString());
            EditorGUILayout.LabelField("Y: " + base.position.height.ToString());
        }
    }
}
