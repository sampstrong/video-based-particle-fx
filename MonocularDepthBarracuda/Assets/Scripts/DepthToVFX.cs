using UnityEngine;
using UnityEngine.VFX;

public class DepthToVFX : MonoBehaviour
{
    [SerializeField] private VisualEffect _effect;
    [SerializeField] private RenderTexture _sourceVideo;
    
    private static readonly int ColorTex = Shader.PropertyToID("_ColorTexture");
    private static readonly int DepthTex = Shader.PropertyToID("_DepthTexture");
    private static readonly int TexWidth = Shader.PropertyToID("_TexWidth");
    private static readonly int TexHeight = Shader.PropertyToID("_TexHeight");

    public void OnColorReceived(RenderTexture rt)
    {
        _effect.SetTexture(ColorTex, rt);
        _effect.SetFloat(TexWidth, _sourceVideo.width);
        _effect.SetFloat(TexHeight, _sourceVideo.height);
    }

    public void OnDepthReceived(RenderTexture rt)
    {
        _effect.SetTexture(DepthTex, rt);
    }
}
