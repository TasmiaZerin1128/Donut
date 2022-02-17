using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class checkButton : MonoBehaviour
{
    // Start is called before the first frame update

    public static string AtomNumber;

    void Start()
    {
        if (AtomNumber == "1")
            Debug.Log("Yess hoise paisi button");
    }
}
