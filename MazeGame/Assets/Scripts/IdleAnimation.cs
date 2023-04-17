using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAnimation : MonoBehaviour
{
    Animator anim;

    public void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void Update()
    {
        anim.SetInteger("Idle2", 1);
    }
}
