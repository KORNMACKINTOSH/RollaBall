using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public class Coin : MonoBehaviour
    {
        private float bonusTime = 2f;
        private float disappearTime = 5f;
        void Start()
        {
            StartCoroutine(BonusTimeCoroutine());
        }
        IEnumerator BonusTimeCoroutine()
        {
            // ここまではボーナスタイムの2秒待つ
            yield return new WaitForSeconds(bonusTime);
            // 消える時間は5秒なので、ボーナスタイムを2秒消費した3秒待つ
            yield return new WaitForSeconds(disappearTime - bonusTime);
            Destroy(this.gameObject);
        }
    }

}
