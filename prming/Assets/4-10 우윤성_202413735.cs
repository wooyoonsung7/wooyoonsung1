using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
            string[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (var item in array)
            {
                Debug.Log(item);
            }
        }
    }
}
