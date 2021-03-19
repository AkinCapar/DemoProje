using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject startCanvas;
    [SerializeField] GameObject loseCanvas;
    [SerializeField] GameObject winCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        startCanvas.SetActive(true);
        loseCanvas.SetActive(false);
        winCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivateLoseCanvas()
    {
        Time.timeScale = 0f;
        loseCanvas.SetActive(true);
    }


    public void ActivateWinCanvas()
    {
        Time.timeScale = 0f;
        winCanvas.SetActive(true);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startCanvas.SetActive(false);
    }
}
