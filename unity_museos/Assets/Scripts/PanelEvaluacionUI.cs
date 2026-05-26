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
        Application.OpenURL("https://mecanicadeltiempo.milaulas.com/course/view.php?id=2");
    }
}