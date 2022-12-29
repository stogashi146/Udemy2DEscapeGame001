using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject rightObj;
    public GameObject leftObj;
    //キーを持っていたら開く
    public void OnThis()
    {
        bool hasCard= ItemBox.instance.CanUseItem(ItemManager.Item.Card);
        if (hasCard == true)
        {
            Open();
            ItemBox.instance.UseItem(ItemManager.Item.Card);
        }
    }
    void Open()
    {
        rightObj.SetActive(false);
        leftObj.SetActive(false);
    }
}
