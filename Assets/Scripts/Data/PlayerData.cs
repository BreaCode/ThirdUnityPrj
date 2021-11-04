using UnityEngine;
using System.Collections.Generic;

namespace Core
{
    [CreateAssetMenu(fileName = "Data", menuName = "Create playerdata")]
    public sealed class PlayerData : ScriptableObject
    {
        public GameObject[] Cameras;
        public GameObject Camera;
        public GameObject PlayerObject;
        public string ControlType;
        public int SceneNumber;
        public int Score;
        public int MaxScore;
        public float CameraHeight;
        public float Speed;
        public bool BlueKey;
        public bool YellowKey;
        public bool RedKey;
    }
}
