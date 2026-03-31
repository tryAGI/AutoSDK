//HintName: G.Models.DatasetEventClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetEventClassification
    {
        /// <summary>
        /// Stable classification identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Original label of the classification item, which is useful for search and indexing purposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optional confidence score for the classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Optional metadata associated with the classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Metadata { get; set; }

        /// <summary>
        /// Optional function identifier that produced the classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SavedFunctionIdJsonConverter))]
        public global::G.SavedFunctionId? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetEventClassification" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetEventClassification(
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
        /// Initializes a new instance of the <see cref="DatasetEventClassification" /> class.
        /// </summary>
        public DatasetEventClassification()
        {
        }
    }
}