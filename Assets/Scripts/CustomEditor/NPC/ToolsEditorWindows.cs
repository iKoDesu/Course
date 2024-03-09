using UnityEngine;
using UnityEditor;

namespace UnityEngine.ToolsEditorWindow
{
    public class ToolsEditorWindows : EditorWindow
    {
        public void DrawHorizontalLine()
        {
            Rect rect = EditorGUILayout.GetControlRect();
            rect.height = 1;
            EditorGUI.DrawRect(rect, new Color(0.5f, 0.5f, 0.5f, 1));
        }

        public void DrawSize()
        {
            EditorGUILayout.LabelField("X: " + base.position.width.ToString());
            EditorGUILayout.LabelField("Y: " + base.position.height.ToString());
        }
    }
}
