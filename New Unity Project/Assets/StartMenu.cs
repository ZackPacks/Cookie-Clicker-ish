using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    
    public void StartClicked()
    {
        SceneManager.LoadScene("Main");
    }
    public void RebirthClicked()
    {
        SceneManager.LoadScene("Rebirth");
    }
}
