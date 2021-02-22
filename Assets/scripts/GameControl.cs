using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    
    // this file will check if the player is winning or Not 

    // the follwoing are the object used for determining the winnning state
    [SerializeField]
    private Transform[] my_pictures;    

    // this is the text that will bring the fact once the game is done 
    [SerializeField]
    private GameObject winText;

    //this check if the user won the game 
    public static bool winner;


 
    // Start is called before the first frame update
    void Start()
    {
        // BASE STATES
       winText.SetActive(false);
       winner = false; 
    }

    // Update is called once per frame
    void Update()
    {
        // check if all the pictures are in the right order 
        if(checker(my_pictures))
           {
               winner = true;

               winText.SetActive(true);
           }
    }

    public bool checker(Transform[] pics)
    {

        // for (int i = 0; i < 7; i++)
        // {
        //     if (pics[i].rotation.z == 0)
        //     {
        //         return true;
        //     }
        // }
        // return false;

        if (pics[0].rotation.z == 0 &&
           pics[1].rotation.z == 0 &&
           pics[2].rotation.z == 0 &&
           pics[3].rotation.z == 0 &&
           pics[4].rotation.z == 0 &&
           pics[5].rotation.z == 0 &&
           pics[6].rotation.z == 0 &&
           pics[7].rotation.z == 0 )
           {
               return true;
           }
        return false;    
   
    }
}

