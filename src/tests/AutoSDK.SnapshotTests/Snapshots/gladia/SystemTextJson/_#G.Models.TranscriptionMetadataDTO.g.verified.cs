//HintName: G.Models.TranscriptionMetadataDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionMetadataDTO
    {
        /// <summary>
        /// Duration of the transcribed audio file<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioDuration { get; set; }

        /// <summary>
        /// Number of distinct channels in the transcribed audio file<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_distinct_channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfDistinctChannels { get; set; }

        /// <summary>
        /// Billed duration in seconds (audio_duration * number_of_distinct_channels)<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double BillingTime { get; set; }

        /// <summary>
        /// Duration of the transcription in seconds<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TranscriptionTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionMetadataDTO" /> class.
        /// </summary>
        /// <param name="audioDuration">
        /// Duration of the transcribed audio file<br/>
        /// Example: 3600
        /// </param>
        /// <param name="numberOfDistinctChannels">
        /// Number of distinct channels in the transcribed audio file<br/>
        /// Example: 1
        /// </param>
        /// <param name="billingTime">
        /// Billed duration in seconds (audio_duration * number_of_distinct_channels)<br/>
        /// Example: 3600
        /// </param>
        /// <param name="transcriptionTime">
        /// Duration of the transcription in seconds<br/>
        /// Example: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionMetadataDTO(
            double audioDuration,
            int numberOfDistinctChannels,
            double billingTime,
            double transcriptionTime)
        {
            this.AudioDuration = audioDuration;
            this.NumberOfDistinctChannels = numberOfDistinctChannels;
            this.BillingTime = billingTime;
            this.TranscriptionTime = transcriptionTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionMetadataDTO" /> class.
        /// </summary>
        public TranscriptionMetadataDTO()
        {
        }
    }
}