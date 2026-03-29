//HintName: G.Models.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems
    {
        /// <summary>
        /// The id of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The text for the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The start time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the segment in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// The speaker of the segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the segment.
        /// </param>
        /// <param name="text">
        /// The text for the segment.
        /// </param>
        /// <param name="start">
        /// The start time of the segment in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the segment in seconds.
        /// </param>
        /// <param name="speaker">
        /// The speaker of the segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems(
            int? id,
            string? text,
            double? start,
            double? end,
            string? speaker)
        {
            this.Id = id;
            this.Text = text;
            this.Start = start;
            this.End = end;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems" /> class.
        /// </summary>
        public AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems()
        {
        }
    }
}