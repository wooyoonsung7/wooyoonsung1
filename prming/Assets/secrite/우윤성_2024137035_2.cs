using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 우윤성_2024137035_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string input2 = "감자 고구마 토마토";
        string[] inputs = input2.Split(new char[] { ' ' });

        foreach (var item in inputs)
        {
            Debug.Log(item);
        }
    }
}
