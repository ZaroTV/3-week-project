using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagmaEffect : MonoBehaviour
{
    private float lifetime;



    // Start is called before the first frame update
    void Start()
    {
        lifetime = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if(lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
