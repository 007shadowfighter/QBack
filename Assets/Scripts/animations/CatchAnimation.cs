using UnityEngine;
public class CatchAnimation : MonoBehaviour
{

    Animator anim;
    

    void Start()
    {
        anim = GetComponentInParent<Animator>();
        //anim.enabled = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == ("Player"))
        {
            //anim.enabled = true;
            anim.Play("Run");
        }
    }
}