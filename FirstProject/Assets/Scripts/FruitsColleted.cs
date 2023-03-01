using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsColleted : MonoBehaviour
{
    public static bool takeFruit = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        takeFruit = true;
    }
}
