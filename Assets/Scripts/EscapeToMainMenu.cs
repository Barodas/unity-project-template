using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToMainMenu : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }
}
