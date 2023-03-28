using UnityEngine;
using UnityEngine.SceneManagement;

public class History : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadLevel();
        }
    }
}