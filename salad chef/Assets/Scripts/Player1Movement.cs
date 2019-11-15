using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Movement : MonoBehaviour
{
    public static float speed;
    public Text player1Text;
    public static int menuNumer;

    float powerUpTime;
    bool isUpGradePower;
    public Text poweupText;
    public Slider mySlider;
    float sliderTimer;

    public static int score;
    public Text Score;

    public static bool isA, isB, isC, isD, isE, isF;
    
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
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        Vector3 playerPosition = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 sliderPosition = new Vector3(playerPosition.x, playerPosition.y + 20f, playerPosition.z);
        player1Text.transform.position = playerPosition;
        mySlider.transform.position = sliderPosition;
        if (CustomerBehaviour.isP1CustomerSatisfied)
        {
            player1Text.text = "";
            CustomerBehaviour.isP1CustomerSatisfied = false;
            Debug.Log("Yes Empty it ");
            AddToMenuA.is1Apk = AddToMenuA.is1Bpk = AddToMenuA.is1Cpk = AddToMenuA.is1Dpk = AddToMenuA.is1Epk = AddToMenuA.is1Fpk = false;
            ChoppingBoard.isCooked1 = false;
            isA = isB = isC = isD = isE = isF = false;

        }
        if (CustomerBehaviour.isP1UpGrade)
        {
            isUpGradePower = true;
            CustomerBehaviour.isP1UpGrade = false;
            Debug.Log("Player1Movement UpGrade Check");
        }
        if (isUpGradePower)
        {
            poweupText.gameObject.SetActive(true);
            if (Input.GetKeyDown("f"))
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
        else if(!ChoppingBoard.isChopping1)
        {
            speed = 5f;
        }
        if (!isUpGradePower)
        {
            poweupText.gameObject.SetActive(false);
        }
        if (ChoppingBoard.isChopping1)
        {
            sliderTimer += Time.deltaTime;
            mySlider.value = (sliderTimer / 4);
        }
        if (ChoppingBoard.isCooked1)
        {
            sliderTimer = 0f;
            mySlider.value = 0f;
        }
    }
    
    
}
