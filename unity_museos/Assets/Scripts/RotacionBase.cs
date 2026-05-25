using UnityEngine;

public class RotacionBase : MonoBehaviour
{
    public float velocidad = 15f;

    private Quaternion rotacionInicial;

    public Quaternion RotacionInicial
    {
        get { return rotacionInicial; }
    }

    private bool rotando = true;
    public bool enModoLectura = false;

    private bool regresando = false;

    void Start()
    {
        rotacionInicial = transform.rotation;
    }

    void Update()
    {
        if (rotando && !regresando)
        {
            transform.Rotate(0, velocidad * Time.deltaTime, 0);
        }

        if (regresando)
        {
            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                rotacionInicial,
                Time.deltaTime * 2f
            );

            if (Quaternion.Angle(transform.rotation, rotacionInicial) < 0.5f)
            {
                transform.rotation = rotacionInicial;

                regresando = false;

                rotando = false;
            }
        }
    }

    public void ResetearRotacion()
    {
        regresando = true;
    }

    public void ReanudarRotacion()
    {
        rotando = true;
    }
    public void PausarRotacion()
    {
        rotando = false;
    }
    public void RotarA(Quaternion rotacionObjetivo)
    {
        transform.rotation = rotacionObjetivo;

        rotando = false;
    }
}