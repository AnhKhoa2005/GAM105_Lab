using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager_Lab3 : MonoBehaviour
{
    [SerializeField] private GameObject youWinPanel;
    [SerializeField] private TextMeshProUGUI CompletionTimeText, NumberLevel, Death;
    [SerializeField] public Info info;

    public static UIManager_Lab3 Ins;

    void Awake()
    {
        if (Ins == null)
        {
            Ins = this;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        youWinPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        NumberLevel.text = info.NumberLevel.ToString() + "/5";
        Death.text = "Death: " + info.Death.ToString();
    }

    public void YouWinPanel()
    {
        if (GameManager_Lab3.Ins.CountCoin() > 0) return;
        Time.timeScale = 1;
        CompletionTimeText.text = "Completion Time: " + Mathf.FloorToInt(Time.time).ToString("F2") + "s";
        youWinPanel.SetActive(true);
        Invoke("NextLevel", 2);
    }

    void NextLevel()
    {
        info.NumberLevel++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
