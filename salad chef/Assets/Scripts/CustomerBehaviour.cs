using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CustomerBehaviour : MonoBehaviour
{
    float speed;
    float returnSpeed;
    public static bool isP1CustomerSatisfied;
    public static bool isP2CustomerSatisfied;
    public static bool isP1UpGrade;
    public static bool isP2UpGrade;
    int menuNumber;
    bool a, b, c, d, e, f, ab, ac, ad, ae, af, bc, bd, be, bf, ce, cd, cf, de, df, ef;
    public Text customerOrderText;
    float totalTime;
    float waitTime;
    bool returnCuatomer;
    SpriteRenderer spriteRenderer;
    float sliderTime = 30f;

    public Slider mySlider;


    // Start is called before the first frame update
    void Start()
    {
        speed = 1f;
        returnSpeed = 20f;
        isP1UpGrade = isP2UpGrade = false;
        menuNumber = Random.Range(1, 23);
        //menuNumber = 1;
        ChooseMenu();
        a = b = c = d = e = f = ab = ac = ad = ae = af = bc = bd = be = bf = ce = cd = cf = de = df = ef = false;
        totalTime = 30f;
        waitTime = 30f;
        returnCuatomer = false;
        isP1CustomerSatisfied = isP2CustomerSatisfied= false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y >= 4)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        

        Vector3 customerPosition = Camera.main.WorldToScreenPoint(transform.position);
        customerOrderText.transform.position = customerPosition;
        Vector3 sliderPosition = new Vector3(customerPosition.x, customerPosition.y + 20f, customerPosition.z);
        mySlider.transform.position = sliderPosition;
        waitTime -= Time.deltaTime;
        sliderTime -= Time.deltaTime;
        mySlider.value = (sliderTime/30);

        if (returnCuatomer)
        {
            //Debug.Log("Customer should go back");
            transform.Translate(Vector3.left * returnSpeed * Time.deltaTime);
            spriteRenderer.color = Color.green;
        }
        if(waitTime <= 0)
        {
            transform.Translate(Vector3.right * returnSpeed * Time.deltaTime);
            spriteRenderer.color = Color.red;
            
        }
    }
    void ChooseMenu()
    {
        switch (menuNumber)
        {
            case 1:
                a = true;
                customerOrderText.text = "a";
                break;
            case 2:
                b = true;
                customerOrderText.text = "b";
                break;
            case 3:
                c = true;
                customerOrderText.text = "c";
                break;
            case 4:
                d = true;
                customerOrderText.text = "d";
                break;
            case 5:
                e = true;
                customerOrderText.text = "e";
                break;
            case 6:
                f = true;
                customerOrderText.text = "f";
                break;
            case 7:
                ab = true;
                customerOrderText.text = "ab";
                break;
            case 8:
                ac = true;
                customerOrderText.text = "ac";
                break;
            case 9:
                ad = true;
                customerOrderText.text = "ad";
                break;
            case 10:
                ae = true;
                customerOrderText.text = "ae";
                break;
            case 11:
                af = true;
                customerOrderText.text = "af";
                break;
            case 12:
                bc = true;
                customerOrderText.text = "bc";
                break;
            case 13:
                bd = true;
                customerOrderText.text = "bd";
                break;
            case 14:
                be = true;
                customerOrderText.text = "be";
                break;
            case 15:
                bf = true;
                customerOrderText.text = "bf";
                break;
            case 16:
                cd = true;
                customerOrderText.text = "cd";
                break;
            case 17:
                ce = true;
                customerOrderText.text = "ce";
                break;
            case 18:
                cf = true;
                customerOrderText.text = "cf";
                break;
            case 19:
                de = true;
                customerOrderText.text = "de";
                break;
            case 20:
                df = true;
                customerOrderText.text = "df";
                break;
            case 21:
                ef = true;
                customerOrderText.text = "ef";
                break;


        }
    }
    
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            if (Input.GetKeyDown("c") && waitTime >= 0f)
            {
                //Debug.Log("C is pressed");
                if (menuNumber == Player1Movement.menuNumer && ChoppingBoard.isCooked1)
                {
                    //Debug.Log("Correct Menu");
                    Player1Movement.score += 10;
                    //Debug.Log("Total Score = " + Player1Movement.score);
                    ChoppingBoard.isCooked1 = false;
                    returnCuatomer = true;
                    
                    isP1CustomerSatisfied = true;
                    
                    if (waitTime>=(totalTime / 2))
                    {
                        Player1Movement.score += 5;
                       // Debug.Log("Total Score = " + Player1Movement.score);
                        isP1UpGrade = true;
                    }
                }
                else
                {
                    //Debug.Log("Incorrect Menu");
                    waitTime -= 4;
                    Player1Movement.score -= 5;
                    //Debug.Log("Total Score = " + Player1Movement.score);
                }
            }
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            if (Input.GetKeyDown("n") && waitTime >= 0f)
            {
                //Debug.Log("N is pressed");
                if (menuNumber == Player2Movement.menuNumer && ChoppingBoard.isCooked2)
                {
                    //Debug.Log("Correct Menu");
                    Player2Movement.score += 10;
                    //Debug.Log("Total Score = " + Player1Movement.score);
                    ChoppingBoard.isCooked2 = false;
                    returnCuatomer = true;
                    
                    isP2CustomerSatisfied = true;

                    if (waitTime>=(totalTime / 2))
                    {
                        Player2Movement.score += 5;
                        //Debug.Log("Total Score = " + Player2Movement.score);
                        isP2UpGrade = true;
                    }
                }
                else
                {
                    //Debug.Log("Incorrect Menu");
                    waitTime -= 4;
                    Player2Movement.score -= 5;
                    //Debug.Log("Total Score = " + Player2Movement.score);
                }
            }
        }
    }
    
}

                 

                 
                
            


        
