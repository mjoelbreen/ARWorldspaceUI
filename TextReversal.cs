using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextReversal : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;

    void Awake()
    {
        text2.text = text1.text;
    }
}
