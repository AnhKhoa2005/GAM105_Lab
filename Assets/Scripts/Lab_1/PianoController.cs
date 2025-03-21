using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _sol, _la, _si;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _sol = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) _do.Play();
        if (Input.GetKeyDown(KeyCode.S)) _re.Play();
        if (Input.GetKeyDown(KeyCode.D)) _mi.Play();
        if (Input.GetKeyDown(KeyCode.F)) _fa.Play();
        if (Input.GetKeyDown(KeyCode.G)) _sol.Play();
        if (Input.GetKeyDown(KeyCode.H)) _la.Play();
        if (Input.GetKeyDown(KeyCode.J)) _si.Play();
    }
}
