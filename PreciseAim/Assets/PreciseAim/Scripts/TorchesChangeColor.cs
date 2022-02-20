using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchesChangeColor : MonoBehaviour
{
    public GameObject Torches;
    public Color[] Colors;
    private int colorIndex = 0;
    public float lerpTime = 1;
    float t = 0f;
    void Start()
    {
        for (int i = 0; i < Torches.transform.childCount; i++)
        {
            Light currentTorchLight = Torches.transform.GetChild(i).GetChild(1).GetChild(0).GetComponent<Light>();
            currentTorchLight.color = Color.white;
        }
    }
    void Update()
    {
        for (int i = 0; i < Torches.transform.childCount; i++)
        {
            Light currentTorchLight = Torches.transform.GetChild(i).GetChild(1).GetChild(0).GetComponent<Light>();
            currentTorchLight.color = Color.Lerp(currentTorchLight.color,Colors[colorIndex],lerpTime*Time.deltaTime);
        }
        t = Mathf.Lerp(t, 1f, lerpTime * Time.deltaTime);
        if(t>.9f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= Colors.Length) ? 0 : colorIndex;
        }
    }
}
