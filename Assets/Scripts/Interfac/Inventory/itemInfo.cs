using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemInfo : MonoBehaviour
{
    public static itemInfo instance;

    private Image backGround;
    private Text title;
    private Text description;
    private Image icon;

    private Button buttonUse;
    private Button buttonDelete;
    private Button buttonExit;

    private Item infoItem;
    private SlotInventory CurrentSlot;


    private void Start() 
    {
        instance = this;

        backGround = GetComponent<Image>();
        title = transform.GetChild(0).GetComponent<Text>();
        description = transform.GetChild(1).GetComponent<Text>();
        icon = transform.GetChild(2).GetComponent<Image>();

        buttonUse = transform.GetChild(3).GetComponent<Button>();
        buttonDelete = transform.GetChild(4).GetComponent<Button>();
        buttonExit = transform.GetChild(5).GetComponent<Button>();

        buttonUse.onClick.AddListener(UseItem);
        buttonDelete.onClick.AddListener(DeleteItem);
        buttonExit.onClick.AddListener(Close);
    }

    public void ChangeInfo(Item item)
    {
        title.text = item.name;
        description.text = item.Description;
        icon.sprite = item.icon;
    }

    public void UseItem()
    {
        UseOfItem.instance.Use(infoItem);
    }

    public void DeleteItem()
    {
        CurrentSlot.ClearSlot();
        Close();
    }

    public void Open(Item item, SlotInventory currentSlot)
    {
        ChangeInfo(item);
        infoItem = item;
        CurrentSlot = currentSlot;

        gameObject.transform.localScale = Vector3.one;
    }

    public void Close()
    {
        gameObject.transform.localScale = Vector3.zero;
    }
}
