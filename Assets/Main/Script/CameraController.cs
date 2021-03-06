using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;

    [SerializeField]
    private GameObject uni;

    [SerializeField]
    private Camera mainCamera;

    [SerializeField]
    private Camera fpsCamera;

    [SerializeField]
    private GameMaster gameMaster;

    public bool mainGun = true;//銃が映るように

    // Start is called before the first frame update
    void Start()
    {
        uni = GameObject.Find("unitychan");

        offset = transform.position - uni.transform.position;

        mainCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(uni != null)
        {
            transform.position = uni.transform.position + offset;
        }
        
        if(gameMaster.gameOver == true)
        {
            fpsCamera.enabled = false;

            mainCamera.enabled = true;
        }

        cameraChange();
    }

    public void cameraChange()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            if (fpsCamera.enabled == true)
            {
                fpsCamera.enabled = false;

                mainCamera.enabled = true;

                mainGun = false;
            }
            else if(mainCamera.enabled == true)
            {
                mainCamera.enabled = false;

                fpsCamera.enabled = true;

                mainGun = true;
            }
        }

    }
}
