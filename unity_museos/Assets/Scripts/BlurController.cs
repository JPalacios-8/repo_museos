using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BlurController : MonoBehaviour
{
    public Volume volume;

    private DepthOfField depthOfField;

    void Start()
    {
        volume.profile.TryGet(out depthOfField);

        depthOfField.active = false;
    }

    public void ActivarBlur()
    {
        depthOfField.active = true;
    }
}