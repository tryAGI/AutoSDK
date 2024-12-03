//HintName: G.Models.ParagraphsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParagraphsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double AudioDuration { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paragraphs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TranscriptParagraph> Paragraphs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="confidence"></param>
        /// <param name="audioDuration"></param>
        /// <param name="paragraphs"></param>
        public ParagraphsResponse(
            global::System.Guid id,
            double confidence,
            double audioDuration,
            global::System.Collections.Generic.IList<global::G.TranscriptParagraph> paragraphs)
        {
            this.Id = id;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Paragraphs = paragraphs ?? throw new global::System.ArgumentNullException(nameof(paragraphs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        public ParagraphsResponse()
        {
        }
    }
}