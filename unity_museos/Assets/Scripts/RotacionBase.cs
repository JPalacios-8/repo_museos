using UnityEngine;

public class RotacionBase : MonoBehaviour
{
    public float velocidad = 15f;

    [HideInInspector]
    public bool detenerRotacion = false;

    void Update()
    {
        if (!detenerRotacion)
        {
            transform.Rotate(0, velocidad * Time.deltaTime, 0);
        }
    }
}