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

    private GameObject bullet;

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
                GenerateBullet();

                timer = 0f;
            }


        }
    }

    private void GenerateBullet()
    {
        bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);

        rbBullet = bullet.GetComponent<Rigidbody>();

        rbBullet.AddForce(bullet.transform.forward * shotspeed);

        bullet.transform.Rotate(90, 0, 0);

        Destroy(bullet, 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
            Destroy(bullet);

    }
}
