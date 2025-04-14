
using TMPro;
using UnityEngine;

public class CrossHair : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject YouWinPanel;
    private int score = 0;
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;
        transform.position = mousePosition;

        scoreText.text = "Score: " + score.ToString();

        if (score >= 10)
        {
            YouWinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ball") && Input.GetMouseButton(0))
        {
            score++;

            Destroy(other.gameObject);
        }
    }
}
