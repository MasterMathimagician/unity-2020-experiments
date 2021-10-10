using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* This is just a quick little puzzle game based on colour flipping, pressing a button will cause the colours to 
 * flip centered on the button pressed
 * 
 *       |  b1   b2   b3   |
 *       |  b4   b5   b6   |
 *       |  b7   b8   b9   |
 */

public class GameControllerButtonGame : MonoBehaviour
{
    public Color[] colours;

    public Image button1;
    public Image button2;
    public Image button3;

    public Image button4;
    public Image button5;
    public Image button6;

    public Image button7;
    public Image button8;
    public Image button9;

    public int shuffles = 5;

    private int[] buttonState;
   
    // Start is called before the first frame update
    void Start()
    {
        buttonState = new int[9];
        buttonState[0] = 0;
        buttonState[1] = 0;
        buttonState[2] = 0;
        buttonState[3] = 0;
        buttonState[4] = 0;
        buttonState[5] = 0;
        buttonState[6] = 0;
        buttonState[7] = 0;
        buttonState[8] = 0;

        shuffleButtons(shuffles);
    }

    private static void shuffleButtons(int shuffles) {

    }

    // affects buttons 1, 2 and 4
    public void pressButton1()
    {
        if (colours.Length>0)
        {
            buttonState[0] = (buttonState[0] + 1) % colours.Length;
            buttonState[1] = (buttonState[1] + 1) % colours.Length;
            buttonState[3] = (buttonState[3] + 1) % colours.Length;

            button1.color = colours[buttonState[0]];
            button2.color = colours[buttonState[1]];
            button4.color = colours[buttonState[3]];
        }

    }

    // affects buttons 1, 2 3 and 5
    public void pressButton2()
    {
        if (colours.Length > 0)
        {
            buttonState[0] = (buttonState[0] + 1) % colours.Length;
            buttonState[1] = (buttonState[1] + 1) % colours.Length;
            buttonState[2] = (buttonState[2] + 1) % colours.Length;
            buttonState[4] = (buttonState[4] + 1) % colours.Length;

            button1.color = colours[buttonState[0]];
            button2.color = colours[buttonState[1]];
            button3.color = colours[buttonState[2]];
            button5.color = colours[buttonState[4]];
        }
    }

    // affects buttons 2, 3 and 6
    public void pressButton3()
    {
        if (colours.Length > 0)
        {
            buttonState[1] = (buttonState[1] + 1) % colours.Length;
            buttonState[2] = (buttonState[2] + 1) % colours.Length;
            buttonState[5] = (buttonState[5] + 1) % colours.Length;

            button2.color = colours[buttonState[1]];
            button3.color = colours[buttonState[2]];
            button6.color = colours[buttonState[5]];
        }
    }

    // affects buttons 1, 4, 5 and 7
    public void pressButton4()
    {
        if (colours.Length > 0)
        {
            buttonState[0] = (buttonState[0] + 1) % colours.Length;
            buttonState[3] = (buttonState[3] + 1) % colours.Length;
            buttonState[4] = (buttonState[4] + 1) % colours.Length;
            buttonState[6] = (buttonState[6] + 1) % colours.Length;

            button1.color = colours[buttonState[0]];
            button4.color = colours[buttonState[3]];
            button5.color = colours[buttonState[4]];
            button7.color = colours[buttonState[6]];
        }
    }

    // affects buttons 2, 4, 5, 6 and 8
    public void pressButton5()
    {
        if (colours.Length > 0)
        {
            buttonState[1] = (buttonState[1] + 1) % colours.Length;
            buttonState[3] = (buttonState[3] + 1) % colours.Length;
            buttonState[4] = (buttonState[4] + 1) % colours.Length;
            buttonState[5] = (buttonState[5] + 1) % colours.Length;
            buttonState[7] = (buttonState[7] + 1) % colours.Length;

            button2.color = colours[buttonState[1]];
            button4.color = colours[buttonState[3]];
            button5.color = colours[buttonState[4]];
            button6.color = colours[buttonState[5]];
            button8.color = colours[buttonState[7]];
        }
    }

    // affects buttons  3, 5, 6 and 9
    public void pressButton6()
    {
        if (colours.Length > 0)
        {
            buttonState[2] = (buttonState[2] + 1) % colours.Length;
            buttonState[4] = (buttonState[4] + 1) % colours.Length;
            buttonState[5] = (buttonState[5] + 1) % colours.Length;
            buttonState[8] = (buttonState[8] + 1) % colours.Length;

            button3.color = colours[buttonState[2]];
            button5.color = colours[buttonState[4]];
            button6.color = colours[buttonState[5]];
            button9.color = colours[buttonState[8]];
        }
    }

    // affects buttons 4, 7 and 8
    public void pressButton7()
    {
        if (colours.Length > 0)
        {
            buttonState[3] = (buttonState[3] + 1) % colours.Length;
            buttonState[6] = (buttonState[6] + 1) % colours.Length;
            buttonState[7] = (buttonState[7] + 1) % colours.Length;

            button4.color = colours[buttonState[3]];
            button7.color = colours[buttonState[6]];
            button8.color = colours[buttonState[7]];
        }
    }

    // affects buttons 5, 7, 8 and 9
    public void pressButton8()
    {
        if (colours.Length > 0)
        {
            buttonState[4] = (buttonState[4] + 1) % colours.Length;
            buttonState[6] = (buttonState[6] + 1) % colours.Length;
            buttonState[7] = (buttonState[7] + 1) % colours.Length;
            buttonState[8] = (buttonState[8] + 1) % colours.Length;

            button5.color = colours[buttonState[4]];
            button7.color = colours[buttonState[6]];
            button8.color = colours[buttonState[7]];
            button9.color = colours[buttonState[8]];
        }
    }

    // affects buttons 6, 8 and 9
    public void pressButton9()
    {
        if (colours.Length > 0)
        {
            buttonState[5] = (buttonState[5] + 1) % colours.Length;
            buttonState[7] = (buttonState[7] + 1) % colours.Length;
            buttonState[8] = (buttonState[8] + 1) % colours.Length;

            button6.color = colours[buttonState[5]];
            button8.color = colours[buttonState[7]];
            button9.color = colours[buttonState[8]];
        }
    }

    // affects buttons 1, 2 and 4
    public static void reverseButton1()
    {

    }

    // affects buttons 1, 2, 3 and 5
    public static void reverseButton2()
    {

    }

    // affects buttons 3, 2 and 6
    public static void reverseButton3()
    {

    }

    // affects buttons 4, 1, 5 and 7
    public static void reverseButton4()
    {

    }

    // affects buttons 5, 2, 4, 6 and 8
    public static void reverseButton5()
    {

    }

    // affects buttons 6, 3, 5 and 9
    public static void reverseButton6()
    {

    }

    // affects buttons 7, 4 and 8
    public static void reverseButton7()
    {

    }

    // affects buttons 8, 7, 9 and 5
    public static void reverseButton8()
    {

    }

    // affects buttons 9, 8 and 6
    public static void reverseButton9()
    {

    }
}
