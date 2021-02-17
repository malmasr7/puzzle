using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    
    // this file will check if the player is winning or Not 

    // the follwoing are the object used for determining the winnning state
    [SerializeField]
    private Transform[] pictures;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;


 
    // Start is called before the first frame update
    void Start()
    {
        // BASE STATES
       winText.SetActive(false);
       youWin = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (pictures[0].rotation.z == 0 &&
           pictures[1].rotation.z == 0 &&
           pictures[2].rotation.z == 0 &&
           pictures[3].rotation.z == 0 &&
           pictures[4].rotation.z == 0 &&
           pictures[5].rotation.z == 0 &&
           pictures[6].rotation.z == 0 &&
           pictures[7].rotation.z == 0 )

           {
               youWin = true;
               winText.SetActive(true);
           }
    }


}
