using UnityEngine;

public class SlidingDoor_Script : MonoBehaviour
{

    public GameObject trigger;
    public GameObject leftdoor;
    public GameObject rightdoor;

    Animator leftAnim;
    Animator rightAnim;

    // Start is called before the first frame update
    void Start()
    {
        leftAnim = leftdoor.GetComponent <Animator> ();
        rightAnim = rightdoor.GetComponent <Animator> ();
        
    }

    void OnTriggerEnter(Collider coll){
        if(coll.gameObject.tag == "Player"){
            SlideDoors (true);
        }

    }

    void OnTriggerExit(Collider coll){
        if(coll .gameObject.tag == "Player"){
            SlideDoors (false);
        }

    }

    void SlideDoors(bool state){
        leftAnim.SetBool ("slide", state);
        rightAnim.SetBool ("slide", state);
    }
    

}
