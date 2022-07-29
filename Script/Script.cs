using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{

    public GameObject StartPanel;
    public GameObject PlayPanel;

    // Start is called before the first frame update
    void Start()
    {
        StartPanel.SetActive(true);
        PlayPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartClicked()
    {
        SceneManager.LoadScene("PlayPanel");
        StartPanel.SetActive(false);
        PlayPanel.SetActive(true);
    }

    public void ExitClicked()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
