using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Apple;

public class SummoningHall : MonoBehaviour
{
    public int essence = 100; // The resource for summoning underlings
    public int costSum = 20; //Cost for summoning 1 underling
    public GameObject underling;
    void OnMouseDown()
    {
        if (essence >= costSum)
        {
            Instantiate(underling, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
