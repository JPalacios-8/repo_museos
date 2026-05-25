using UnityEngine;

public class ExplosionReloj : MonoBehaviour
{
    public Transform[] piezas;

    public Transform[] targets;

    public float velocidad = 2f;

    public bool estaExplotado = false;

    private Vector3[] posicionesIniciales;

    private bool explotar = false;

    private bool regresar = false;

    void Start()
    {
        posicionesIniciales = new Vector3[piezas.Length];

        for (int i = 0; i < piezas.Length; i++)
        {
            posicionesIniciales[i] = piezas[i].localPosition;
        }
    }

    void Update()
    {
        if (explotar)
        {
            for (int i = 0; i < piezas.Length; i++)
            {
                piezas[i].localPosition = Vector3.Lerp(
                    piezas[i].localPosition,
                    targets[i].localPosition,
                    Time.deltaTime * velocidad
                );
            }
        }

        if (regresar)
        {
            for (int i = 0; i < piezas.Length; i++)
            {
                piezas[i].localPosition = Vector3.Lerp(
                    piezas[i].localPosition,
                    posicionesIniciales[i],
                    Time.deltaTime * velocidad
                );
            }
        }
    }

    public void ActivarExplosion()
    {
        explotar = true;

        regresar = false;

        estaExplotado = true;
    }

    public void ResetExplosion()
    {
        explotar = false;

        regresar = true;

        estaExplotado = false;
    }
}