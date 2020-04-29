using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMenu : MonoBehaviour
{
    public float cancelAttackTimer;
    public bool cancelAttack;
    public bool returnSummoningHall;
   public void CancelAttack()
    {
        print("CANCEL THE ATTACK!");
        cancelAttack = true;
        returnSummoningHall = true;
    }

    private void Awake()
    {
        cancelAttackTimer = 5;
    }
    


}
