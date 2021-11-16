using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class DoPathExampleScript : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] PathType pathType;
    [SerializeField] PathMode pathMode;
    bool isHit = false;
    [SerializeField] Vector3[] path;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && isHit == false)
        {
            this.transform.DOPath(path, duration, pathType, pathMode, 10, Color.blue);
            isHit = true;
        }
        
    }

    
}
