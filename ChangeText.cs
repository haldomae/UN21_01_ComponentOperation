using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Textコンポーネントを使うために必要

public class ChangeText : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // Textコンポーネントを格納する変数を定義
        // Textコンポーネントを取得して変数に格納
        Text hpText = GetComponent<Text>();
        // テキストの値を変更
        hpText.text = "50";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
