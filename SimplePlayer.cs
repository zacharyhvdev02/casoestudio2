using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayer : MonoBehaviour
{
    [SerializeField]
    public GameObject[] particles;

    public int Health { get; internal set; }

    public void ShowParticle(int index)
    {
        GameObject particle = particles[index];

        particle.SetActive(true);
    }
}
