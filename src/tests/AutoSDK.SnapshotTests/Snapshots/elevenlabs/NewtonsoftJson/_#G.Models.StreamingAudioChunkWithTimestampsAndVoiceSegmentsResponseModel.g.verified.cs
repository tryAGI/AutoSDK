//HintName: G.Models.StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"alignment":{"character_end_times_seconds":[0.1,0.2],"character_start_times_seconds":[0.0,0.1],"characters":["H","e"]},"audio_base64":"base64_encoded_audio_chunk","normalized_alignment":{"character_end_times_seconds":[0.1,0.2],"character_start_times_seconds":[0.0,0.1],"characters":["H","e"]},"voice_segments":[{"character_end_index":2,"character_start_index":0,"dialogue_input_index":0,"end_time_seconds":0.2,"start_time_seconds":0.0,"voice_id":"VEDscrYI8uIMttlO2Ztu"}]}
    /// </summary>
    public sealed partial class StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel
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
        /// Voice segments for the audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_segments", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceSegment> VoiceSegments { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel" /> class.
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
        public StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel(
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
        /// Initializes a new instance of the <see cref="StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel" /> class.
        /// </summary>
        public StreamingAudioChunkWithTimestampsAndVoiceSegmentsResponseModel()
        {
        }
    }
}