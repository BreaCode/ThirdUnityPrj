using UnityEngine;
using System.Collections.Generic;

namespace Core
{
    [CreateAssetMenu(fileName = "Data", menuName = "Create data")]
    public sealed class Data : ScriptableObject
    {
        public List<LevelObject> LevelObjects = new List<LevelObject>();
    }

    [System.Serializable]
    public class LevelObject
    {
        public GameObject Object;
    }
}
