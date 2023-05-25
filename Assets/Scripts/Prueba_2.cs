using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Prueba_2 : MonoBehaviour
{
    public string password;
    private string CorrectPassword = "123450";
    public Animator animator;
    public TextMeshPro PasswordText;

    private void Update()
    {
        if (password == CorrectPassword)
        {
            animator.SetBool("Open", true);
        }
    }

    public void IntentarPassword()
    {
        if (password == CorrectPassword)
        {
            animator.SetBool("Open", true);
        }
        else
        {
            PasswordText.text = "";
        }
    }

    public void PulsarNumero0()
    {
        password = password + TextoBoton.text;
        PasswordText.text = password;
    }

    public void PulsarNumero1()
    {
        password = password + TextoBoton.text;
        PasswordText.text = password;
    }

    public void PulsarNumero2()
    {
        password = password + TextoBoton.text;
        PasswordText.text = password;
    }

    public void PulsarNumero3()
    {
        password = password + TextoBoton.text;
        PasswordText.text = password;
    }

    public void PulsarNumero4()
    {
        password = password + TextoBoton.text;
        PasswordText.text = password;
    }
}
