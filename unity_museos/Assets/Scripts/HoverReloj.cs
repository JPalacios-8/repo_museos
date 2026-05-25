using UnityEngine;

public class HoverReloj : MonoBehaviour
{
    public ExplosionReloj explosion;

    public MoverCamara moverCamara;

    public RotacionBase rotacionBase;

    public BlurController blurController;

    public GameObject panelHover;

    public GameObject panelVolver;

    public Transform camaraTargetExplosion;

    void OnMouseEnter()
    {
        if (!explosion.estaExplotado)
        {
            panelHover.SetActive(true);
        }
        else
        {
            panelVolver.SetActive(true);
        }
    }

    void OnMouseExit()
    {
        panelHover.SetActive(false);

        panelVolver.SetActive(false);
    }

    void OnMouseDown()
    {
        if (!explosion.estaExplotado)
        {
            panelHover.SetActive(false);

            rotacionBase.ResetearRotacion();

            moverCamara.ResetCamara();

            moverCamara.objetivo = camaraTargetExplosion;

            moverCamara.ActivarMovimiento();

            blurController.ActivarBlur();

            Invoke("ActivarExplosion", 1.2f);
        }
        else
        {
            ResetearExperiencia();
        }
    }

    void ActivarExplosion()
    {
        explosion.ActivarExplosion();
    }

    void ResetearExperiencia()
    {
        explosion.ResetExplosion();

        moverCamara.ResetCamara();

        blurController.DesactivarBlur();

        rotacionBase.ReanudarRotacion();
    }
}