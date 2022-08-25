using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemla : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerFlyr"))
        {
            other.GetComponent<PlayerFly>().health -= damage;
            Destroy(gameObject);

        }
    }
}
