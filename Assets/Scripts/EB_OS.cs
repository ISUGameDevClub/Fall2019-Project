using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EB_OS : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
