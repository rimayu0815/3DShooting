using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageColor : MonoBehaviour
{
    //private MeshRenderer mr;

    private Color color;
    // Start is called before the first frame update
    void Start()
    {
        //mr = GetComponent<MeshRenderer>();
        //mr.material.color = mr.material.color - new Color32(0, 0, 0, 255);
        //Debug.Log(mr.material.color);

        color = gameObject.GetComponent<Renderer>().material.color;
        color.a = 1.0f;
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
