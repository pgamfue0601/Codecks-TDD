using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class PlayModeTesting
{
    //PlayMode1
    private GameObject esfera;
    private GameObject cubo;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("TestScene");
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator PlayModeTestingWithEnumeratorPasses()
    {
        yield return new WaitForSeconds(1.5f);
        esfera = GameObject.Find("Sphere");
        cubo = GameObject.Find("Cube");

        Assert.That(cubo.transform.position.y > cubo.transform.position.y);
    }

    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync(EditorSceneManager.GetActiveScene());
    }
}
