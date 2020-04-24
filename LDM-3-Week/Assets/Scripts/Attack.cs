using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Attack : MonoBehaviour
{
    public GameObject[] underlingList; //this creates a list named underlingList
    public void SetChildren() //this makes the underlings children of THIS gameobject
    {
        underlingList = GameObject.FindGameObjectsWithTag("underling"); //this looks for objects with " underling " tag and puts them in a list
        foreach (GameObject under in underlingList) //this foreach loop actually sets the underlings as children
        {
            under.transform.parent = this.gameObject.transform; //this is the function for setting underlings as children
        }
    }
    public void AttackFunc() // this makes the underlings attack
    {
        foreach (var item in underlingList) //this foreach accesses the list
        {
            item.GetComponent<Underling>().UnderlingAttack(); //this accesses each individual object in the list and activates their UnderlingAttack function
        }
    }
}
