using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleController : MonoBehaviour {
    private Toggle toggle;
    private Image backgroundImg;
    private ColorBlock colors;

    void Start() {
        toggle = GetComponent<Toggle>();
        backgroundImg = toggle.GetComponent<Image>();


        colors = toggle.colors;

        toggle.onValueChanged.AddListener(delegate
        {
            ToggleValueChanged(toggle);
        });
    }

    void Update() {

    }

    void ToggleValueChanged(Toggle toggle)
    {
        if (toggle.isOn)
        {
            backgroundImg.color = colors.normalColor;
        }
        else
        {
            backgroundImg.color = colors.disabledColor;
        }
    }


    public void Highlight()
    {
        backgroundImg.color = colors.highlightedColor;
    }

    public void Unhighlight()
    {
        if (toggle.isOn)
        {
            backgroundImg.color = colors.normalColor;
        }
        else
        {
            backgroundImg.color = colors.disabledColor;
        }
        
    }

    public void ChangeToggleValue()
    {
        toggle.isOn = !toggle.isOn;
    }
}