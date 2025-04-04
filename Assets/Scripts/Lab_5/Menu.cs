using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void _Menu()
    {
        UIManager_Lab3.Ins.info.Death = 0;
        UIManager_Lab3.Ins.info.NumberLevel = 1;
        SceneManager.LoadScene("MainMenulab_5");
    }
}
