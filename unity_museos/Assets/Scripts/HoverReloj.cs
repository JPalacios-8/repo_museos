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

    public GameObject botonCerrar;

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

            botonCerrar.SetActive(true);

            Invoke("ActivarExplosion", 1.2f);
        }
        else
        {
            ResetearExperienciaPublico();
        }
    }

    void ActivarExplosion()
    {
        explosion.ActivarExplosion();
    }

    public void ResetearExperienciaPublico()
    {
        botonCerrar.SetActive(false);

        explosion.ResetExplosion();

        moverCamara.ResetCamara();

        blurController.DesactivarBlur();

        rotacionBase.ReanudarRotacion();
    }
}