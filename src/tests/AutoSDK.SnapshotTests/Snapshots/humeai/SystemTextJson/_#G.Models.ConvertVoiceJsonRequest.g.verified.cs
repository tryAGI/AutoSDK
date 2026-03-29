//HintName: G.Models.ConvertVoiceJsonRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertVoiceJsonRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_audio")]
        public string? SourceAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_voice_id")]
        public string? SourceVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_voice_id")]
        public string? TargetVoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_voice_name")]
        public string? TargetVoiceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertVoiceJsonRequest" /> class.
        /// </summary>
        /// <param name="sourceAudio"></param>
        /// <param name="sourceVoiceId"></param>
        /// <param name="targetVoiceId"></param>
        /// <param name="targetVoiceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertVoiceJsonRequest(
            string? sourceAudio,
            string? sourceVoiceId,
            string? targetVoiceId,
            string? targetVoiceName)
        {
            this.SourceAudio = sourceAudio;
            this.SourceVoiceId = sourceVoiceId;
            this.TargetVoiceId = targetVoiceId;
            this.TargetVoiceName = targetVoiceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertVoiceJsonRequest" /> class.
        /// </summary>
        public ConvertVoiceJsonRequest()
        {
        }
    }
}