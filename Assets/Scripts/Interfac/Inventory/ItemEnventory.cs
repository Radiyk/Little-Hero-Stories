

using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "~/ItemEnventory")]

public class ItemInventory : ScriptableObject 
    

{
    [Header("Характеристики предмета")]
    public string Name = "";
    //public string EngName = "";
    public string Description = "";
    //public string EngDescription = "";
    public Sprite icon = null;

    // [Header("Игровые характеристики")]
    // public int time;

    // [Header("Характеристики для торговли")]
    // public int Coins;
    // public int Gems;

    // public string PlayerPrefsName;
}
