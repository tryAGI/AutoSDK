//HintName: G.Models.AudioWithTimestampsAndVoiceSegmentsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"alignment":{"character_end_times_seconds":[0.1,0.2,0.3,0.4,0.5,0.6,0.7],"character_start_times_seconds":[0.0,0.1,0.2,0.3,0.4,0.5,0.6],"characters":["H","e","l","l","o","H","i"]},"audio_base64":"base64_encoded_audio_string","normalized_alignment":{"character_end_times_seconds":[0.1,0.2,0.3,0.4,0.5,0.6,0.7],"character_start_times_seconds":[0.0,0.1,0.2,0.3,0.4,0.5,0.6],"characters":["H","e","l","l","o","H","i"]},"voice_segments":[{"character_end_index":5,"character_start_index":0,"dialogue_input_index":0,"end_time_seconds":0.5,"start_time_seconds":0.0,"voice_id":"21m00Tcm4TlvDq8ikWAM"},{"character_end_index":7,"character_start_index":5,"dialogue_input_index":1,"end_time_seconds":0.7,"start_time_seconds":0.5,"voice_id":"VEDscrYI8uIMttlO2Ztu"}]}
    /// </summary>
    public sealed partial class AudioWithTimestampsAndVoiceSegmentsResponseModel
    {
        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioBase64 { get; set; }

        /// <summary>
        /// Timestamp information for each character in the original text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        public global::G.CharacterAlignmentResponseModel? Alignment { get; set; }

        /// <summary>
        /// Timestamp information for each character in the normalized text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_alignment")]
        public global::G.CharacterAlignmentResponseModel? NormalizedAlignment { get; set; }

        /// <summary>
        /// Voice segments for the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VoiceSegment> VoiceSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioWithTimestampsAndVoiceSegmentsResponseModel" /> class.
        /// </summary>
        /// <param name="audioBase64">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="voiceSegments">
        /// Voice segments for the audio
        /// </param>
        /// <param name="alignment">
        /// Timestamp information for each character in the original text
        /// </param>
        /// <param name="normalizedAlignment">
        /// Timestamp information for each character in the normalized text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioWithTimestampsAndVoiceSegmentsResponseModel(
            string audioBase64,
            global::System.Collections.Generic.IList<global::G.VoiceSegment> voiceSegments,
            global::G.CharacterAlignmentResponseModel? alignment,
            global::G.CharacterAlignmentResponseModel? normalizedAlignment)
        {
            this.AudioBase64 = audioBase64 ?? throw new global::System.ArgumentNullException(nameof(audioBase64));
            this.Alignment = alignment;
            this.NormalizedAlignment = normalizedAlignment;
            this.VoiceSegments = voiceSegments ?? throw new global::System.ArgumentNullException(nameof(voiceSegments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioWithTimestampsAndVoiceSegmentsResponseModel" /> class.
        /// </summary>
        public AudioWithTimestampsAndVoiceSegmentsResponseModel()
        {
        }
    }
}