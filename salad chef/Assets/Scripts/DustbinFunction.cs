using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DustbinFunction : MonoBehaviour
{
    public Text player1Text;
    public Text player2Text;
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            if (Input.GetKeyDown("v"))
            {
                ChoppingBoard.isCooked1 = AddToMenuA.is1Apk = AddToMenuA.is1Bpk = AddToMenuA.is1Cpk = AddToMenuA.is1Dpk = AddToMenuA.is1Epk = AddToMenuA.is1Fpk = false;
                Player1Movement.isA = Player1Movement.isB = Player1Movement.isC = Player1Movement.isD = Player1Movement.isE = Player1Movement.isF = false;
                player1Text.text = "";
            }
        }
        if (collision.gameObject.CompareTag("Player2")) {
            if (Input.GetKeyDown("b"))
            {
                ChoppingBoard.isCooked2 = AddToMenuA.is2Apk = AddToMenuA.is2Bpk = AddToMenuA.is2Cpk = AddToMenuA.is2Dpk = AddToMenuA.is2Epk = AddToMenuA.is2Fpk = false;
                Player2Movement.isA = Player2Movement.isB = Player2Movement.isC = Player2Movement.isD = Player2Movement.isE = Player2Movement.isF = false;
                player2Text.text = "";
            }
        }
    }
   
}
