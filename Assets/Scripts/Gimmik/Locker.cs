using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    //クリックしたとき鍵を持っていればopenにする
    //持っていなければログにだす
    public GameObject openObj;

    public void OnThis()
    {
        
        bool hasKey = ItemBox.instance.CanUseItem(ItemManager.Item.Key);
        if (hasKey == true)
        {
            //Openにする
            Open();
            ItemBox.instance.UseItem(ItemManager.Item.Key);
        }
        else
        {
            Debug.Log("鍵がかかっている");
        }
    }
    void Open()
    {
        //開いている画像を表示
        openObj.SetActive(true);
    }
  
}
