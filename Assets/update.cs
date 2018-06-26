using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class update : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        Global.CurrentColor = gameObject.tag;
    }
}
