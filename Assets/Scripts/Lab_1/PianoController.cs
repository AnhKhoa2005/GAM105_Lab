using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _sol, _la, _si;
    Renderer _doRenderer, _reRenderer, _miRenderer, _faRenderer, _solRenderer, _laRenderer, _siRenderer;
    Color defaultColor = Color.white;
    Color pressedColor = Color.red;

    void Start()
    {
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _sol = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();

        // Lấy Renderer để đổi màu
        _doRenderer = GameObject.FindWithTag("do").GetComponent<Renderer>();
        _reRenderer = GameObject.FindWithTag("re").GetComponent<Renderer>();
        _miRenderer = GameObject.FindWithTag("mi").GetComponent<Renderer>();
        _faRenderer = GameObject.FindWithTag("fa").GetComponent<Renderer>();
        _solRenderer = GameObject.FindWithTag("son").GetComponent<Renderer>();
        _laRenderer = GameObject.FindWithTag("la").GetComponent<Renderer>();
        _siRenderer = GameObject.FindWithTag("si").GetComponent<Renderer>();
    }

    void Update()
    {
        CheckKey(KeyCode.A, _do, _doRenderer);
        CheckKey(KeyCode.S, _re, _reRenderer);
        CheckKey(KeyCode.D, _mi, _miRenderer);
        CheckKey(KeyCode.F, _fa, _faRenderer);
        CheckKey(KeyCode.G, _sol, _solRenderer);
        CheckKey(KeyCode.H, _la, _laRenderer);
        CheckKey(KeyCode.J, _si, _siRenderer);
    }

    void CheckKey(KeyCode key, AudioSource sound, Renderer renderer)
    {
        if (Input.GetKeyDown(key))
        {
            sound.Play();
            renderer.material.color = pressedColor;
        }
        if (Input.GetKeyUp(key))
        {
            renderer.material.color = defaultColor;
        }
    }
}

