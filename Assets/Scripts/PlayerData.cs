using UnityEngine;
using System.Collections.Generic;

namespace Core
{
    [CreateAssetMenu(fileName = "Data", menuName = "Create playerdata")]
    public class PlayerData : ScriptableObject
    {
        public GameObject Camera;
        public GameObject PlayerObject;
        public float Speed;
        public bool BlueKey;
        public bool YellowKey;
        public bool RedKey;
    }
}
