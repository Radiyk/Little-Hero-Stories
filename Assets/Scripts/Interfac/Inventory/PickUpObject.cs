using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpObject : MonoBehaviour
{
    public Item item;
    public Button actionButton;
    public GameObject parent;
    private float dist;
    private float minDist = 1.5f;
    private Transform player;

    void Start()
    {
        actionButton.GetComponent<Button>().onClick.AddListener(delegate {TakeLoot();});
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    


    public void TakeLoot()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < minDist)
        {
            Inventory.instance.PutInEmptySlot(item);
            DestroyObj();
        }
    }

    public virtual void DestroyObj()
    {
        Destroy(parent);
    }
}
