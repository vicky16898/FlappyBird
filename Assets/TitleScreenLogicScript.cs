using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScrpt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void startGame()
    {
        SceneManager.LoadScene("GameScreenScene");
    }
}
