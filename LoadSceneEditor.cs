#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

namespace GDGames.SceneManagement
{
    [CustomEditor(typeof(LoadSceneButton))]
    public class LoadSceneEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            LoadSceneButton loadSceneButton = (LoadSceneButton)target;

            base.OnInspectorGUI();

            if (loadSceneButton.scenesNames != null && loadSceneButton.scenesNames.Length > 0)
            {
                GUIContent arrayLabel = new GUIContent("Scene To Load");
                loadSceneButton.currentScene = EditorGUILayout.Popup(arrayLabel, loadSceneButton.currentScene, loadSceneButton.scenesNames);
            }

            if (GUI.changed)
            {
                EditorUtility.SetDirty(target);
            }

            loadSceneButton.UpdateScenesNames();
        }
    }
}
#endif