using Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesBTN()
        {
            //GameManager.Instance.LoadLevelScene();
            Debug.Log("Yeni levela ge�iliyor");
        }

        public void NoBTN()
        {
            GameManager.Instance.LoadMenu();
        }
    }
}


