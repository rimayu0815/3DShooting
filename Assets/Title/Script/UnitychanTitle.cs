using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanTitle : MonoBehaviour
{

    private Animator anim;

    public bool weaponAdjust;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()   //思い通りに動いてる
    {
        if(anim.GetCurrentAnimatorStateInfo(0).IsName("TitleIdle") == false)
        {
            anim.SetBool("Title", true);
            Debug.Log("動いた");
        }

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("TitleIdle") == true)
        {
            weaponAdjust = true;
        }
        else if(anim.GetCurrentAnimatorStateInfo(0).IsName("Idle") == true)
        {
            weaponAdjust = false;
        }
    }
}
