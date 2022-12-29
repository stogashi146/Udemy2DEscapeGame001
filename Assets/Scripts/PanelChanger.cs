using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    public GameObject rightArrows;
    public GameObject leftArrows;
    public GameObject backArrows;

    enum Panel
    {
        Panel0,
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,
        Panel8,
    }

    //panel0
    Panel currentPanel;

    private void Start()
    {
        showPanel(Panel.Panel0);

    }

    void HideArrows()
    {
        rightArrows.SetActive(false);
        leftArrows.SetActive(false);
        backArrows.SetActive(false);

    }


    public void OnRightClick()
    {
        switch (currentPanel)
        {
            case Panel.Panel0:
                showPanel(Panel.Panel1);
                break;
            case Panel.Panel1:
                showPanel(Panel.Panel2);
                break;
            case Panel.Panel6:
                showPanel(Panel.Panel7);
                break;
            case Panel.Panel7:
                showPanel(Panel.Panel8);
                break;

        }

    }
    public void OnLeftClick()
    {
        switch (currentPanel)
        {
            case Panel.Panel1:
                showPanel(Panel.Panel0);
                break;
            case Panel.Panel2:
                showPanel(Panel.Panel1);
                break;
            case Panel.Panel7:
                showPanel(Panel.Panel6);
                break;
            case Panel.Panel8:
                showPanel(Panel.Panel7);
                break;

        }
    }
    public void OnBackClick()
    {
        switch (currentPanel)
        {
            case Panel.Panel3:
                showPanel(Panel.Panel0);
                break;
            case Panel.Panel4:
                showPanel(Panel.Panel1);
                break;
            case Panel.Panel5:
                showPanel(Panel.Panel2);
                break;


        }
    }

    public void OnLocker()
    {
        showPanel(Panel.Panel3);
    }

    public void OnPig()
    {
        showPanel(Panel.Panel4);
    }
    public void OnBucker()
    {
        showPanel(Panel.Panel5);
    }

    public void OnHall2()
    {
        showPanel(Panel.Panel6);
    }
    public void OnHall6()
    {
        showPanel(Panel.Panel2);
    }


    void showPanel(Panel panel)
    {
        HideArrows();
        currentPanel = panel;
        switch (panel)
        {
            case Panel.Panel0:
                rightArrows.SetActive(true);
                transform.localPosition =new Vector2(0, 0);
                break;
            case Panel.Panel1:
                rightArrows.SetActive(true);
                leftArrows.SetActive(true);
                transform.localPosition = new Vector2(-1500, 0);
                break;
            case Panel.Panel2:
               leftArrows.SetActive(true);
                transform.localPosition = new Vector2(-3000, 0);
                break;
            case Panel.Panel3:
               backArrows.SetActive(true);
                transform.localPosition = new Vector2(0, 2000);
                break;
            case Panel.Panel4:
                backArrows.SetActive(true);
                transform.localPosition = new Vector2(-1500, 2000);
                break;
            case Panel.Panel5:
                backArrows.SetActive(true);
                transform.localPosition = new Vector2(-3000, 2000);
                break;
            case Panel.Panel6:
                rightArrows.SetActive(true);
                transform.localPosition = new Vector2(0, 4000);
                break;
            case Panel.Panel7:
                rightArrows.SetActive(true);
                leftArrows.SetActive(true);
                transform.localPosition = new Vector2(-1500, 4000);
                break;
            case Panel.Panel8:
                leftArrows.SetActive(true);
                transform.localPosition = new Vector2(-3000, 4000);
                break;
           


        }
    }
}
