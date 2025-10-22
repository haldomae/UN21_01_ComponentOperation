using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Imageコンポーネントを使うために必要

public class ChangeImage : MonoBehaviour
{
    // 新しく画像を格納する変数を定義
    // publicを付けるとInspectorから画像を設定できる
    public Sprite newImage;

    // Start is called before the first frame update
    void Start()
    {
        // Imageコンポーネントを格納する変数を定義
        Image img = GetComponent<Image>();
        // 画像を切り替え
        img.sprite = newImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
