using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifyButtonScript : MonoBehaviour
{
    public void ModifyText()
    {
        GameObject text = GameObject.Find("Text (TMP)");
        Debug.Log(text);
        TextMeshProUGUI tm = text.GetComponent<TextMeshProUGUI>();
        Debug.Log(tm);
        tm.text = "Modified text !!";
    }
}
