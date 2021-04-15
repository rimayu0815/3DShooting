using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Rigidbody rbBullet;

    [SerializeField]
    private GameObject BulletPrefab;

    public float shotspeed;

    [SerializeField]
    private Animator animator;

    private GameObject bullet;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateBullet()//銃弾を作成
    {
        bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);//銃弾を生成

        rbBullet = bullet.GetComponent<Rigidbody>();//物理演算追加

        rbBullet.AddForce(bullet.transform.forward * shotspeed);//前方へと飛ばす

        bullet.transform.Rotate(90, 0, 0);//傾けて銃弾の向きを調整する

        Destroy(bullet, 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(bullet);

    }
}

