using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePig : MonoBehaviour
{
    public GameObject pigbj;
    public GameObject brokenPigObj;

    public void OnThis()
    {

        bool hasHammer = ItemBox.instance.CanUseItem(ItemManager.Item.Hammer);
        if (hasHammer == true)
        {
            Break();
            ItemBox.instance.UseItem(ItemManager.Item.Hammer);
        }
        else
        {
            Debug.Log("壊せそうだ");
        }
    }
    void Break()
    {
        pigbj.SetActive(false); 
        //壊れた画像を表示
        brokenPigObj.SetActive(true);
    }
}
