using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAdjustTitle: MonoBehaviour
{
    //private Vector3 angle;//角度を調整

    private Vector3 weaponPos;
    private float x = -0.01f; //武器の位置をダブル型で入れる
    private float y = -0.05f;
    private float z = 0.004f;

    private bool weapon;


    [SerializeField]
    private UnitychanTitle unitychanTitle;

    // Start is called before the first frame update
    void Start()
    {
        //angle = transform.eulerAngles;

        //weaponPos = this.gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        //if (unitychanTitle.weaponAdjust == false)
        //{
        //    weaponPos = this.gameObject.transform.position;

        //    transform.position = weaponPos;


        //    //    Debug.Log("戻る");

        //    //    //angle.y = 30.0f;
        //    //    Debug.Log("止まる");
        //}
        //if (unitychanTitle.weaponAdjust == true)
        //{

        //    weaponPos = new Vector3(x, y, z);

        //    transform.Rotate(0, 20, 0);

        //    //return;
        //    Debug.Log("動く");//動く


        //    //angle.y += 20.0f;


        //    if (transform.rotation.y < 20.0f)
        //    {
        //        transform.rotation = Quaternion.Euler(0.0f,20.0f,0.0f);

        //        Debug.Log("動いてるのか");//動く
        //    }

        //    //transform.eulerAngles = new Vector3(0, angle.y, 0);
        //}


    }
}
