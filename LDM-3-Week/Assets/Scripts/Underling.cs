using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Underling : MonoBehaviour
{
    public static bool attack = false; // this sends them out to attack if true
    public Transform exit1; //the location of the first pathway, the underlings follow 2 pathways, exit1 and exit2, this is so that they don't get stuck in the walls
    public Transform exit2;
    public float speed; //their movement speed
    private float step; //this is here for the movement speed variable
    public Transform currExit; //this is the current path that they are going to
    public Transform returnSummoningHall; // This is the current path that they are returning to
    public Button thebutton;
    private float varX;
    private float varY;
    private float varZ;
    private Vector3 idle;
    public GameObject gameMenu2; // This menu is called when the Underling is in battle. (AKA A Battle Menu)
    public bool underlingIsInBattle; // Use it for UnderlingIsInBattle. (To true or false)
    public bool enterBattle; // Use it for Enter Battle. (To true or false)
    public UIManager uimanager; // Instantiates the rules of the battle menu (if bools are met [I.E returnSummoningHall = true])
    public Transform return1;
    public Transform return2; 
    public void Update()
    {
        if (attack == true) //this checks if the player has pressed attack
        {
            WalkToExit(); //this activates the attack 
        }
        if (uimanager.returnSummoningHall)
        {
            WalkBackToSummoningHall();
        }
        step = speed * Time.deltaTime; //this is their movement speed
        varX = Random.Range(0, 90);
        varZ = Random.Range(0, 90);
    }
    void Awake()
    {
        varY = 8;
        uimanager = FindObjectOfType<UIManager>();
    }

    public void UnderlingAttack() //this is here to test the attack function
    {
        attack = true;
        currExit = exit1; //this sets their current path to the first red cube that is INSIDE the base
    }

    public void UnderlingReturn()
    {
        returnSummoningHall = return1;
    }

    void WalkToExit()
    {
        transform.position = Vector3.MoveTowards(transform.position, currExit.position, step); //this makes them actually walk towards the currently assigned red cube
    }

    public void WalkBackToSummoningHall()
    {
        transform.position = Vector3.MoveTowards(transform.position, returnSummoningHall.position, step); //this makes them actually walk towards the currently back to the Summoning Hall
    }

    void OnTriggerEnter(Collider other) //this checks if they collide with a trigger, in this case. Only the red cube is a trigger
    {
        currExit = exit2;  //this sets their path to the far edge of the bridge, the second red cube OUTSIDE of the base
        if(other.CompareTag("exit") == true) // this checks for the final exit tag
        {
            SelectEnemyBase(); //this triggers the event for when they enter the final exit tag
            other.tag = ("not-active"); //changes the tag so that the event doesn't happen for each and every single underling

        }
    }

    void SelectEnemyBase() //the event that occurs when the underlings reach the final exit
    {
        Debug.Log("I'm the first one!");
        EnterBattle(); // This initiates the Menu for attacking the base.
    }

    void EnterBattle()
    {
        gameMenu2.SetActive(true); // Setting the Menu to Active.
    }

}
