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
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_owner_id")]
        public string? AvatarOwnerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InternalCallConfigInferenceModeJsonConverter))]
        public global::G.InternalCallConfigInferenceMode? InferenceMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_logo")]
        public bool? NoLogo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_without_audio")]
        public bool? ResultWithoutAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalCallConfig" /> class.
        /// </summary>
        /// <param name="avatarOwnerId"></param>
        /// <param name="inferenceMode"></param>
        /// <param name="noLogo"></param>
        /// <param name="resultWithoutAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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