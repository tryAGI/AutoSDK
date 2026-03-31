//HintName: G.Models.VoiceChangerBytesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceChangerBytesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clip")]
        public byte[]? Clip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clipname")]
        public string? Clipname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice[id]")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[container]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputFormatContainerJsonConverter))]
        public global::G.OutputFormatContainer? OutputFormatContainer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[sample_rate]")]
        public int? OutputFormatSampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[encoding]")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RawEncodingJsonConverter))]
        public global::G.RawEncoding? OutputFormatEncoding { get; set; }

        /// <summary>
        /// Required for `mp3` containers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format[bit_rate]")]
        public int? OutputFormatBitRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangerBytesRequest" /> class.
        /// </summary>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="voiceId"></param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate"></param>
        /// <param name="outputFormatEncoding"></param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceChangerBytesRequest(
            byte[]? clip,
            string? clipname,
            string? voiceId,
            global::G.OutputFormatContainer? outputFormatContainer,
            int? outputFormatSampleRate,
            global::G.RawEncoding? outputFormatEncoding,
            int? outputFormatBitRate)
        {
            this.Clip = clip;
            this.Clipname = clipname;
            this.VoiceId = voiceId;
            this.OutputFormatContainer = outputFormatContainer;
            this.OutputFormatSampleRate = outputFormatSampleRate;
            this.OutputFormatEncoding = outputFormatEncoding;
            this.OutputFormatBitRate = outputFormatBitRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceChangerBytesRequest" /> class.
        /// </summary>
        public VoiceChangerBytesRequest()
        {
        }
    }
}