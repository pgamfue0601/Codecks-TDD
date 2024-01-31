using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScripts
{
    private int vida = 100;
    private int balas = 10;
    string message;

    public string TestHealthCheck(int vida)
    {
        if (vida == 100)
        {
            Debug.Log("<::Salud máxima::>");
            message = "<::Salud máxima::>";
        }
        else if (vida < 100 && vida > 60)
        {
            Debug.Log("<::Daños leves, se puede continuar::>");
            message = "<::Daños leves, se puede continuar::>";
        }
        else if (vida < 60 && vida > 30)
        {
            Debug.Log("<::Daños graves, se recomienda precaución::>");
            message = "<::Daños graves, se recomienda precaución::>";
        }
        else if (vida > 30 && vida < 0)
        {
            Debug.Log("<::Muerte inminente del usuario, se recomienda urgentemente buscar material médico.::>");
            message = "<::Muerte inminente del usuario, se recomienda urgentemente buscar material médico::>";
        }
        else if (vida <= 0)
        {
            Debug.Log("<::Usuario sin vida, solicitando asistencia sanitaria remota.::>");
            message = "<::Usuario sin vida, solicitando asistencia sanitaria remota::>";
        }

        return message;
        
    }

    public bool TestShoot(int balas)
    {
        if (balas > 1)
        {
            Debug.Log("Puede disparar");
            return true;
        }
        else
        {
            Debug.Log("No puede disparar");
            return false;
        }
    }
    // A Test behaves as an ordinary method
    [TestCase]
    public void test1()
    {
        string prueba = TestHealthCheck(100);
        // Use the Assert class to test conditions
        Assert.AreEqual("<::Salud máxima::>", prueba);
    }

    public void test2()
    {
        bool prueba = TestShoot(0);
        Assert.AreEqual(true, prueba);
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestScriptsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
