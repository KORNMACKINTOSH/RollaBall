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
            // �����܂ł̓{�[�i�X�^�C����2�b�҂�
            yield return new WaitForSeconds(bonusTime);
            // �����鎞�Ԃ�5�b�Ȃ̂ŁA�{�[�i�X�^�C����2�b�����3�b�҂�
            yield return new WaitForSeconds(disappearTime - bonusTime);
            Destroy(this.gameObject);
        }
    }

}
