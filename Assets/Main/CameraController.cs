using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;

    [SerializeField]
    private GameObject uni;



    // Start is called before the first frame update
    void Start()
    {
        uni = GameObject.Find("unitychan");

        offset = transform.position - uni.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(uni != null)
        {
            transform.position = uni.transform.position + offset;
        }
    }
}
