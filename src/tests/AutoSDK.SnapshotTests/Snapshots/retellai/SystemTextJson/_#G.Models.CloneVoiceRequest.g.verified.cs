//HintName: G.Models.CloneVoiceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneVoiceRequest
    {
        /// <summary>
        /// Audio files to use for voice cloning. Up to 25 files allowed. For Cartesia and MiniMax, only 1 file is supported. For Inworld, up to 3 files are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Name for the cloned voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// Voice provider to use for cloning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CloneVoiceRequestVoiceProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CloneVoiceRequestVoiceProvider VoiceProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Audio files to use for voice cloning. Up to 25 files allowed. For Cartesia and MiniMax, only 1 file is supported. For Inworld, up to 3 files are supported.
        /// </param>
        /// <param name="voiceName">
        /// Name for the cloned voice
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to use for cloning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloneVoiceRequest(
            global::System.Collections.Generic.IList<byte[]> files,
            string voiceName,
            global::G.CloneVoiceRequestVoiceProvider voiceProvider)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.VoiceName = voiceName ?? throw new global::System.ArgumentNullException(nameof(voiceName));
            this.VoiceProvider = voiceProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneVoiceRequest" /> class.
        /// </summary>
        public CloneVoiceRequest()
        {
        }
    }
}