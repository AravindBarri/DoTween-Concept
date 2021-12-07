using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenSequenceScriptTask : MonoBehaviour
{

    [SerializeField] float animationDuration;
    [SerializeField] float pathAnimationDuration;
    [SerializeField] float reversePathAnimationDuration;
    [SerializeField] PathType pathType;
    [SerializeField] PathMode pathMode;
    [SerializeField] Vector3[] path;
    [SerializeField] Vector3[] returnPath;
    [SerializeField] float timer;
    [SerializeField] bool keycheck = false;
    TweenCallback check;
    // Start is called before the first frame update
    void Start()
    {
        check += checkMethod;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            keycheck = true;
        }
        if(keycheck)
        {
            timer += Time.deltaTime;
        }
    }

    public void StartTweening()
    {
        keycheck = true;
        MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer>();
        Sequence seq = DOTween.Sequence();
        seq
            .Append(this.gameObject.transform.DOMoveX(-12f, animationDuration))
            .Append(this.transform.DOPath(path, pathAnimationDuration, pathType, pathMode, 10, Color.blue))
            .Append(this.gameObject.transform.DOMove(new Vector3(0, 1, 40), animationDuration))
            .Join(mr.material.DOColor(UnityEngine.Random.ColorHSV(), 2f))
            .Append(this.gameObject.transform.DOMove(new Vector3(0, 1, 40), animationDuration))
            .Join(this.gameObject.transform.DOShakePosition(3f, 0.4f, 3, 10, false, true))
            .Append(this.gameObject.transform.DOMove(new Vector3(0, 1, 70), animationDuration))
            .Join(mr.material.DOFade(0, 3f))
            .Append(this.gameObject.transform.DOMove(new Vector3(0, 1, 80), animationDuration))
            .Join(mr.material.DOFade(1, 3f))
            .OnComplete(() => { this.transform.DOPath(returnPath, reversePathAnimationDuration, pathType, pathMode, 10, Color.red); keycheck = false; });
    }
    public void checkMethod()
    {
        Debug.Log("OnUpdateCheck");
    }
}
