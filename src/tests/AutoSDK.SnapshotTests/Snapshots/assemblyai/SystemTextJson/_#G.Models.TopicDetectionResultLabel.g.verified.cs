//HintName: G.Models.TopicDetectionResultLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicDetectionResultLabel
    {
        /// <summary>
        /// How relevant the detected topic is of a detected topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Relevance { get; set; }

        /// <summary>
        /// The IAB taxonomical label for the label of the detected topic, where &gt; denotes supertopic/subtopic relationship
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResultLabel" /> class.
        /// </summary>
        /// <param name="relevance">
        /// How relevant the detected topic is of a detected topic
        /// </param>
        /// <param name="label">
        /// The IAB taxonomical label for the label of the detected topic, where &gt; denotes supertopic/subtopic relationship
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDetectionResultLabel(
            double relevance,
            string label)
        {
            this.Relevance = relevance;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDetectionResultLabel" /> class.
        /// </summary>
        public TopicDetectionResultLabel()
        {
        }
    }
}