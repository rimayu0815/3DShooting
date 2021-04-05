using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    [SerializeField]
    private Image greenGauge;

    //[SerializeField]
    //private Image redGauge;

    [SerializeField]
    private Sprite greenSprite;

    [SerializeField]
    private Sprite redSprite;

    [SerializeField]
    private float playerMaxHP;

    [SerializeField]
    private float damege;

    [SerializeField]
    private GameObject playerHPGauge;

    //private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreasePlayerHP()
    {
        if(greenGauge.fillAmount>0.0f)
        {
            greenGauge.fillAmount -= damege / playerMaxHP;
        }
        if(greenGauge.fillAmount <=0.5f)
        {
            greenGauge.sprite = redSprite;
        }
        if(greenGauge.fillAmount <= 0.0f)
        {
            Destroy(playerHPGauge, 1.0f);
        }
    }
}
