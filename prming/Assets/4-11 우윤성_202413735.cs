using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string stars;
        for (int n = 0; n < 10; n++)
        {
            stars = "";
            for (int o = 0; o < n + 1; o++)
            {
                stars += "*";
            }
                Debug.Log(stars);
        }
    }
}
