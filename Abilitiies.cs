using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilitiies : MonoBehaviour
{

    public Abilitiies()
    {
        Debug.Log("Abilitiies constructor");
    }
    public void Process()
    {
        GameObject.FindObjectOfType<SimplePlayer>().ShowParticle(0);
    }
}
