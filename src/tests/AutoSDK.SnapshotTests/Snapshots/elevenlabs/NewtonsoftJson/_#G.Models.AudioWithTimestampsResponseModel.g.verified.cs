//HintName: G.Models.AudioWithTimestampsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"alignment":{"character_end_times_seconds":[0.1,0.2,0.3,0.4,0.5],"character_start_times_seconds":[0,0.1,0.2,0.3,0.4],"characters":["H","e","l","l","o"]},"audio_base64":"base64_encoded_audio_string","normalized_alignment":{"character_end_times_seconds":[0.1,0.2,0.3,0.4,0.5],"character_start_times_seconds":[0,0.1,0.2,0.3,0.4],"characters":["H","e","l","l","o"]}}
    /// </summary>
    public sealed partial class AudioWithTimestampsResponseModel
    {
        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_base64", Required = global::Newtonsoft.Json.Required.Always)]
        public string AudioBase64 { get; set; } = default!;

        /// <summary>
        /// Timestamp information for each character in the original text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alignment")]
        public global::G.CharacterAlignmentResponseModel? Alignment { get; set; }

        /// <summary>
        /// Timestamp information for each character in the normalized text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalized_alignment")]
        public global::G.CharacterAlignmentResponseModel? NormalizedAlignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioWithTimestampsResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="alignment">
        /// Timestamp information for each character in the original text
        /// </param>
        /// <param name="normalizedAlignment">
        /// Timestamp information for each character in the normalized text
        /// </param>
        public AudioWithTimestampsResponseModel(
            string audioBase64,
            global::G.CharacterAlignmentResponseModel? alignment,
            global::G.CharacterAlignmentResponseModel? normalizedAlignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioWithTimestampsResponseModel" /> class.
        /// </summary>
        public AudioWithTimestampsResponseModel()
        {
        }
    }
}