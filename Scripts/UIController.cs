using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public float scalingspeed = 0.01f;
    bool ScaleUp = false;
    bool ScaleDown = false;

    // Update is called once per frame
    void Update()
    {
        if (ScaleUp)
        {
            ScaleUpButton();
        }
        if (ScaleDown)
        {
            ScaleDownButton();
        }
    }

    public void ScaleUpButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Luffy");
        foreach (GameObject obj in objects)
        {
            obj.transform.localScale += new Vector3(scalingspeed, scalingspeed, scalingspeed);
        }
    }

    public void ScaleDownButton()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Luffy");
        foreach (GameObject obj in objects)
        {
            obj.transform.localScale += new Vector3(-scalingspeed, -scalingspeed, -scalingspeed);
        }
    }

    public void Up()
    {
        ScaleUp = true;
        ScaleDown = false;
    }

    public void Down()
    {
        ScaleUp = false;
        ScaleDown = true;
    }

    public void Stop()
    {
        ScaleUp = false;
        ScaleDown = false;
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Main Menu");
    }
}
