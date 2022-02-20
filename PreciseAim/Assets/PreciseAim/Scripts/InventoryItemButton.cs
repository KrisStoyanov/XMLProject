using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class InventoryItemButton : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        if (yourButton.targetGraphic.GetComponent<Image>().sprite != null)
        {
            string wholename = yourButton.targetGraphic.GetComponent<Image>().sprite.ToString();
            string spriteName = wholename.Split(' ')[0];
            if (int.Parse(this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text) > 0)
            {
                this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = (int.Parse(this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text) - 1).ToString();
                Vector3 playerPosition = GameObject.FindGameObjectsWithTag("Player")[0].transform.position;
                Vector3 spawningPosition = playerPosition + GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<FirstPersonController>().m_Camera.transform.forward;
                GameObject gameObject = Instantiate((GameObject)Resources.Load("Prefabs/" + spriteName, typeof(GameObject)), spawningPosition, Quaternion.identity);
                gameObject.name = spriteName;
                if (gameObject.name == "crate")
                {
                    gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                gameObject.AddComponent<Rigidbody>();
                gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
            if (int.Parse(this.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text) == 0)
            {
                GetComponent<Image>().sprite = null;
            }
        }
    }
}
