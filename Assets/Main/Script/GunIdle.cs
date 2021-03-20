using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunIdle : MonoBehaviour
{
    private Animator animator;

    [SerializeField]
	public UnityChan.UnityChanControlScriptWithRgidBody uni;

    [SerializeField]
    private Bullet bullet;

     private float timer;


    // Start is called before the first frame updates
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            //一つ目の分岐
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("IdleGun") == false )//パラメーター
            {
                animator.SetBool("IdleGun", true);
                Debug.Log(" True1 で通過");
            }

            //二つ目の分岐
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("WalkFrontShoot") == true)
            {
                animator.SetBool("IdleGun", false);
                Debug.Log(" false で通過");
            }
            else if(animator.GetCurrentAnimatorStateInfo(0).IsName("IdleGun") == true)
            {
                animator.SetBool("IdleGun", false);
                Debug.Log(" false1 で通過");
            }

        }

        if(Input.GetMouseButton(1))
        {
            timer += Time.deltaTime;

            if(animator.GetCurrentAnimatorStateInfo(0).IsName("AutoShot") == false && timer >1f)
            {
                animator.SetBool("GunFire", true);
                Debug.Log("true3で通過");
            }

            //else if(animator.GetCurrentAnimatorStateInfo(0).IsName("AutoShot") == true)
            //{
            //    animator.SetBool("GunFire", false);
            //    Debug.Log("false2で通過");
            //}
        }
        if(Input.GetMouseButtonUp(1))
        {
            timer = 0f;

            if (animator.GetCurrentAnimatorStateInfo(0).IsName("AutoShot") == true)
            {
                animator.SetBool("GunFire", false);
            }
        }

    }
        
}