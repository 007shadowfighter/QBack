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
        if (col.CompareTag("Player"))
        {
            anim.SetBool("footballPlayerBackflipOn", true);
            //play audio clip and do anything else
        }
    }
}
