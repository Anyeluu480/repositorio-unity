using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;

    private float _vInput;
    private float _hInput;

    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _vInput = Input.GetAxis("Vertical") * MoveSpeed;
        _hInput = Input.GetAxis("Horizontal") * RotateSpeed;

        /*
        // Este código mueve el objeto hacia adelante basado en la entrada vertical (_vInput) y rota el objeto en el eje Y basado en la entrada horizontal (_hInput).
        this.transform.Translate(Vector3.forward * _vInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * _hInput * Time.deltaTime);
        */
    }

    void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * _hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position + this.transform.forward * _vInput * Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}