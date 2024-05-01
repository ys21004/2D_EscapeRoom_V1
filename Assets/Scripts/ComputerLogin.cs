using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class ComputerLogin : MonoBehaviour
{
    public string correctUsername = "admin";
    public string correctPassword = "password";

    public InputField usernameInput;
    public InputField passwordInput;
    public GameObject loginPanel;
    public GameObject computerPanel;
    public Text loginMessageText;
    public VideoPlayer videoPlayer;
    public GameObject videoCanvas;

    private bool loggedIn = false;

    public void OnLoginButtonClicked()
    {
        string username = usernameInput.text;
        string password = passwordInput.text;

        if (username == correctUsername && password == correctPassword)
        {
            // Successful login
            loginMessageText.text = "Login successful!";
            loginPanel.SetActive(false);
            computerPanel.SetActive(true);
            loggedIn = true;
            Invoke("PlayVideoAfterLogin", 1.0f); // Delay the video playback after login
        }
        else
        {
            // Failed login
            loginMessageText.text = "Incorrect username or password.";
        }
    }

    private void PlayVideoAfterLogin()
    {
        if (loggedIn)
        {
            // Enable the video canvas
            videoCanvas.SetActive(true);

            // Play the video
            videoPlayer.Play();
        }
    }

    public void OnLogoutButtonClicked()
    {
        usernameInput.text = "";
        passwordInput.text = "";
        loginMessageText.text = "";
        computerPanel.SetActive(false);
        loginPanel.SetActive(true);
        videoCanvas.SetActive(false); // Hide video canvas on logout
        loggedIn = false; // Reset login status
    }
}