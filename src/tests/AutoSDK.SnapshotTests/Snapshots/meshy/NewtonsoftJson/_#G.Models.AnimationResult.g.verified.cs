//HintName: G.Models.AnimationResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnimationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation_glb_url")]
        public string? AnimationGlbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation_fbx_url")]
        public string? AnimationFbxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed_usdz_url")]
        public string? ProcessedUsdzUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed_armature_fbx_url")]
        public string? ProcessedArmatureFbxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed_animation_fps_fbx_url")]
        public string? ProcessedAnimationFpsFbxUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationResult" /> class.
        /// </summary>
        /// <param name="animationGlbUrl"></param>
        /// <param name="animationFbxUrl"></param>
        /// <param name="processedUsdzUrl"></param>
        /// <param name="processedArmatureFbxUrl"></param>
        /// <param name="processedAnimationFpsFbxUrl"></param>
        public AnimationResult(
            string? animationGlbUrl,
            string? animationFbxUrl,
            string? processedUsdzUrl,
            string? processedArmatureFbxUrl,
            string? processedAnimationFpsFbxUrl)
        {
            this.AnimationGlbUrl = animationGlbUrl;
            this.AnimationFbxUrl = animationFbxUrl;
            this.ProcessedUsdzUrl = processedUsdzUrl;
            this.ProcessedArmatureFbxUrl = processedArmatureFbxUrl;
            this.ProcessedAnimationFpsFbxUrl = processedAnimationFpsFbxUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimationResult" /> class.
        /// </summary>
        public AnimationResult()
        {
        }
    }
}