using UnityEngine;

public class HoverReloj : MonoBehaviour
{
    public ExplosionReloj explosion;

    void OnMouseEnter()
    {
        Debug.Log("Hover sobre reloj");
    }

    void OnMouseExit()
    {
        Debug.Log("Mouse salió del reloj");
    }

    void OnMouseDown()
    {
        Debug.Log("Click en reloj");
        explosion.ActivarExplosion();
    }
}