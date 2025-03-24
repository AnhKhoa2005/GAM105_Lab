using UnityEngine;

public class RotationObstacle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;

    [Range(-1, 1)]
    [SerializeField] private float Dir = 1f;
    void Update()
    {
        this.transform.localRotation *= Quaternion.Euler(0, 0, rotationSpeed * Dir);
    }
}
