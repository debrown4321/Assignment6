using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonCommands : MonoBehaviour
{

    private int editNum, count1, count2, count3, count4;
    public GameObject door;
    public TextMeshProUGUI num1, num2, num3, num4;
    public Image upArrow, downArrow, highlight;
    public Animator openDoor;
    public bool doorOpen = false;


    // Start is called before the first frame update
    void Start()
    {
        editNum = 1;
        count1 = 0;
        count2 = 0;
        count3 = 0;
        count4 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (num1.text == "0" && num2.text == "9" && num3.text == "5" && num4.text == "7" && !doorOpen)
        {
            openDoor.Play("Open Door");
            doorOpen = true;
        }
    }

    public void numChangeLeft()
    {
        editNum--;
        if (editNum < 1)
        {
            editNum = 4;
            highlight.transform.localPosition = new Vector3(60, 0, 0);
            downArrow.transform.localPosition = new Vector3(60, -45, 0);
            upArrow.transform.localPosition = new Vector3(60, 45, 0);
        }
        else if (editNum == 1)
        {
            highlight.transform.localPosition = new Vector3(-60, 0, 0);
            downArrow.transform.localPosition = new Vector3(-60, -45, 0);
            upArrow.transform.localPosition = new Vector3(-60, 45, 0);
        }
        else if (editNum == 2)
        {
            highlight.transform.localPosition = new Vector3(-20, 0, 0);
            downArrow.transform.localPosition = new Vector3(-20, -45, 0);
            upArrow.transform.localPosition = new Vector3(-20, 45, 0);
        }
        else if (editNum == 3)
        {
            highlight.transform.localPosition = new Vector3(20, 0, 0);
            downArrow.transform.localPosition = new Vector3(20, -45, 0);
            upArrow.transform.localPosition = new Vector3(20, 45, 0);
        }
    }

    public void numChangeRight()
    {
        editNum++;
        if (editNum > 4)
        {
            editNum = 1;
            highlight.transform.localPosition = new Vector3(-60, 0, 0);
            downArrow.transform.localPosition = new Vector3(-60, -45, 0);
            upArrow.transform.localPosition = new Vector3(-60, 45, 0);
        }
        else if (editNum == 2)
        {
            highlight.transform.localPosition = new Vector3(-20, 0, 0);
            downArrow.transform.localPosition = new Vector3(-20, -45, 0);
            upArrow.transform.localPosition = new Vector3(-20, 45, 0);
        }
        else if (editNum == 3)
        {
            highlight.transform.localPosition = new Vector3(20, 0, 0);
            downArrow.transform.localPosition = new Vector3(20, -45, 0);
            upArrow.transform.localPosition = new Vector3(20, 45, 0);
        }
        else if (editNum == 4)
        {
            highlight.transform.localPosition = new Vector3(60, 0, 0);
            downArrow.transform.localPosition = new Vector3(60, -45, 0);
            upArrow.transform.localPosition = new Vector3(60, 45, 0);
        }
    }

    public void numIncrease()
    {
        if (editNum == 1)
        {
            count1++;
            if (count1 > 9)
            {
                count1 = 0;
            }
            num1.text = count1.ToString();
        }
        else if (editNum == 2)
        {
            count2++;
            if (count2 > 9)
            {
                count2 = 0;
            }
            num2.text = count2.ToString();
        }
        else if (editNum == 3)
        {
            count3++;
            if (count3 > 9)
            {
                count3 = 0;
            }
            num3.text = count3.ToString();
        }
        else if (editNum == 4)
        {
            count4++;
            if (count4 > 9)
            {
                count4 = 0;
            }
            num4.text = count4.ToString();
        }
    }

    public void numDecrease()
    {
        if (editNum == 1)
        {
            count1--;
            if (count1 < 0)
            {
                count1 = 9;
            }
            num1.text = count1.ToString();
        }
        else if (editNum == 2)
        {
            count2--;
            if (count2 < 0)
            {
                count2 = 9;
            }
            num2.text = count2.ToString();
        }
        else if (editNum == 3)
        {
            count3--;
            if (count3 < 0)
            {
                count3 = 9;
            }
            num3.text = count3.ToString();
        }
        else if (editNum == 4)
        {
            count4--;
            if (count4 < 0)
            {
                count4 = 9;
            }
            num4.text = count4.ToString();
        }
    }
}
