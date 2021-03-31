using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDirection : MonoBehaviour
{
    private GameObject target;

    private bool searched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(searched == true)
        {
            transform.LookAt(target.transform);
        }
    }

    private void OnTriggerEnter(Collider col)
    {


        if (col.gameObject.tag == "Player")
        {
            target = col.gameObject;

            searched = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {


        if (col.gameObject.tag == "Player")
        {

            searched = false;

            target = null;

        }
    }
}
