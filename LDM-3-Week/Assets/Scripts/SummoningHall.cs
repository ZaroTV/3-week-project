using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Apple;

public class SummoningHall : MonoBehaviour
{
    public int essence = 100; // The resource for summoning underlings
    public int costSum = 20; //Cost for summoning 1 underling
    public GameObject underling; // the underling prefab which you will summon
    private float varX; //the spawning position for the X axis
    private float varY = 8; // the height of the spawning position, don't change this 
    private float varZ; //the spawning position for the Z axis
    private GameManager gameManager;


    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();    
    }
    void Update()
    {
        varX = Random.Range(0, 15); // these two random.ranges are here to constantly provide a random spawning location for the underlings
        varZ = Random.Range(18, 40);
    }
    void OnMouseDown() //this spawns the underlings
    {
        if (essence >= costSum) //this checks if you have enough essence
        {
            Instantiate(underling, new Vector3(varX, varY, varZ), Quaternion.identity); //this actually spawns them
            //gameManager.underlingCounter++;
            essence -= costSum; //this removes your current essence based on the value of costSum
        }
    }
}
