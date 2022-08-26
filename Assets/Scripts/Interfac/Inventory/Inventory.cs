using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public Transform SlotsParent;

    public SlotInventory[] inventorySlots = new SlotInventory[9];

    void Start()
    {
        Close();
        instance = this;
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            inventorySlots[i] = SlotsParent.GetChild(i).GetComponent<SlotInventory>();
        }
    }

    public void PutInEmptySlot(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (inventorySlots[i].SlotItem == null)
            {
                item.countItem = 1;
                inventorySlots[i].PutInSlot(item);
                return;
            }
        }
       
    }

    public void AddStackableItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            
               if (inventorySlots[i].SlotItem != null)
            {
                if (inventorySlots[i].SlotItem.name == item.name)
                {
                    
                    SlotInventory.countItem++;
                    return;
                }
            } 
               
            
        }
        PutInEmptySlot(item);
    }

    public void Open()
    {
            gameObject.transform.localScale = new Vector3(5, 4, 4);
    }

    public void Close()
    {
            gameObject.transform.localScale = Vector3.zero;
    }
}
