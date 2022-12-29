using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DialLock : MonoBehaviour
{
    //３つのボタンをそれぞれクリックして、絵柄がすべて一致すればクリア
    //ボタン画像の取得
    public Image[] buttons;
//画像の列挙
enum Mark
    {
        Maru,
        Sanakaku,
        Hoshi,
        Daia
    }
    //現在のマーク
    Mark[] currentMark ={Mark.Maru,Mark.Maru,Mark.Maru};
    Mark[] correctAnswerMarks = { Mark.Maru, Mark.Sanakaku, Mark.Hoshi };

    //表示する画像の素材一覧
    public Sprite[] resourcesSprote;

    public UnityEvent ClearEvent;

 

    public void OnMarkButton(int position)
    {

        //マークを変更する
        ChangeMark(position);
        //positionの画像を変更する
        ShowMark(position);

        if (IsAllClearMark() == true)
        {
            Clear();
        }
    }
    void ChangeMark(int position)
    {
        currentMark[position]++;
        if (currentMark[position] > Mark.Daia)
        {
            currentMark[position] = Mark.Maru;
        }
 
    }
    void ShowMark(int position)
    {
        int index = (int)currentMark[position];//１つ次のマーク
        buttons[position].sprite = resourcesSprote[index];
    }

    bool IsAllClearMark()
    {
        for(int i = 0; i < currentMark.Length; i++)
        {
            if (currentMark[i] != correctAnswerMarks[i])
            {
                return false;
            }
        }
        return true;
    }

    void Clear()
    {
        //ロッカーを開けたい

        Debug.Log("ロッカーが開いた");
        ClearEvent.Invoke();
    }

}
