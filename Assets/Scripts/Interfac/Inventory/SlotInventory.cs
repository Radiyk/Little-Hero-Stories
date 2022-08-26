using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotInventory : MonoBehaviour
{
    public static SlotInventory instance;

    public Item SlotItem;

    Image icon;
    Text count;
    Button button;
   
    void Start()
    {
        instance = this;
        icon = gameObject.transform.GetChild(0).GetComponent<Image>();
        count = gameObject.transform.GetChild(1).GetComponent<Text>();
        count.enabled = false;
        button = GetComponent<Button>();
        button.onClick.AddListener(SlotClicked);
    }

    public void PutInSlot(Item item)
    {
        icon.sprite = item.icon;
        count.text = item.countItem.ToString();
        SlotItem = item;
        count.enabled = true;
        icon.enabled = true;
    }

    private void SlotClicked()
    {
        if (SlotItem != null)
        itemInfo.instance.Open(SlotItem, this);
    }

    public void ClearSlot()
    {
        SlotItem = null;
        icon.sprite = null;
        icon.enabled = false;
        count.text = null;
    }
}
