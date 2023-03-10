using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreRootCollision : MonoBehaviour
{
    public Transform root;

    // Start is called before the first frame update
    void Start()
    {
        //Prevents root being blocked by floor
        Physics2D.IgnoreCollision(root.GetComponent<Collider2D>(), GetComponent<Collider2D>()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
