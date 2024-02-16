using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[VolumeComponentMenuForRenderPipeline("Custom/Ben Day Bloom Effect", typeof(UniversalRenderPipeline))]
public class BenDayBloomEffectComponent : VolumeComponent, IPostProcessComponent {
    [Header("Bloom Settings")]
    public FloatParameter threshold = new(0.9f, true);

    public FloatParameter intensity = new(1, true);
    public ClampedFloatParameter scatter = new(0.7f, 0, 1, true);
    public IntParameter clamp = new(65472, true);
    public ClampedFloatParameter maxIterations = new(6, 0, 10);
    public NoInterpColorParameter tint = new(Color.white);

    [Header("Benday")]
    public IntParameter dotsDensity = new(10, true);

    public ClampedFloatParameter dotsCutoff = new(0.4f, 0, 1, true);
    public Vector2Parameter scrollDirection = new(new Vector2());


    public bool IsActive() {
        return true;
    }

    public bool IsTileCompatible() {
        return false;
    }
}