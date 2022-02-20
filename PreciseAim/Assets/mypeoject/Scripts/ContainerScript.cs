using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
public class ContainerScript : MonoBehaviour
{

    //public Image[] Items;
    public Image grid;
    public void Hide()
    {
        grid.enabled = false;
        for(int i = 0; i < grid.transform.childCount; i++)
        {
            grid.transform.GetChild(i).GetComponent<Image>().enabled = false;
            grid.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().enabled = false;
        }
    }
    public void Show()
    {
        grid.enabled = true;
        for (int i = 0; i < grid.transform.childCount; i++)
        {
            grid.transform.GetChild(i).GetComponent<Image>().enabled = true;
            grid.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().enabled = true;
        }
    }
}
