using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinButtons : MonoBehaviour
{
    public GameLogic gm;

    public void EnterNumber(string number)
    {
        if (string.IsNullOrEmpty(gm.loginChatOneInput) && string.IsNullOrEmpty(gm.loginChatTwoInput) && string.IsNullOrEmpty(gm.loginChatThreeInput))
        {
            gm.loginChatOne.text += number;
        }
        if (!string.IsNullOrEmpty(gm.loginChatOneInput) && string.IsNullOrEmpty(gm.loginChatTwoInput) && string.IsNullOrEmpty(gm.loginChatThreeInput))
        {
            gm.loginChatTwo.text += number;
        }
        if (!string.IsNullOrEmpty(gm.loginChatTwoInput) && string.IsNullOrEmpty(gm.loginChatThreeInput))
        {
            gm.loginChatThree.text += number;
        }
    }
}
