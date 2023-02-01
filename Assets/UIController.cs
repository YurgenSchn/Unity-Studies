using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{

    public Button startButton;
    public Button messageButton;
    public Label  messageText;

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        startButton   = root.Q<Button>("ButtonStartGame");
        messageButton = root.Q<Button>("ButtonShowMessage");
        messageText   = root.Q<Label>("LabelMessage");

        startButton.clicked += StartButtonPressed;
        messageButton.clicked += MessageButtonPressed;

    }

    void StartButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    void MessageButtonPressed()
    {
        messageText.text = "AOBA!";
        messageText.style.display = DisplayStyle.Flex;
    }
}
