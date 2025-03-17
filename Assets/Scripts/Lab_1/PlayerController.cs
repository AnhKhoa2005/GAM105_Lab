using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.A)) Debug.Log("press A");
        if (Input.GetKeyDown(KeyCode.D)) Debug.Log("press D");
        if (Input.GetKey(KeyCode.D)) Debug.Log("GetKey D");
    }
}
