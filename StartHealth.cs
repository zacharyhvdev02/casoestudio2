using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHealth : MonoBehaviour
{
    private void OnMouseEnter()
    {
        Debug.Log("working button");
    }

    public void Heal()
    {
        Debug.Log("StartHealth constructor");
        GameObject.FindObjectOfType<SimplePlayer>().ShowParticle(0);
    }
}
