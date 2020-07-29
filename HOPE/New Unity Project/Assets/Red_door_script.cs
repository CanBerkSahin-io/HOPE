using UnityEngine;
using System.Collections;

public class Red_door_script : MonoBehaviour
{

   public Material[] material;
   Renderer rend;
    
    

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            {
                rend.sharedMaterial = material[2];
            }
        }
    }



}
