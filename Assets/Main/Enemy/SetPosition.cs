using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{

    private Vector3 startPosition;//スタート位置

    private Vector3 destination;//目的地

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;//今いる場所をスタート位置とする

        SetDestination(transform.position);//今いる場所を用いてSetdestinaitonメソッドを使用

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateRandomPosition()//ランダムに位置を選出する　この位置を目的地を定める
    {
        Vector2 randDestination = Random.insideUnitCircle * 8;//半径８メートル以内の位置をランダムで選出しVector2型のrandDestinationに代入する

        SetDestination(startPosition + new Vector3(randDestination.x, 0, randDestination.y));//SetDestinationメソッドを使用（最初の位置と今回のランダムで選出した位置を加算して）
                                                                                             //Vector3型のｘ軸は左右、ｙ軸は上下、ｚ軸は奥行きを表しており今回Vector2で出したrandDestinationのx軸は左右、y軸は奥行きを表しているのでVector3型で代入する際にこのようになる
    }

    public void SetDestination(Vector3 position)//Vector３型のpositionを用いてメソッドを使用
    {
        destination = position;//このpositonを目的地を定める
    }

    public Vector3 GetDestination()//destination変数はprivateで作っているので参照できないため、ここで参照できるようにする
    {
        return destination;//destinationを戻り値とする
    }
}
