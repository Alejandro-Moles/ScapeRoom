using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_3 : MonoBehaviour
{
    public Animator animator;
    public bool isPrueba3;

    public void OpenDoor()
    {
        if (isPrueba3)
        {
            animator.SetBool("Open", true);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPrueba3= true;
            //animator.SetBool("Open", true);
        }
    }
}
