
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidadMovimiento = 1.5f;

    private Rigidbody rb;
    private float movimientoX;
    private float movimientoZ;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movimientoX = 0;
        movimientoZ = 0;

        if (Input.GetKey(KeyCode.D))
            movimientoZ = 1;

        if (Input.GetKey(KeyCode.A))
            movimientoZ = -1;

        if (Input.GetKey(KeyCode.S))
            movimientoX = 1;

        if (Input.GetKey(KeyCode.W))
            movimientoX = -1;
    }

    void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(movimientoX, 0, movimientoZ).normalized;

        rb.MovePosition(
            rb.position + transform.TransformDirection(movimiento) * velocidadMovimiento * Time.fixedDeltaTime
        );
    }
}
