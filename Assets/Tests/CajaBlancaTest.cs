using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaBlancaTest : MonoBehaviour
{
    private float vida = 100f;
    private bool muerto = false;
    private bool isParry;
    private bool hasSpecialWeapon;

    // Start is called before the first frame update
    void Start()
    {
        if (vida == 0)
        {
            this.muerto = true;
        }
        else
        {
            this.muerto = false;
        }
    }

    public float Attack(bool isParry, bool hasSpecialWeapon)
    {
        if (isParry)
        {
            return 20f;
        }
        if (hasSpecialWeapon)
        {
            return 10f;
        }
        return 8f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
