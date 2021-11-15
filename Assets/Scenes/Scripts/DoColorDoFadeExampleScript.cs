using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoColorDoFadeExampleScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(this.gameObject.name == "ColorCube" && collision.gameObject.tag == "Player")
        {
            MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer>();
            mr.material.DOColor(Color.red, 3f);
        }
        else if (this.gameObject.name == "FadeCube" && collision.gameObject.tag == "Player")
        {
            MeshRenderer me = this.gameObject.GetComponent<MeshRenderer>();
            me.material.DOFade(0f, 3f);
        }
    
    }
}
