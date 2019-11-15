using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoppingBoard : MonoBehaviour
{
    float Timer1;
    float Timer2;
    public static bool  isChopping1;
    public static bool isChopping2;
    float choppingTime;
    public static bool isCooked1;
    public static bool isCooked2;
    public static int menuNumber;

    private void Start()
    {
        
        isChopping1 = isChopping2 = false;
        choppingTime = 4f;
        Timer1 = Timer2 = 4f;
        isCooked2 = isCooked1 = false;
        menuNumber = 0;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            if (Input.GetKeyDown("x") && !isChopping1)
            {
                //Debug.Log("x is pressed");
                CreateMenuNumberA();
                if (AddToMenuA.is1Apk || AddToMenuA.is1Bpk || AddToMenuA.is1Cpk || AddToMenuA.is1Dpk || AddToMenuA.is1Epk || AddToMenuA.is1Fpk)
                {
                    //Debug.Log("Menu is Checked");
                    isChopping1 = true;
                    //Debug.Log("isChopping1 status " + isChopping1);
                    Player1Movement.speed = 0f;
                    //Debug.Log("speed is" + Player1Movement.speed);
                    AddToMenuA.is1Apk = AddToMenuA.is1Bpk = AddToMenuA.is1Cpk = AddToMenuA.is1Dpk = AddToMenuA.is1Epk = AddToMenuA.is1Fpk = false;
                    
                    
                }
            }
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            if (Input.GetKeyDown("m") && !isChopping1)
            {
                CreateMenuNumberB();
                if (AddToMenuA.is2Apk || AddToMenuA.is2Bpk || AddToMenuA.is2Cpk || AddToMenuA.is2Dpk || AddToMenuA.is2Epk || AddToMenuA.is2Fpk)
                {
                    isChopping2 = true;
                    Player2Movement.speed = 0f;
                    AddToMenuA.is2Apk = AddToMenuA.is2Bpk = AddToMenuA.is2Cpk = AddToMenuA.is2Dpk = AddToMenuA.is2Epk = AddToMenuA.is2Fpk = false;
                    

                }
            }
        }
    }
    private void Update()
    {
        if (isChopping1)
        {
            IsChopping1();
        }
        if (isChopping2)
        {
            IsChopping2();
        }
        if (!isChopping1)
        {
            Timer1 = 4f;
        }
        if (!isChopping2)
        {
            Timer2 = 4f;
        }
        Debug.Log(Timer1);
    }
    void IsChopping1()
    {
        Timer1 -= Time.deltaTime;
        Debug.Log("Waiting");
        if (Timer1 < 0f)
        {
            isChopping1 = false;
            Player1Movement.speed = 5f;
            isCooked1 = true;
        }
    }
    void IsChopping2()
    {
        Timer2 -= Time.deltaTime;

        if (Timer2 <= 0f)
        {
            isChopping2 = false;
            Player2Movement.speed = 5f;
            isCooked2 = true;

        }
    }
    void CreateMenuNumberA()
    {
        if (AddToMenuA.is1Apk)
        {
            Player1Movement.menuNumer = 1;   
        }
        if (AddToMenuA.is1Bpk)
        {
            Player1Movement.menuNumer = 2;
        }
        if (AddToMenuA.is1Cpk)
        {
            Player1Movement.menuNumer = 3;
        }
        if (AddToMenuA.is1Dpk)
        {
            Player1Movement.menuNumer = 4;
        }
        if (AddToMenuA.is1Epk)
        {
            Player1Movement.menuNumer = 5;
        }
        if (AddToMenuA.is1Fpk)
        {
            Player1Movement.menuNumer = 6;
        }
        if (AddToMenuA.is1Apk && AddToMenuA.is1Bpk)
        {
            Player1Movement.menuNumer = 7;
        }
        if (AddToMenuA.is1Apk && AddToMenuA.is1Cpk)
        {
            Player1Movement.menuNumer = 8;
        }
        if (AddToMenuA.is1Apk && AddToMenuA.is1Dpk)
        {
            Player1Movement.menuNumer = 9;
        }
        if (AddToMenuA.is1Apk && AddToMenuA.is1Epk)
        {
            Player1Movement.menuNumer = 10;
        }
        if (AddToMenuA.is1Apk && AddToMenuA.is1Fpk)
        {
            Player1Movement.menuNumer = 11;
        }
        if (AddToMenuA.is1Bpk && AddToMenuA.is1Cpk)
        {
            Player1Movement.menuNumer = 12;
        }
        if (AddToMenuA.is1Bpk && AddToMenuA.is1Dpk)
        {
            Player1Movement.menuNumer = 13;
        }
        if (AddToMenuA.is1Bpk && AddToMenuA.is1Epk)
        {
            Player1Movement.menuNumer = 14;
        }
        if (AddToMenuA.is1Bpk && AddToMenuA.is1Fpk)
        {
            Player1Movement.menuNumer = 15;
        }
        if (AddToMenuA.is1Cpk && AddToMenuA.is1Dpk)
        {
            Player1Movement.menuNumer = 16;
        }
        if (AddToMenuA.is1Cpk && AddToMenuA.is1Epk)
        {
            Player1Movement.menuNumer = 17;
        }
        if (AddToMenuA.is1Cpk && AddToMenuA.is1Fpk)
        {
            Player1Movement.menuNumer = 18;
        }
        if (AddToMenuA.is1Dpk && AddToMenuA.is1Epk)
        {
            Player1Movement.menuNumer = 19;
        }
        if (AddToMenuA.is1Dpk && AddToMenuA.is1Fpk)
        {
            Player1Movement.menuNumer = 20;
        }
        if (AddToMenuA.is1Epk && AddToMenuA.is1Fpk)
        {
            Player1Movement.menuNumer = 21;
        }

    }
    void CreateMenuNumberB()
    {
        if (AddToMenuA.is2Apk)
        {
            Player2Movement.menuNumer = 1;
        }
        if (AddToMenuA.is2Bpk)
        {
            Player2Movement.menuNumer = 2;
        }
        if (AddToMenuA.is2Cpk)
        {
            Player2Movement.menuNumer = 3;
        }
        if (AddToMenuA.is2Dpk)
        {
            Player2Movement.menuNumer = 4;
        }
        if (AddToMenuA.is2Epk)
        {
            Player2Movement.menuNumer = 5;
        }
        if (AddToMenuA.is2Fpk)
        {
            Player2Movement.menuNumer = 6;
        }
        if (AddToMenuA.is2Apk && AddToMenuA.is2Bpk)
        {
            Player2Movement.menuNumer = 7;
        }
        if (AddToMenuA.is2Apk && AddToMenuA.is2Cpk)
        {
            Player2Movement.menuNumer = 8;
        }
        if (AddToMenuA.is2Apk && AddToMenuA.is2Dpk)
        {
            Player2Movement.menuNumer = 9;
        }
        if (AddToMenuA.is2Apk && AddToMenuA.is2Epk)
        {
            Player2Movement.menuNumer = 10;
        }
        if (AddToMenuA.is2Apk && AddToMenuA.is2Fpk)
        {
            Player2Movement.menuNumer = 11;
        }
        if (AddToMenuA.is2Bpk && AddToMenuA.is2Cpk)
        {
            Player2Movement.menuNumer = 12;
        }
        if (AddToMenuA.is2Bpk && AddToMenuA.is2Dpk)
        {
            Player2Movement.menuNumer = 13;
        }
        if (AddToMenuA.is2Bpk && AddToMenuA.is2Epk)
        {
            Player2Movement.menuNumer = 14;
        }
        if (AddToMenuA.is2Bpk && AddToMenuA.is2Fpk)
        {
            Player2Movement.menuNumer = 15;
        }
        if (AddToMenuA.is2Cpk && AddToMenuA.is2Dpk)
        {
            Player2Movement.menuNumer = 16;
        }
        if (AddToMenuA.is2Cpk && AddToMenuA.is2Epk)
        {
            Player2Movement.menuNumer = 17;
        }
        if (AddToMenuA.is2Cpk && AddToMenuA.is2Fpk)
        {
            Player2Movement.menuNumer = 18;
        }
        if (AddToMenuA.is2Dpk && AddToMenuA.is2Epk)
        {
            Player2Movement.menuNumer = 19;
        }
        if (AddToMenuA.is2Dpk && AddToMenuA.is2Fpk)
        {
            Player2Movement.menuNumer = 20;
        }
        if (AddToMenuA.is2Epk && AddToMenuA.is2Fpk)
        {
            Player2Movement.menuNumer = 21;
        }

    }
}
