//HintName: G.Models.TopicDetectionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Main object that holds topic detection results.<br/>
    /// Example: {"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"topics":[{"topic":"product"}]},{"text":"We will deploy this container for Spanish.","start_time":6,"end_time":12,"topics":[{"topic":"deployment"},{"topic":"languages"}]}],"summary":{"overall":{"deployment":1,"languages":1,"product":1}}}
    /// </summary>
    public sealed partial class TopicDetectionResult
    {
        /// <summary>
        /// An array of objects that represent a segment of text and its associated topic information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::G.TopicDetectionSegment>? Segments { get; set; }

        /// <summary>
        /// Holds overall information on the topics detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::G.TopicDetectionSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResult" /> class.
        /// </summary>
        /// <param name="segments">
        /// An array of objects that represent a segment of text and its associated topic information.
        /// </param>
        /// <param name="summary">
        /// Holds overall information on the topics detected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDetectionResult(
            global::System.Collections.Generic.IList<global::G.TopicDetectionSegment>? segments,
            global::G.TopicDetectionSummary? summary)
        {
            this.Segments = segments;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResult" /> class.
        /// </summary>
        public TopicDetectionResult()
        {
        }
    }
}