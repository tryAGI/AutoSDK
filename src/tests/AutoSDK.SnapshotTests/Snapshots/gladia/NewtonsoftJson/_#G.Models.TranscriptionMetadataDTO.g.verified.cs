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
        [global::Newtonsoft.Json.JsonProperty("audio_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double AudioDuration { get; set; } = default!;

        /// <summary>
        /// Number of distinct channels in the transcribed audio file<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("number_of_distinct_channels", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumberOfDistinctChannels { get; set; } = default!;

        /// <summary>
        /// Billed duration in seconds (audio_duration * number_of_distinct_channels)<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::Newtonsoft.Json.JsonProperty("billing_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double BillingTime { get; set; } = default!;

        /// <summary>
        /// Duration of the transcription in seconds<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::Newtonsoft.Json.JsonProperty("transcription_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double TranscriptionTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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