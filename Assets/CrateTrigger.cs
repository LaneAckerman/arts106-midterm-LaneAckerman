using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateTrigger : MonoBehaviour
{
    Animator animator;

    void Start()
    {
         animator = GetComponentInChildren<Animator>();

    }
    
    public void OnTriggerEnter(Collider collider)
    {
        animator.SetTrigger("CrateTrigger");
    }


}
