using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace _Game.Scripts {
    public class CustomPostProcessRenderFeature : ScriptableRendererFeature {

        [SerializeField] private Shader _bloomShader;
        [SerializeField] private Shader _compositeShader;
        
        private CustomPostProcessPass _customPostProcessPass;
        
        public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) {
            renderer.EnqueuePass(_customPostProcessPass);
        }

        public override void Create() {
            _customPostProcessPass = new CustomPostProcessPass();
        }
    }
}