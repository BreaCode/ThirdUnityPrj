using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace level
{
    public sealed class LevelEditor : EditorWindow
    {
        [SerializeField]
        private Level _level;

        [MenuItem("Window/Level editor")]
        public static void Init()
        {
            LevelEditor levelEditor = GetWindow<LevelEditor>("Level editor");
            levelEditor.Show();
        }

        private void OnGUI()
        {
            GUILayout.Space(10);

            _level = (Level)EditorGUILayout.ObjectField(_level, typeof(Level), false);

            GUILayout.Space(5);
            if (GUILayout.Button("Clear"))
            {
                GameObject[] findObject = GameObject.FindGameObjectsWithTag("LevelObject");
                foreach (var item in findObject)
                {
                    DestroyImmediate(item);
                }
            }

            GUILayout.Space(5);
            if (GUILayout.Button("Generate"))
            {
                foreach (var item in _level.LevelObjects)
                {
                    GameObject obj = PrefabUtility.InstantiatePrefab(item.Prefab) as GameObject;
                    obj.transform.position = item.Position;
                }
            }

            GUILayout.Space(5);
            if (GUILayout.Button("Save"))
            {
                GameObject[] saveObject = GameObject.FindGameObjectsWithTag("LevelObject");
                if (saveObject.Length > 0)
                {
                    _level.LevelObjects = new List<LevelObject>();
                    foreach (var item in saveObject)
                    {
                        LevelObject levelObject = new LevelObject()
                        {
                            Prefab = PrefabUtility.GetCorrespondingObjectFromOriginalSource(item),
                            Position = item.transform.position
                        };
                        _level.LevelObjects.Add(levelObject);
                    }

                    EditorUtility.SetDirty(_level);
                    EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
                }
            }
        }
    }
}
