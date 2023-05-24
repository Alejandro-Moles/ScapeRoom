using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_1 : MonoBehaviour
{
    [SerializeField] private GameObject Puerta;

    public bool Prueba1_Supreada;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PiezaClave"))
        {
            Prueba1_Supreada= true;
        }
    }
}
