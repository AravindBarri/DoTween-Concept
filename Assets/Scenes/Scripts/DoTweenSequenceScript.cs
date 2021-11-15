using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenSequenceScript : MonoBehaviour
{
    [SerializeField] float animationDuration;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer>();
            Sequence seq = DOTween.Sequence();
            seq
                .Append(this.gameObject.transform.DOMoveX(5f, animationDuration))
                .Append(this.gameObject.transform.DOMoveX(-10f, animationDuration))
                .Append(this.gameObject.transform.DOMoveX(5f, animationDuration))
                .Append(mr.material.DOColor(Color.red, 3f))
                .Append(this.gameObject.transform.DOShakePosition(3f, 0.4f, 3, 10, false, true));
        }
    }
}
