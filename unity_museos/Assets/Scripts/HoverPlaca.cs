using UnityEngine;

public class HoverPlaca : MonoBehaviour
{
    public RotacionBase rotacionBase;

    void OnMouseEnter()
    {
        rotacionBase.PausarRotacion();
    }

    void OnMouseExit()
    {
        rotacionBase.ReanudarRotacion();
    }
}