using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    private float xRotation;
    private float yRotation;


    void Start()
    {
        // travar o cursor
        Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;

    }

    void Update()
    {
        //input do mouse

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        // Rota��o em volta do eixo y, significa horizontalmente
        yRotation += mouseX;

        // Rota��o em volta do eixo y, significa verticalmente
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f ,90f);

        //Rota��o e camera

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

    }
}
