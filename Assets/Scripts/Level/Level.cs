using System.Collections.Generic;
using UnityEngine;

namespace level
{
    [CreateAssetMenu(fileName = "Level", menuName = "Create level")]
    public class Level : ScriptableObject
    {
        public List<LevelObject> LevelObjects = new List<LevelObject>();
    }

    [System.Serializable]
    public class LevelObject
    {
        public GameObject Prefab;
        public Vector3 Position;
    }
}


