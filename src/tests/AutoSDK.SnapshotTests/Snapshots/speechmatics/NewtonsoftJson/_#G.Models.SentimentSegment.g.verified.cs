//HintName: G.Models.SentimentSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a segment of text and its associated sentiment.
    /// </summary>
    public sealed partial class SentimentSegment
    {
        /// <summary>
        /// Represents the transcript of the analysed segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The assigned sentiment to the segment, which can be positive, neutral or negative
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment")]
        public string? Sentiment { get; set; }

        /// <summary>
        /// The timestamp corresponding to the beginning of the transcription segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time")]
        public float? StartTime { get; set; }

        /// <summary>
        /// The timestamp corresponding to the end of the transcription segment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time")]
        public float? EndTime { get; set; }

        /// <summary>
        /// The speaker label for the segment, if speaker diarization is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// The channel label for the segment, if channel diarization is enabled
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// A confidence score in the range of 0-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public float? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSegment" /> class.
        /// </summary>
        /// <param name="text">
        /// Represents the transcript of the analysed segment
        /// </param>
        /// <param name="sentiment">
        /// The assigned sentiment to the segment, which can be positive, neutral or negative
        /// </param>
        /// <param name="startTime">
        /// The timestamp corresponding to the beginning of the transcription segment
        /// </param>
        /// <param name="endTime">
        /// The timestamp corresponding to the end of the transcription segment
        /// </param>
        /// <param name="speaker">
        /// The speaker label for the segment, if speaker diarization is enabled
        /// </param>
        /// <param name="channel">
        /// The channel label for the segment, if channel diarization is enabled
        /// </param>
        /// <param name="confidence">
        /// A confidence score in the range of 0-1
        /// </param>
        public SentimentSegment(
            string? text,
            string? sentiment,
            float? startTime,
            float? endTime,
            string? speaker,
            string? channel,
            float? confidence)
        {
            this.Text = text;
            this.Sentiment = sentiment;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Speaker = speaker;
            this.Channel = channel;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSegment" /> class.
        /// </summary>
        public SentimentSegment()
        {
        }
    }
}