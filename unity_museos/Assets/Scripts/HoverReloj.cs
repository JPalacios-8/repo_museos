using UnityEngine;

public class HoverReloj : MonoBehaviour
{
    public ExplosionReloj explosion;

    public MoverCamara moverCamara;

    public RotacionBase rotacionBase;

    public BlurController blurController;

    public GameObject panelHover;

    void OnMouseEnter()
    {
        panelHover.SetActive(true);
    }

    void OnMouseExit()
    {
        panelHover.SetActive(false);
    }

    void OnMouseDown()
    {
        panelHover.SetActive(false);

        rotacionBase.ResetearRotacion();

        moverCamara.ActivarMovimiento();

        blurController.ActivarBlur();

        Invoke("ActivarExplosion", 1.2f);
    }

    void ActivarExplosion()
    {
        explosion.ActivarExplosion();
    }
}