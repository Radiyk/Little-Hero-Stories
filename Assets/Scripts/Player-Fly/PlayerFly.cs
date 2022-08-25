using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFly : MonoBehaviour
{
    private Vector2 targetPos;
    public float yincrement;
    public float speed;
    public int health;
    public float maxHeight;
    public float minHeight;



    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yincrement);
        }
    }
}
