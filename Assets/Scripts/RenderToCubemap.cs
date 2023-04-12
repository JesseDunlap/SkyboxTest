using UnityEngine;

public class RenderToCubemap : MonoBehaviour
{
    [SerializeField] private Camera renderCamera;
    [SerializeField] private RenderTexture renderTexture;
    
    private void Update() => renderCamera.RenderToCubemap(renderTexture);
}
