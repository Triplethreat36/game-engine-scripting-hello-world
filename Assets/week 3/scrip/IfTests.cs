using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTests : MonoBehaviour
{

    [ContextMenu("Execute")]
    void ExecuteTest()
    {
        int coins = 10011011;
        string word = "bird";
        bool someBool = true;

        if (coins == 10011011)
        {
            Debug.Log(word);
        }
        if (coins != 10011011)
        {
            Debug.Log("Not Equal");
        }
    }
}
