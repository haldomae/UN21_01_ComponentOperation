using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Sliderコンポーネントを使うために必要

public class MoveSlider : MonoBehaviour
{
    // メンバ変数としてSliderのコンポーネントを格納する変数を定義
    Slider hpSlider;
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
    }

    // Update is called once per frame
    void Update()
    {
        // スライダーの値を毎フレーム事にログに出力
        Debug.Log(hpSlider.value);
    }
}
