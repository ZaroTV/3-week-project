using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    public GameObject underlingPrefab;
    public bool attacc = false;
    public void Start()
    {
            Button ButtonAttack = GetComponent<Button>();
    }
    public void Attackbutton()
    {
        Debug.Log("TEST");
        underlingPrefab.GetComponent<Underling>().attack = true;
    }
}
