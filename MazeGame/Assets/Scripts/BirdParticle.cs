using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BirdParticle : MonoBehaviour
{
    ParticleSystem system;
    public void Awke()
    {
        system = GameObject.Find("Particle System").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        System.Random rnd=new System.Random();
        double num= rnd.NextDouble();
        if (num > 0.75)
            shitStatus(false);
        else shitStatus(true);
    }

    private void shitStatus(bool a)
    {
        if (a)
        {
            system.Play();
        }
        else 
        { 
            system.Stop();
        }
    }
}
