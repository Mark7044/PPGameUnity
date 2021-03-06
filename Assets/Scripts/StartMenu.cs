using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public Button startButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        Component[] buttonComponents;
        buttonComponents = GetComponentsInChildren<Button>(); // store all the buttons in an array.
        startButton = buttonComponents[0].GetComponent<Button>(); // Get first button.
        quitButton = buttonComponents[1].GetComponent<Button>(); // Get second button.

        // Add a listener for a click event for each button
        startButton.onClick.AddListener(delegate { Debug.Log("Start"); StartGame(); });
        quitButton.onClick.AddListener(delegate { Debug.Log("Quit"); Application.Quit(); });
    }

    private void StartGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
