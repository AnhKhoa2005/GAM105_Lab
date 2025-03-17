using System.Collections;
using UnityEngine;

public class PlayerController_Lab3 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform RespawnPoint;

    Animator ani;
    bool isRespawning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        if (isRespawning) return;
        float xDir = Input.GetAxis("Horizontal");
        float yDir = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(xDir, yDir);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            StartCoroutine(Respawn());
        }
    }

    IEnumerator Respawn()
    {
        ani.CrossFade("Fade", 0);
        isRespawning = true;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(1.5f);
        this.transform.position = RespawnPoint.position;
        yield return new WaitForSeconds(0.1f);
        ani.CrossFade("Player_Lab3", 0);
        isRespawning = false;
        GetComponent<Collider2D>().enabled = true;
    }
}
