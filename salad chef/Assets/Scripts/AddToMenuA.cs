using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToMenuA : MonoBehaviour
{
    public Text player1Text;
    public Text player2Text;
    

    public static bool is1Apk,is1Bpk,is1Cpk,is1Dpk,is1Epk,is1Fpk;
    public static bool is2Apk, is2Bpk, is2Cpk, is2Dpk, is2Epk, is2Fpk;

    private void Start()
    {
     
        is1Apk = is1Bpk = is1Cpk = is1Dpk = is1Epk = is1Fpk = false;
        is2Apk = is2Bpk = is2Cpk = is2Dpk = is2Epk = is2Fpk = false;
        //player1Text.text = "";
        //player2Text.text = "";

    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.CompareTag("a"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown("z"))
                {
                    Player1Movement.isA = true;
                    if (!is1Apk && !ChoppingBoard.isCooked1)
                    {
                        player1Text.text = player1Text.text + ",a";
                        //Debug.Log("Player 1 A is " + Player1Movement.isA);
                        is1Apk = true;
                    }
                }

            }


            if (collision.gameObject.CompareTag("Player2"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown(","))
                {
                    Player2Movement.isA = true;
                    if (!is2Apk && !ChoppingBoard.isCooked2)
                    {
                        player2Text.text = player2Text.text+ ",a";
                        //Debug.Log("Player 2 A is" + Player2Movement.isA);
                        is2Apk = true;
                    }
                }
            }
        }

        if (gameObject.CompareTag("b"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown("z"))
                {
                    Player1Movement.isB = true;
                    if (!is1Bpk && !ChoppingBoard.isCooked1)
                    {
                        player1Text.text = player1Text.text + ",b";
                        //Debug.Log("Player 1 A is " + Player1Movement.isA);
                        is1Bpk = true;
                    }
                }
            }


            if (collision.gameObject.CompareTag("Player2"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown(","))
                {
                    Player2Movement.isB = true;
                    if (!is2Bpk && !ChoppingBoard.isCooked2)
                    {
                        player2Text.text = player2Text.text + ",b";
                        //Debug.Log("Player 2 A is" + Player2Movement.isA);
                        is2Bpk = true;
                    }
                }
            }
        }

        if (gameObject.CompareTag("c"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown("z"))
                {
                    Player1Movement.isC = true;
                    if (!is1Cpk && !ChoppingBoard.isCooked1)
                    {
                        player1Text.text = player1Text.text + ",c";
                        //Debug.Log("Player 1 A is " + Player1Movement.isA);
                        is1Cpk = true;
                    }
                }
            }


            if (collision.gameObject.CompareTag("Player2"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown(","))
                {
                    Player2Movement.isC = true;
                    if (!is2Cpk && !ChoppingBoard.isCooked2)
                    {
                        player2Text.text = player2Text.text + ",c";
                        //Debug.Log("Player 2 A is" + Player2Movement.isA);
                        is2Cpk = true;
                    }
                }
            }
        }

        if (gameObject.CompareTag("d"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown("z"))
                {
                    Player1Movement.isD = true;
                    if (!is1Dpk && !ChoppingBoard.isCooked1)
                    {
                        player1Text.text = player1Text.text + ",d";
                        //Debug.Log("Player 1 A is " + Player1Movement.isA);
                        is1Dpk = true;
                    }
                }
            }


            if (collision.gameObject.CompareTag("Player2"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown(","))
                {
                    Player2Movement.isD = true;
                    if (!is2Dpk && !ChoppingBoard.isCooked2)
                    {
                        player2Text.text = player2Text.text + ",d";
                        //Debug.Log("Player 2 A is" + Player2Movement.isA);
                        is2Dpk = true;
                    }
                }
            }
        }

        if (gameObject.CompareTag("e"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown("z"))
                {
                    Player1Movement.isE = true;
                    if (!is1Epk && !ChoppingBoard.isCooked1)
                    {
                        player1Text.text = player1Text.text + ",e";
                        //Debug.Log("Player 1 A is " + Player1Movement.isA);
                        is1Epk = true;
                    }
                }
            }


            if (collision.gameObject.CompareTag("Player2"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown(","))
                {
                    Player2Movement.isE = true;
                    if (!is2Epk && !ChoppingBoard.isCooked2)
                    {
                        player2Text.text = player2Text.text + ",e";
                        //Debug.Log("Player 2 A is" + Player2Movement.isA);
                        is2Epk = true;
                    }
                }
            }
        }

        if (gameObject.CompareTag("f"))
        {
            if (collision.gameObject.CompareTag("Player1"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown("z"))
                {
                    Player1Movement.isF = true;
                    if (!is1Fpk && !ChoppingBoard.isCooked1)
                    {
                        player1Text.text = player1Text.text + ",f";
                        //Debug.Log("Player 1 A is " + Player1Movement.isA);
                        is1Fpk = true;
                    }
                }
            }


            if (collision.gameObject.CompareTag("Player2"))
            {
                //Debug.Log("Z pressed");
                if (Input.GetKeyDown(","))
                {
                    Player2Movement.isF = true;
                    if (!is2Fpk && !ChoppingBoard.isCooked2)
                    {
                        player2Text.text = player2Text.text + ",f";
                        //Debug.Log("Player 2 A is" + Player2Movement.isA);
                        is2Fpk = true;
                    }
                }
            }
        }
    }
    public void P1EmptyYourPoket()
    {
        
        

    }
    public void P2EmptyYourPoket()
    {
        is2Apk = is2Bpk = is2Cpk = is2Dpk = is2Epk = is2Fpk = false;
        ChoppingBoard.isCooked2 = false;
        Player2Movement.isA = Player2Movement.isB = Player2Movement.isC = Player2Movement.isD = Player2Movement.isE = Player2Movement.isF = false;
    }


}
