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
        [global::Newtonsoft.Json.JsonProperty("relevance", Required = global::Newtonsoft.Json.Required.Always)]
        public double Relevance { get; set; } = default!;

        /// <summary>
        /// The IAB taxonomical label for the label of the detected topic, where &gt; denotes supertopic/subtopic relationship
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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