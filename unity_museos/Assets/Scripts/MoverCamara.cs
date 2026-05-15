using UnityEngine;

public class MoverCamara : MonoBehaviour
{
    public Transform objetivo;

    public float velocidad = 2f;

    private bool mover = false;

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
    }

    public void ActivarMovimiento()
    {
        mover = true;
    }
}