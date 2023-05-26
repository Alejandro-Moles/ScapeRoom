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
        /*
        if (password == CorrectPassword)
        {
            animator.SetBool("Open", true);
        }*/
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
            password = "";
        }
    }

    public void PulsarNumero0()
    {
        password = password + "0";
        PasswordText.text = password;
    }

    public void PulsarNumero1()
    {
        password = password + "1";
        PasswordText.text = password;
    }

    public void PulsarNumero2()
    {
        password = password + "2";
        PasswordText.text = password;
    }

    public void PulsarNumero3()
    {
        password = password + "3";
        PasswordText.text = password;
    }

    public void PulsarNumero4()
    {
        password = password + "4";
        PasswordText.text = password;
    }
    
    public void PulsarNumero5()
    {
        password = password + "5";
        PasswordText.text = password;
    }
}
