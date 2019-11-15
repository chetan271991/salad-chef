using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Movement : MonoBehaviour
{
    public static float speed;
    public static bool isA, isB, isC, isD, isE, isF;
    public Text player2Text;
    public static int menuNumer;

    float sliderTimer;
    public Slider mySlider;
    float powerUpTime;
    bool isUpGradePower;
    public Text poweupText;

    public static int score;
    public Text Score;
    void Start()
    {
        isA = isB = isC = isD = isE = isF = false;
        speed = 5f;
        menuNumer = 0;
        score = 0;
        isUpGradePower = false;
        powerUpTime = 0f;
        sliderTimer = 0f;
        poweupText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Score.text = score.ToString("0");
        if (Input.GetKey("i"))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey("k"))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey("j"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("l"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        Vector3 playerPosition = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 sliderPosition = new Vector3(playerPosition.x, playerPosition.y + 20f, playerPosition.z);
        player2Text.transform.position = playerPosition;
        mySlider.transform.position = sliderPosition;
        if (CustomerBehaviour.isP2CustomerSatisfied)
        {
            player2Text.text = "";
            CustomerBehaviour.isP2CustomerSatisfied = false;
            AddToMenuA.is2Apk = AddToMenuA.is2Bpk = AddToMenuA.is2Cpk = AddToMenuA.is2Dpk = AddToMenuA.is2Epk = AddToMenuA.is2Fpk = false;
            ChoppingBoard.isCooked2 = false;
            isA = isB = isC = isD = isE = isF = false;
        }
        if (CustomerBehaviour.isP2UpGrade)
        {
            isUpGradePower = true;
            CustomerBehaviour.isP2UpGrade = false;
        }
        if (isUpGradePower)
        {
            poweupText.gameObject.SetActive(true);
            if (Input.GetKeyDown("h"))
            {

                isUpGradePower = false;
                powerUpTime = 16f;
                
            }
        }
        if (powerUpTime >= 0)
        {
            speed = 10f;
            powerUpTime -= Time.deltaTime;
        }
        else if(!ChoppingBoard.isChopping2)
        {
            speed = 5f;
        }

        if (!isUpGradePower)
        {
            poweupText.gameObject.SetActive(false);
        }
        if (ChoppingBoard.isChopping2)
        {
            sliderTimer += Time.deltaTime;
            mySlider.value = (sliderTimer / 4);
        }
        if (ChoppingBoard.isCooked2)
        {
            sliderTimer = 0f;
            mySlider.value = 0f;
        }
    }
}
