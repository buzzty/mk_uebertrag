using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinButtonsQuiz : MonoBehaviour
{
    public GameLogic gm;

    public void EnterNumber(string number)
    {
        if (string.IsNullOrEmpty(gm.loginOneInput) && string.IsNullOrEmpty(gm.loginTwoInput) && string.IsNullOrEmpty(gm.loginThreeInput) && string.IsNullOrEmpty(gm.loginFourInput))
        {
            gm.loginOne.text += number;
        }
        if (!string.IsNullOrEmpty(gm.loginOneInput) && string.IsNullOrEmpty(gm.loginTwoInput) && string.IsNullOrEmpty(gm.loginThreeInput) && string.IsNullOrEmpty(gm.loginFourInput))
        {
            gm.loginTwo.text += number;
        }
        if (!string.IsNullOrEmpty(gm.loginTwoInput) && string.IsNullOrEmpty(gm.loginThreeInput) && string.IsNullOrEmpty(gm.loginFourInput))
        {
            gm.loginThree.text += number;
        }
        if (!string.IsNullOrEmpty(gm.loginThreeInput) && string.IsNullOrEmpty(gm.loginFourInput))
        {
            gm.loginFour.text += number;
        }
    }
}
