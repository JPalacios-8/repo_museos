using UnityEngine;

public class RotacionBase : MonoBehaviour
{
    public float velocidad = 15f;

    void Update()
    {
        transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}