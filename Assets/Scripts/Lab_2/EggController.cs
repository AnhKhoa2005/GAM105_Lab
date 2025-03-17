using UnityEngine;

public class EggController : MonoBehaviour
{
    Animator ani;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            ani.CrossFade("EggBroken", 0);
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
            GameManager.instance.score--;
            Destroy(gameObject, 2f);
        }

        if (collision.gameObject.CompareTag("Basket"))
        {
            Destroy(gameObject);
            GameManager.instance.score++;
        }
    }
}
