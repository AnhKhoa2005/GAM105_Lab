using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;         // Player hoặc đối tượng cần camera theo
    public float smoothSpeed = 0.125f; // Tốc độ mượt khi camera di chuyển
    public Vector3 offset;           // Độ lệch giữa camera và player

    void LateUpdate()
    {
        if (target == null) return;

        // Vị trí mong muốn của camera
        Vector3 desiredPosition = target.position + offset;

        // Lerp để di chuyển camera mượt mà
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Gán lại vị trí mới cho camera
        transform.position = smoothedPosition;
    }
}
