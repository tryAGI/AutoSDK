//HintName: G.Models.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems
    {
        /// <summary>
        /// The text for the word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The start time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the word in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end")]
        public double? End { get; set; }

        /// <summary>
        /// The speaker of the word.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems" /> class.
        /// </summary>
        /// <param name="text">
        /// The text for the word.
        /// </param>
        /// <param name="start">
        /// The start time of the word in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the word in seconds.
        /// </param>
        /// <param name="speaker">
        /// The speaker of the word.
        /// </param>
        public AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems(
            string? text,
            double? start,
            double? end,
            string? speaker)
        {
            this.Text = text;
            this.Start = start;
            this.End = end;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems" /> class.
        /// </summary>
        public AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems()
        {
        }
    }
}