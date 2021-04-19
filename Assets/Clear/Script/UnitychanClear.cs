using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanClear: MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private Clear clearDesu;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("WIN00") == false &&clearDesu.clear == true)
        {
            anim.SetBool("Clear", true);

        }
    }
}
