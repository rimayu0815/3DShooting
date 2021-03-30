﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private CharacterController enemyController;//キャラクターのコントローラー

    private Animator animator;//アニメーター

    private Vector3 destination;//目的地

    [SerializeField]
    private float walkSpeed = 1.0f;//歩くスピード

    private Vector3 velocity;//速度

    private Vector3 direction;//方向

    private bool arrived = false;//目的地に到着したかを判断

    private SetPosition setPosition;//SetPosition スクリプトを参照するために

    [SerializeField]
    private float waitTime = 5f;//待機時間

    private float elapsedTime;//経過時間


    // Start is called before the first frame update
    void Start()
    {
        enemyController = GetComponent<CharacterController>();//コントローラーを取得

        animator = GetComponent<Animator>();//アニメーターを取得

        setPosition = GetComponent<SetPosition>();//SetPositionスクリプトの値を取得

        setPosition.CreateRandomPosition();//SetPositionスクリプトのCreateRandomPositionメソッドを使用

        destination = setPosition.GetDestination();//SetPositionスクリプトのGetDestinationメソッドを使用して、destinationに値を代入

        velocity = Vector3.zero;//速度を０にする

        elapsedTime = 0f;//経過時間を０にする
    }

    // Update is called once per frame
    void Update()
    {
        if (arrived == false)//到着してなかったら
        {
            if (enemyController.isGrounded)//もしコントローラーが地面に接してたら
            {
                velocity = Vector3.zero;//速度を０にする

                animator.SetFloat("Speed", 2.0f);//アニメーターのSetFloatメソッドを使用し、アニメーションのSpeedを2で動かす

                direction = (destination - transform.position).normalized;//目的地から今いる場所を引いて、進む方向を決める

                transform.LookAt(new Vector3(destination.x, transform.position.y, destination.z));//目的地の方向を向く

                velocity = direction * walkSpeed;//速度を定める

                Debug.Log(destination);
            }

            velocity.y += Physics.gravity.y * Time.deltaTime;//時間経過に応じてｙ軸を調整
            enemyController.Move(velocity * Time.deltaTime);//Moveメソッドを使用して時間経過に応じて移動

            if (Vector3.Distance(transform.position, new Vector3(destination.x, transform.position.y, destination.z)) < 0.5f)//目的地までの距離が0.5未満になったら
            {
                arrived = true;//到着した判定にする

                animator.SetFloat("Speed", 0.0f);//アニメーションのSpeedを０にする
            }

            elapsedTime += Time.deltaTime;//経過時間をはかる


            if (elapsedTime > waitTime)//経過時間が待ち時間を超えたら
            {
                setPosition.CreateRandomPosition();//ランダムに位置を選出
                
                destination = setPosition.GetDestination();//目的と定める

                arrived = false;//到着していない判定に戻して

                elapsedTime = 0f;//経過時間を０にする

            }
        }

    }

}
