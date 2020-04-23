using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Underling : MonoBehaviour
{
    public bool attack = false; // this sends them out to attack if true
    public Transform exit1; //the location of the first pathway, the underlings follow 2 pathways, exit1 and exit2, this is so that they don't get stuck in the walls
    public Transform exit2;
    public float speed; //their movement speed
    private float step; //this is here for the movement speed variable
    public Transform currExit; //this is the current path that they are going to
    public Button thebutton;
    public void Update()
    {
        if (attack == true) //this checks if the player has pressed attack
        {
            WalkToExit(); //this activates the attack 
        }
        step = speed * Time.deltaTime; //this is their movement speed
    }



    void Awake()
    {
        thebutton.onClick.AddListener(UnderlingAttack); // THIS IS CURRENTLY NOT WORKING, FIX PLS!!!!!!! ( its supposed to add a listener to the button which once pressed will send out the demons to the bridge)
    }

    public void UnderlingAttack() //this is here to test the attack function
    {
        attack = true;
        currExit = exit1; //this sets their current path to the first red cube that is INSIDE the base
    }

    public void OnMouseDown()
    {
        attack = true;
        currExit = exit1;
    }
    void WalkToExit()
    {
        transform.position = Vector3.MoveTowards(transform.position, currExit.position, step); //this makes them actually walk towards the currently assigned red cube
    }

    void OnTriggerEnter(Collider other) //this checks if they collide with a trigger, in this case. Only the red cube is a trigger
    {
        currExit = exit2;  //this sets their path to the far edge of the bridge, the second red cube OUTSIDE of the base
    }

}
