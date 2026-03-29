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
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Files { get; set; } = default!;

        /// <summary>
        /// Name for the cloned voice
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceName { get; set; } = default!;

        /// <summary>
        /// Voice provider to use for cloning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_provider", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CloneVoiceRequestVoiceProvider VoiceProvider { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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