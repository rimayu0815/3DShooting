using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPositionAdjust : MonoBehaviour
{
    private Vector3 weaponPos;
    private float x = -0.01f; //武器の位置をダブル型で入れる
    private float y = -0.05f;
    private float z = 0.004f;

    private Vector3 angle;//角度を調整

    private bool weapon;

    // Start is called before the first frame update
    void Start()
    {
        weaponPos= this.gameObject.transform.position;

        //angle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)　&&　weapon ==false)
        {
            weapon = true;

            weaponPos = new Vector3( x, y, z);
            Debug.Log("動く");

            //transform.eulerAngles = new Vector3(0,120, 0);

            transform.Rotate(0, 30, 0);

            Debug.Log(transform.eulerAngles);

            return;
        }
        else if(Input.GetKeyDown(KeyCode.G) && weapon == true)
        {
            weapon = false;

            transform.Rotate(0, -30, 0);
            Debug.Log("戻る");
        }
    }
}
