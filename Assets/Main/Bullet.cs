using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rbBullet;

    [SerializeField]
    private GameObject BulletPrefab;

    public float shotspeed;

    private float timer;

    public float shotTimer;

    [SerializeField]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1)&& animator.GetCurrentAnimatorStateInfo(0).IsName("AutoShot") == true)
        {
            timer += Time.deltaTime;

            if(timer>shotTimer)
            {
                GeneratBullet();

                timer = 0f;
            }


        }
    }

    private void GeneratBullet()
    {
        GameObject bullet = Instantiate(BulletPrefab, transform.position, BulletPrefab.transform.rotation);

        rbBullet = bullet.GetComponent<Rigidbody>();

        rbBullet.AddForce(transform.forward * shotspeed);

        Destroy(bullet, 3.0f);
    }
}
