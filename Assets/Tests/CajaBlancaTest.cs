using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaBlancaTest : MonoBehaviour
{
    private float vida = 100f;
    private bool muerto = false;
    private int dañoParry = 20;
    private int dañoSpecial = 10;
    private int dañoNormal = 8;
    private bool isParrying;
    private bool hasSpecialWeapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AIFunctionality()
    {
        if (vida <= 0)
        {
            muerto = true;
            return;
        }


    }
}
