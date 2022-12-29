using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker0 : MonoBehaviour
{
    public GameObject openObj;
    //ダイアルをクリアしたら、ロッカーをオープンにする
    public void Open()
    {
        openObj.SetActive(true);
    }

}
