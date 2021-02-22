using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // working when object is triggered 
    private void OnMouseDown()
    {
        if(!GameControl.winner){
            // this will change the z tranform every time a click happened 
            transform.Rotate(0f,0f,90f);
        }
    }
}
