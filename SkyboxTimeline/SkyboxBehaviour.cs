using UnityEngine;
using UnityEngine.Playables;
using System;

[Serializable]
public class SkyboxBehaviour : PlayableBehaviour
{
    public Material skyboxMaterial;
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        if (skyboxMaterial != null)
        {
            RenderSettings.skybox = skyboxMaterial;
        }
    }
}
