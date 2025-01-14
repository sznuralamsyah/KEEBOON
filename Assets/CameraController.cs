using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        // Menggerakkan kamera dengan tombol WASD
        float horizontal = Input.GetAxis("Horizontal"); // A/D atau pan kiri/kanan
        float vertical = Input.GetAxis("Vertical"); // W/S atau maju/mundur

        // Gerakan kamera
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        // Rotasi kamera dengan klik kanan + mouse
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            transform.Rotate(-mouseY, mouseX, 0);
        }
    }
}
