using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoMoveExampleScript : MonoBehaviour
{
    [SerializeField] float animationDuration;
    [SerializeField] Ease EaseType;
    private void OnCollisionEnter(Collision collision)
    {
        if(this.gameObject.name == "UpperCube" && collision.gameObject.tag == "Player")
        {
            this.gameObject.transform.DOMoveY(5f, animationDuration)
                .SetEase(EaseType);
        }
        else if (this.gameObject.name == "LeftCube" && collision.gameObject.tag == "Player")
        {
            this.gameObject.transform.DOMoveX(-5f, animationDuration)
                   .SetEase(EaseType);

        }
        else if (this.gameObject.name == "RightCube" && collision.gameObject.tag == "Player")
        {
            this.gameObject.transform.DOMoveX(5f, animationDuration)
                .SetEase(EaseType);
        }
    }
}
