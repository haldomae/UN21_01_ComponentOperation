using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Sliderコンポーネントを使うために必要

public class MoveSlider : MonoBehaviour
{
    // メンバ変数としてSliderのコンポーネントを格納する変数を定義
    Slider hpSlider;

    // Textのゲームオブジェクトを格納する変数を定義
    public GameObject hpTextObject;
    // 外部から取得したTextオブジェクトの
    // Textコンポーネントを格納する変数を定義
    Text hpText;
    // Start is called before the first frame update
    void Start()
    {
        // Sliderコンポーネントを格納する
        hpSlider = GetComponent<Slider>();
        // スライダーの値を変更
        hpSlider.value = 50;
        // スライダーの最小値と最大値を変更
        hpSlider.minValue = 20;
        hpSlider.maxValue = 500;


        // 外部のTextオブジェクトからTextコンポーネントを取得して変数に格納
        hpText = hpTextObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // スライダーの値を毎フレーム事にログに出力
        Debug.Log(hpSlider.value);
        // Textコンポーネントのテキストをスライダーの値に変更
        // ToString()は数値を文字列に変換する
        hpText.text = hpSlider.value.ToString();
    }
}
