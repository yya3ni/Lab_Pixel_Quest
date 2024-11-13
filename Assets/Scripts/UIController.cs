using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Image heartImage;
    public TextMeshProUGUI coinText;

    public void UpdateHeartImage(float healthValue)
    {
        heartImage.fillAmount = healthValue;
    }

    public void UpdateCoinText(string text)
    {
        coinText.text = text;
    }

}
