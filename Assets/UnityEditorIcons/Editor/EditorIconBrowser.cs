using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.UnityEditorIcons
{
    class EditorIconBrowser : EditorWindow
    {
        private static PropertyInfo[] properties;
        private Vector2 scrollPosition;

        [MenuItem("Window/Editor Icon Browser")]
        private static void Init()
        {
            properties = typeof(EditorIcons).GetProperties(BindingFlags.Static | BindingFlags.Public);
            EditorIconBrowser window = (EditorIconBrowser)EditorWindow.GetWindow(typeof(EditorIconBrowser));
            GUIContent title = new GUIContent(EditorIcons.Help);
            title.text = "Editor Icons";
            title.tooltip = "Unity editor built-in icons";
            window.titleContent = title;

            window.Show();
        }

        private void OnGUI()
        {
            if (properties == null) properties = typeof(EditorIcons).GetProperties(BindingFlags.Static | BindingFlags.Public);

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition);
            foreach (PropertyInfo p in properties)
            {
                GUIContent label = new GUIContent((GUIContent)p.GetValue(null));
                label.text = p.Name;
                EditorGUILayout.LabelField(label);
            }
            EditorGUILayout.EndScrollView();
        }
    }

}