using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    public GameObject[] candy;
    private int time = 0;
    private GameObject currentCandy;
    [SerializeField] private GameObject monster;
    int randomNum;
    void Start()
    {
        
    }

    void Update()
    {
        time += 1;

        if (time % 1200 == 0 || time == 1)
        {
            Destroy(currentCandy); currentCandy = null;
            randomNum = Random.Range(0, 5);
            currentCandy = Instantiate(candy[randomNum]);
            currentCandy.AddComponent<Rigidbody2D>();
            currentCandy.AddComponent<BoxCollider2D>();
            currentCandy.AddComponent<CandyBehavoiur>();
        }
    }
}
