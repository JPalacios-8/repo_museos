using UnityEngine;

public class PanelEvaluacionUI : MonoBehaviour
{
    public GameObject panelEvaluacion;

    public void AbrirPanel()
    {
        panelEvaluacion.SetActive(true);
    }

    public void CerrarPanel()
    {
        panelEvaluacion.SetActive(false);
    }

    public void AbrirQuiz()
    {
        Application.OpenURL("PEGA_AQUI_TU_LINK");
    }
}