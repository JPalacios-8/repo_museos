using UnityEngine;

public class ExplosionReloj : MonoBehaviour
{
    public Transform[] piezas;

    public Transform[] targets;

    public float velocidad = 2f;

    private bool explotar = false;

    void Update()
    {
        if (explotar)
        {
            for (int i = 0; i < piezas.Length; i++)
            {
                piezas[i].position = Vector3.Lerp(
                    piezas[i].position,
                    targets[i].position,
                    Time.deltaTime * velocidad
                );
            }
        }
    }

    public void ActivarExplosion()
    {
        explotar = true;
    }
}