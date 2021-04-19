using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    public bool clear;

    // Start is called before the first frame update
    void Start()
    {
        clear = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneChange();
        }
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("Title");

        clear = false;
    }
}
