using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public enum Item
    {
        Leaf,
        Key,
        Card,
        Hammer,
        Paper,
    }
    public Item item;
    //クリックされたときに消す
    //アイテムボックスに追加する
    public void OnThis()
    {
        gameObject.SetActive(false);
        ItemBox.instance.SetItem(item);
    }
}
