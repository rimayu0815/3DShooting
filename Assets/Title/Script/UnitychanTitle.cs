using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanTitle : MonoBehaviour
{

    private Animator anim;

    //public bool weaponAdjust;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()  
    {
        //if(anim.GetCurrentAnimatorStateInfo(0).IsName("TitleIdleGun") == false)
        //{
        //    anim.SetBool("Title", true);
        //    Debug.Log("a");
        //    weaponAdjust = false;

        //}

        //if (anim.GetCurrentAnimatorStateInfo(0).IsName("TitleIdleGun") == true)
        //{
        //    Debug.Log("b");
        //    anim.SetBool("Title", false);
        //    weaponAdjust = true;
        //}

    }
}
