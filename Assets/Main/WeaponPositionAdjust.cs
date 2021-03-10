using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPositionAdjust : MonoBehaviour
{
    private Vector3 tran;
    private double x = -0.01; //武器の位置をダブル型で入れる
    private double y = -0.05;
    private double z = 0.004;

    private Vector3 angle;//角度を調整

    // Start is called before the first frame update
    void Start()
    {
        tran = this.gameObject.transform.position;

        angle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            //tran = new Vector3( x, y, z);
            Debug.Log(tran);

            transform.eulerAngles = new Vector3(0,120, 0);

            Debug.Log(transform.eulerAngles);

        }
    }
}
