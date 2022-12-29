using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHaydrant : MonoBehaviour
{
    public GameObject opneObj;
    // 連続入力の実装
    
    enum Direction
    {
        Left=0,
        Right=1,

    }
    //Playerの入力
    List<Direction> userInputs = new List<Direction>();

    //右、左、左、右、右
    Direction[] correctAnswers = { Direction.Right, Direction.Left, Direction.Left, Direction.Right, Direction.Right };

    //入力
    public void OnButton(int type)
    {
        //type:0 左
        //type:1 右
        if (type == 0)
        {
            userInputs.Add(Direction.Left);
        }
        if (type == 1)
        {
            userInputs.Add(Direction.Right);
        }


        Debug.Log(type);
        //ユーザーの入力を代入
        //５回入力されたらチェックする
        if (userInputs.Count == 5)
        {
            if (IsAllClear() == true)
            {
                Clear();
            }
            else
            {
                //不一致の場合 reset
                resetInput();
            }
        }

    }
    void resetInput()
    {
        userInputs.Clear();
        Debug.Log("リセット");
    }

    bool IsAllClear()
    {
        for (int i=0;i<userInputs.Count;i++)
        {
            if (userInputs[i] != correctAnswers[i])
            {
                return false;
            }

        }
        return true;
    }

    void Clear()
    {
        Debug.Log("クリア");
        opneObj.SetActive(true);
    }
}
    