using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
	public float normalSpeed;

	public Transform[] moveSpots;
	private int randomSpot;


    
    void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);

    }

   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, normalSpeed * Time.deltaTime);

		if(Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
		{
			randomSpot = Random.Range(0, moveSpots.Length);
		}
    }
}
