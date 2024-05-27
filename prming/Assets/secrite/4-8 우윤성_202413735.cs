using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] intArray4 = { 1, 2, 3, 4, 5, 6, };

        for (int i = intArray4.Length - 1; i >= 0; i--)
        {
            Debug.Log(intArray4[i]);
        }
    }

}
