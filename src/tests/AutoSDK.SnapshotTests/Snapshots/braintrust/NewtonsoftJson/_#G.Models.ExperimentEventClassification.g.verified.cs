//HintName: G.Models.ExperimentEventClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentEventClassification
    {
        /// <summary>
        /// Stable classification identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Original label of the classification item, which is useful for search and indexing purposes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optional confidence score for the classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Optional metadata associated with the classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Optional function identifier that produced the classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.SavedFunctionId? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentEventClassification" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable classification identifier
        /// </param>
        /// <param name="label">
        /// Original label of the classification item, which is useful for search and indexing purposes
        /// </param>
        /// <param name="confidence">
        /// Optional confidence score for the classification
        /// </param>
        /// <param name="metadata">
        /// Optional metadata associated with the classification
        /// </param>
        /// <param name="source">
        /// Optional function identifier that produced the classification
        /// </param>
        public ExperimentEventClassification(
            string id,
            string? label,
            double? confidence,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata,
            global::G.SavedFunctionId? source)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label;
            this.Confidence = confidence;
            this.Metadata = metadata;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentEventClassification" /> class.
        /// </summary>
        public ExperimentEventClassification()
        {
        }
    }
}