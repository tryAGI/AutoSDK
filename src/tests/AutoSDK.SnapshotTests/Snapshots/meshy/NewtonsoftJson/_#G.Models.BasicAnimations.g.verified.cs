//HintName: G.Models.BasicAnimations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BasicAnimations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("walking_glb_url")]
        public string? WalkingGlbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("walking_fbx_url")]
        public string? WalkingFbxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("walking_armature_glb_url")]
        public string? WalkingArmatureGlbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running_glb_url")]
        public string? RunningGlbUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running_fbx_url")]
        public string? RunningFbxUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("running_armature_glb_url")]
        public string? RunningArmatureGlbUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAnimations" /> class.
        /// </summary>
        /// <param name="walkingGlbUrl"></param>
        /// <param name="walkingFbxUrl"></param>
        /// <param name="walkingArmatureGlbUrl"></param>
        /// <param name="runningGlbUrl"></param>
        /// <param name="runningFbxUrl"></param>
        /// <param name="runningArmatureGlbUrl"></param>
        public BasicAnimations(
            string? walkingGlbUrl,
            string? walkingFbxUrl,
            string? walkingArmatureGlbUrl,
            string? runningGlbUrl,
            string? runningFbxUrl,
            string? runningArmatureGlbUrl)
        {
            this.WalkingGlbUrl = walkingGlbUrl;
            this.WalkingFbxUrl = walkingFbxUrl;
            this.WalkingArmatureGlbUrl = walkingArmatureGlbUrl;
            this.RunningGlbUrl = runningGlbUrl;
            this.RunningFbxUrl = runningFbxUrl;
            this.RunningArmatureGlbUrl = runningArmatureGlbUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicAnimations" /> class.
        /// </summary>
        public BasicAnimations()
        {
        }
    }
}