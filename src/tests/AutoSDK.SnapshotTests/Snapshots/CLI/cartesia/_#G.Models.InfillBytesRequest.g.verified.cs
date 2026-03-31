//HintName: G.Models.InfillBytesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InfillBytesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_audio")]
        public byte[]? LeftAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_audioname")]
        public string? LeftAudioname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_audio")]
        public byte[]? RightAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("right_audioname")]
        public string? RightAudioname { get; set; }

        /// <summary>
        /// The ID of the model to use for generating audio. Any model other than the first `"sonic"` model is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The language of the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The infill text to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The ID of the voice to use for generating audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputFormatJsonConverter))]
        public global::G.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InfillBytesRequest" /> class.
        /// </summary>
        /// <param name="leftAudio"></param>
        /// <param name="leftAudioname"></param>
        /// <param name="rightAudio"></param>
        /// <param name="rightAudioname"></param>
        /// <param name="modelId">
        /// The ID of the model to use for generating audio. Any model other than the first `"sonic"` model is supported.
        /// </param>
        /// <param name="language">
        /// The language of the transcript
        /// </param>
        /// <param name="transcript">
        /// The infill text to generate
        /// </param>
        /// <param name="voiceId">
        /// The ID of the voice to use for generating audio
        /// </param>
        /// <param name="outputFormat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InfillBytesRequest(
            byte[]? leftAudio,
            string? leftAudioname,
            byte[]? rightAudio,
            string? rightAudioname,
            string? modelId,
            string? language,
            string? transcript,
            string? voiceId,
            global::G.OutputFormat? outputFormat)
        {
            this.LeftAudio = leftAudio;
            this.LeftAudioname = leftAudioname;
            this.RightAudio = rightAudio;
            this.RightAudioname = rightAudioname;
            this.ModelId = modelId;
            this.Language = language;
            this.Transcript = transcript;
            this.VoiceId = voiceId;
            this.OutputFormat = outputFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfillBytesRequest" /> class.
        /// </summary>
        public InfillBytesRequest()
        {
        }
    }
}