using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    bool isEnabled;
    void Start()
    {
        isEnabled = false;
        InvokeRepeating("Enabled", 0, 3f);
    }

    private void Enabled()
    {
        if (!isEnabled)
        {
            //this.gameObject.GetComponent<BoxCollider>().enabled = true;
            this.gameObject.GetComponent<MeshRenderer>().enabled = true;
            isEnabled = true;
            Debug.Log("켜짐");
        }else if(isEnabled)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            //this.gameObject.GetComponent<BoxCollider>().enabled = false;
            isEnabled = false;
            Debug.Log("꺼짐");
        }
    }

    void Update()
    {
        
    }
}
