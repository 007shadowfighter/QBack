//using UnityEngine;
//public class CatchAnimation : MonoBehaviour
//{

//    Animator anim;
//    AudioClip sound;

//    void Start()
//    {
//        anim.enabled = false;
//    }

//    void OnTriggerEnter(Collider col)
//    {
//        if (col.gameObject.tag == ("Player"))
//        {
//            anim.enabled = true;
//            AudioSource.PlayClipAtPoint(sound, transform.position);
//        }
//    }
//}