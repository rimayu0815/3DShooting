using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;

    [SerializeField]
    private GameObject unitychan;



    // Start is called before the first frame update
    void Start()
    {
        unitychan = GameObject.Find("unitychan");

        offset = transform.position - unitychan.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(unitychan != null)
        {
            transform.position = unitychan.transform.position + offset;
        }
    }
}
