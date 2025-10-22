// usingはPythonのimport文に相当
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// クラス名
// MonoBehaviourを継承しているクラス(MonoBehaviourの機能が使える)
public class MoveSpere : MonoBehaviour
{

    // 変数を定義
    // 変数のスコープ
    // メンバ変数としてTransformのコンポーネントを格納する変数を定義
    Transform sphereTransform;


    // 関数(Pythonのdefに相当)
    // C#では関数の戻り値(return)の形を指定する(int, String)
    // voidは戻り値が無い場合に使う
    // Start()はゲームオブジェクト生成時に実行される(1回だけ)
    void Start()
    {
        // GetComponent<>()は指定したコンポーネントを取得する
        // Transformコンポーネントを取得
        sphereTransform = GetComponent<Transform>();
    }

    // 関数(Pythonのdefに相当)
    // Update()は毎フレーム実行される
    void Update()
    {
        // Vector3()はX,Y,Zを指定できる
        // fを付けるとfloat型(少数)になる
        // intは整数型なので、少数を扱う場合はfloat型を使う
        sphereTransform.position += new Vector3(0.01f, 0, 0);
    }
}
