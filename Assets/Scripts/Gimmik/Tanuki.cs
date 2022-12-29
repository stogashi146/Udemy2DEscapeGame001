using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanuki : MonoBehaviour
{
    public bool moved = false;
public void OnThis()
    {
        bool hasLeaf= ItemBox.instance.CanUseItem(ItemManager.Item.Leaf);
        if (hasLeaf == true)
        {
            moved = true;
            gameObject.SetActive(false);
            ItemBox.instance.UseItem(ItemManager.Item.Leaf);
        }
    }
}
