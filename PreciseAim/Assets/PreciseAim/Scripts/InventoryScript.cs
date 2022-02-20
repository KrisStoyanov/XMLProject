using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventoryScript : MonoBehaviour
{
    public Image coins;
    public TextMeshProUGUI coinsAmount;
    public Image Container;
    public void Hide()
    {
        coins.enabled = false;
        coinsAmount.enabled = false;
        Container.enabled = false;
        Container.GetComponent<ContainerScript>().Hide();
    }
    public void Show()
    {
        coins.enabled = true;
        coinsAmount.enabled = true;
        Container.enabled = true;
        Container.GetComponent<ContainerScript>().Show();
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
