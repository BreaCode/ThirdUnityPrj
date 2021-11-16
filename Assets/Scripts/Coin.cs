using UnityEngine;
namespace Core
{
    public sealed class Coin
    {
        public void PickUp(GameObject triggerObject, PlayerData playerData)
        {
            playerData.Score += 1;
            GameEventSystem.current.ScoreUpdate();
            triggerObject.SetActive(false);
            //Debug.Log(playerData.Score + " / " + playerData.MaxScore);
        }
    }
}

