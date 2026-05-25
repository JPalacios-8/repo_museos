using UnityEngine;

public class HoverPlaca : MonoBehaviour
{
    public RotacionBase rotacionBase;

    void OnMouseEnter()
    {
        if (!rotacionBase.enModoLectura)
        {
            rotacionBase.PausarRotacion();
        }
    }

    void OnMouseExit()
    {
        if (!rotacionBase.enModoLectura)
        {
            rotacionBase.ReanudarRotacion();
        }
    }
}