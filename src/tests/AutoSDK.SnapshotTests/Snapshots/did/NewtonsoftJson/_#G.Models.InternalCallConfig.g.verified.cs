//HintName: G.Models.InternalCallConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalCallConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_owner_id")]
        public string? AvatarOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_mode")]
        public global::G.InternalCallConfigInferenceMode? InferenceMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_logo")]
        public bool? NoLogo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_without_audio")]
        public bool? ResultWithoutAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCallConfig" /> class.
        /// </summary>
        /// <param name="avatarOwnerId"></param>
        /// <param name="inferenceMode"></param>
        /// <param name="noLogo"></param>
        /// <param name="resultWithoutAudio"></param>
        public InternalCallConfig(
            string? avatarOwnerId,
            global::G.InternalCallConfigInferenceMode? inferenceMode,
            bool? noLogo,
            bool? resultWithoutAudio)
        {
            this.AvatarOwnerId = avatarOwnerId;
            this.InferenceMode = inferenceMode;
            this.NoLogo = noLogo;
            this.ResultWithoutAudio = resultWithoutAudio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCallConfig" /> class.
        /// </summary>
        public InternalCallConfig()
        {
        }
    }
}