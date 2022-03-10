using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceTrigger : MonoBehaviour
{

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void onCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "Jail")
        {
            GetComponent<Animator>().Play("cat_walk");
        }
    }
}
