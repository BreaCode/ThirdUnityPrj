using UnityEngine;
using System.Collections.Generic;

namespace Core
{
    [CreateAssetMenu(fileName = "Data", menuName = "Create data")]
    public sealed class Data : ScriptableObject
    {
        public GameObject[] Coins;
        public GameObject[] Traps;
        public GameObject[] Keys;
        public GameObject[] Doors;
        public GameObject Exit;
        public GameObject GUI;
        public string DefaultMode;
        public int SceneNumber;
    }
}
