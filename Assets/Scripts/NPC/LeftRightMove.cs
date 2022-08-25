using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightMove : MonoBehaviour
{
    private float speed = 2f;
    private Vector3 direction;


    void Start()
    {
        direction = transform.right;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position + transform.up * 0.5f + transform.right * direction.x * 1f, 0.1f);

        if (collider.Length > 0) direction *= -1.0f;

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
    }

	// 	public float explosionRadius;
    // private void OnDrawGizmosSelected()
	// {
	// 	Gizmos.color = Color.red;

    //     Gizmos.DrawSphere(transform.position, explosionRadius);
    // }
	

}
