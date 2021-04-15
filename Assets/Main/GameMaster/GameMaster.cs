using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    private GameObject player;

    public bool gameOver = false;


    [SerializeField]
    private GameObject mobHPGauge;

    private GameObject mob;

    [SerializeField]
    private float mobMaxHP;
    [SerializeField]
    private Image greenMobGauge;

    //[SerializeField]
    //private Image redGauge;

    [SerializeField]
    private Sprite greenMobSprite;

    [SerializeField]
    private Sprite redMobSprite;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("unitychan");
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

            player.SetActive(false);

            Invoke("GoToGameOver", 1.5f);

            gameOver = true;
        }
    }

    public void DecreaseMobHP()
    {
        if (greenMobGauge.fillAmount > 0.0f)
        {
            greenMobGauge.fillAmount -= damege / mobMaxHP;
        }
        if (greenMobGauge.fillAmount <= 0.5f)
        {
            greenMobGauge.sprite = redMobSprite;
        }
        if (greenMobGauge.fillAmount <= 0.0f)
        {
            Destroy(mobHPGauge, 1.0f);

            player.SetActive(false);

            //Invoke("GoToGameOver", 1.5f);

            //gameOver = true;
        }
    }

        void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
