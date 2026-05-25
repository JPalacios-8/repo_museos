using UnityEngine;

public class InteraccionPlaca : MonoBehaviour
{
    public bool esPlacaTrasera = false;

    public RotacionBase rotacionBase;

    public MoverCamara moverCamara;

    public Transform targetLectura;

    public GameObject botonCerrar;

    private bool enModoLectura = false;

    void OnMouseDown()
    {
        if (!enModoLectura)
        {
            ActivarLectura();
        }
        else
        {
            DesactivarLectura();
        }
    }

    void ActivarLectura()
    {
        rotacionBase.enModoLectura = true;
        rotacionBase.PausarRotacion();
        botonCerrar.SetActive(true);


        if (esPlacaTrasera)
        {
            rotacionBase.transform.rotation =
                rotacionBase.RotacionInicial *
                Quaternion.Euler(0, 180, 0);
        }
        else
        {
            rotacionBase.transform.rotation =
                rotacionBase.RotacionInicial;
        }

        moverCamara.objetivo = targetLectura;

        moverCamara.ActivarMovimiento();

        enModoLectura = true;
    }

    void DesactivarLectura()
    {
        moverCamara.ResetCamara();
        rotacionBase.enModoLectura = false;

        rotacionBase.ReanudarRotacion();

        enModoLectura = false;
    }

    public void ForzarSalida()
    {
        moverCamara.ResetCamara();

        rotacionBase.enModoLectura = false;

        botonCerrar.SetActive(false);

        rotacionBase.ReanudarRotacion();

        enModoLectura = false;
    }
}