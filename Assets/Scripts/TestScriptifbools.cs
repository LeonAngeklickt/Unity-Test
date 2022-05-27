using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptifbools : MonoBehaviour
{
    public bool testBool;

    void Start()
    {
        CompareNumbers(1, 2);
        CompareNumbers(2, 2);
        CompareNumbers(2, 1);
    }

    public void CompareNumbers(int a, int b)
    {

        if (a < b)
        {
            Debug.Log("a ist kleiner als b");
        } else if (a > b)
        {
            Debug.Log("a ist größer als b");
        } else // if (a == b) überprüfung auch möglich!
        {
            Debug.Log("a und b sind gleich groß");
        }

    }

}
