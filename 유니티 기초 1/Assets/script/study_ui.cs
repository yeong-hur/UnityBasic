using TMPro;
using UnityEngine;

public class Study_UI : MonoBehaviour
{
    public TextMeshProUGUI txt_Text;
    public string newText;

    public void OnClickButton()
    {
        txt_Text.text = newText;
    }
}
