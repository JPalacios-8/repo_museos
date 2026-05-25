using UnityEngine;

public class BotonCerrarUI : MonoBehaviour
{
    public HoverReloj hoverReloj;

    public InteraccionPlaca placaFrontal;

    public InteraccionPlaca placaTrasera;

    public ExplosionReloj explosion;

    public void Cerrar()
    {
        if (explosion.estaExplotado)
        {
            hoverReloj.ResetearExperienciaPublico();
        }
        else
        {
            placaFrontal.ForzarSalida();

            placaTrasera.ForzarSalida();
        }

        gameObject.SetActive(false);
    }
}