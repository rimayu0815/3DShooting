using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public GameObject player;

    public bool enterPlayer;

    private EnemyMove enemyMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)//範囲内に入ったら
    {


        if (col.gameObject.tag == "Player")//プレイヤーのtagがついてるオブジェクトが入ったら
        {
            enterPlayer = true;

            player = col.gameObject;//そのオブジェクトをplayerにいれる、上記のtransform.LookAtで使うため

            //velocity = Vector3.zero;//速度を０にする、アニメーションの切り替えの際スムーズにするため　下も同様

            //animator.SetFloat("Speed", 0.0f);//アニメーションのSpeedを０にする、上と同様

            //arrived = true;//到着したことにして止まってもらうため

            //searched = true;//これでelapsedTimeが超えてもif分を動かさないため　、動こうとするのを止めておくため

        }

        //if (col.gameObject.tag == "FPSCamera")　//もしかしたらカメラの向きを見ればいけるかも　やっぱり傾けないと駄目でした
        //{
        //    fpsCamera = col.gameObject;
        //}

        //if (col.CompareTag("Bullet"))
        //{
        //    Debug.Log("通過");

        //    gameMaster.DecreaseMobHP();


        //}

    }

    private void OnTriggerExit(Collider col)//範囲外に出て行ったら
    {


        if (col.gameObject.tag == "Player")//要らないかもだけどとりあえずif文、これ以下全てリセットして元の状態に戻す
        {
            //velocity = Vector3.zero;//速度を０にする

            //animator.SetFloat("Speed", 0.0f);//アニメーションのSpeedを０にする

            //arrived = false;

            //searched = false;

            //player = null;

            enterPlayer = false;

            StartCoroutine(enemyMove.ShotCancel());//撃つの中止


            //fpsCamera = null;//無理でした
        }
    }
}
