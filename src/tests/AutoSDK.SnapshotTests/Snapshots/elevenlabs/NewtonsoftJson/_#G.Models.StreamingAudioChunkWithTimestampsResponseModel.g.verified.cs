//HintName: G.Models.StreamingAudioChunkWithTimestampsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingAudioChunkWithTimestampsResponseModel
    {
        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base64", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioBase64 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alignment")]
        public global::G.CharacterAlignmentResponseModel? Alignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized_alignment")]
        public global::G.CharacterAlignmentResponseModel? NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAudioChunkWithTimestampsResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="alignment"></param>
        /// <param name="normalizedAlignment"></param>
        public StreamingAudioChunkWithTimestampsResponseModel(
            string audioBase64,
            global::G.CharacterAlignmentResponseModel? alignment,
            global::G.CharacterAlignmentResponseModel? normalizedAlignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAudioChunkWithTimestampsResponseModel" /> class.
        /// </summary>
        public StreamingAudioChunkWithTimestampsResponseModel()
        {
        }
    }
}