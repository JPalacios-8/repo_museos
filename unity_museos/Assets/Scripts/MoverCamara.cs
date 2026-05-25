using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public Transform objetivo;

    private Vector3 posicionInicial;

    private Quaternion rotacionInicial;

    public float velocidad = 2f;

    private bool mover = false;

    private bool regresar = false;

    void Start()
    {
        posicionInicial = transform.position;

        rotacionInicial = transform.rotation;
    }

    void Update()
    {
        if (mover)
        {
            transform.position = Vector3.Lerp(
                transform.position,
                objetivo.position,
                Time.deltaTime * velocidad
            );

            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                objetivo.rotation,
                Time.deltaTime * velocidad
            );
        }

        if (regresar)
        {
            transform.position = Vector3.Lerp(
                transform.position,
                posicionInicial,
                Time.deltaTime * velocidad
            );

            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                rotacionInicial,
                Time.deltaTime * velocidad
            );
        }
    }

    public void ActivarMovimiento()
    {
        mover = true;

        regresar = false;
    }

    public void ResetCamara()
    {
        mover = false;

        regresar = true;
    }
}