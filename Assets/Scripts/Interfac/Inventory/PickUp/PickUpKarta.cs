using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpKarta : MonoBehaviour
{
    public Item item;
    public Button lootButton;
    public GameObject parent;
    private float dist;
    private float minDist = 1.5f;
    private Transform player;

    void Start()
    {
        lootButton.GetComponent<Button>().onClick.AddListener(delegate {TakeLoot();});
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    


    
    public void TakeLoot()
    {
            Debug.Log("ff");
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < minDist)
        {
            Inventory.instance.AddStackableItem(item);
            DestroyObj();
        }
    }

    public void DestroyObj()
    {
        Destroy(parent);
    }
}
