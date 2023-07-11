using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScondConverts : MonoBehaviour
{
    public static float deltatime;
    public float timer = 0;
    public int Index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("進入場景!");
        Index = SceneManager.GetActiveScene().buildIndex;
        Index += 1;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);

        if (timer > 3f)
        {
            timer = 0;
            SceneManager.LoadScene(Index % 3);
            //SceneManager.LoadScene("livingroom");//載入場景
        }

    }
}
