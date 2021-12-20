using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Variables
    [SerializeField] private bool _isGameOver = false;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && _isGameOver == true)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void GameOver()
    {
        _isGameOver = true;
    }
}
