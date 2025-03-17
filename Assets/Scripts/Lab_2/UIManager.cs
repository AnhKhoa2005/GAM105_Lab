using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject youWin;
    [SerializeField] private GameObject youLose;
    public static UIManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        youWin.SetActive(false);
        youLose.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.instance.score + "/10";

        if (GameManager.instance.score == 10)
        {
            youWin.SetActive(true);
            Time.timeScale = 0;
        }
        else if (GameManager.instance.score < 0)
        {
            GameManager.instance.score = 0;
            youLose.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
