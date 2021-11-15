using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoShakePositionExampleScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Shake done");
            this.gameObject.transform.DOShakePosition(3f, 0.4f, 3, 10, false, true);
        }
    }
}
