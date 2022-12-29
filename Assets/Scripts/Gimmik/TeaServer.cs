using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaServer : MonoBehaviour
{

    public Tanuki tanuki;
//たぬきがいれば動けない
//たぬきがいなければ消える
public void OnThis()
    {
        bool movedTanuki = tanuki.moved;
        if (movedTanuki == true)
        {
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("たぬきがいて動かせない");
        }
    }
}
