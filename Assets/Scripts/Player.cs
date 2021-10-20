using UnityEngine;
namespace Core
{
    public class Player : MonoBehaviour
    {
        private float _speed = 2;
        void Update()
        {

        }

        private void Move(string direction)
        {
            Vector3 dir = new Vector3();

            //Starter.PlayerRigidBody.AddForce(dir * _speed);
        }
    }
}