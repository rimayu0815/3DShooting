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



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GenerateBullet()
    {
        GameObject bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);

        rbBullet = bullet.GetComponent<Rigidbody>();

        rbBullet.AddForce(bullet.transform.forward * shotspeed);

        bullet.transform.Rotate(90, 0, 0);

        Destroy(bullet, 3.0f);
    }
}

