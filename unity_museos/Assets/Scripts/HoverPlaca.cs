using UnityEngine;

public class HoverPlaca : MonoBehaviour
{
    public RotacionBase rotacionBase;

    void OnMouseEnter()
    {
        rotacionBase.detenerRotacion = true;
    }

    void OnMouseExit()
    {
        rotacionBase.detenerRotacion = false;
    }
}