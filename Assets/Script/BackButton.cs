using UnityEngine.SceneManagement;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene(1); // Load scene menu khi nhấn nút button
    }
}
