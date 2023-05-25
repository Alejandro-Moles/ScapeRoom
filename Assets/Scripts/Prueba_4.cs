using Oculus.Voice;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_4 : MonoBehaviour
{
    public Animator animator;
    private bool Prueba4;
    public AppVoiceExperience appVoice;

    void Update()
    {
        if (Prueba4)
        {
            appVoice.Activate();
        }
    }

    public void AbrirPuerta(string[] values)
    {

        var abrirstring = values[0];
        var puertastring = values[1];

            if (abrirstring == "abrir" || abrirstring == "puerta")
            {
                animator.SetBool("Open", true);

            }

            if (puertastring == "abrir" || puertastring == "puerta")
            {
                animator.SetBool("Open", true);

            }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Prueba4= true;
        }
    }
}
