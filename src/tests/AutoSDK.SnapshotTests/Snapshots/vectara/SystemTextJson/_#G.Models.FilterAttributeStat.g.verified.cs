//HintName: G.Models.FilterAttributeStat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregation result for a single filter attribute, showing the distribution of values and optional statistics for numeric types.
    /// </summary>
    public sealed partial class FilterAttributeStat
    {
        /// <summary>
        /// The qualified field name in the format 'level.fieldname' (e.g., 'doc.category' for document-level or 'part.status' for part-level metadata). This name can be used in metadata filter expressions.<br/>
        /// Example: doc.category
        /// </summary>
        /// <example>doc.category</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The data type of this filter attribute, which determines the aggregation behavior. Numeric types (integer, real_number, and their list variants) include statistical aggregations, while text and boolean types provide value distributions.<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterAttributeStatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterAttributeStatType Type { get; set; }

        /// <summary>
        /// Human-readable description of what this field represents, as defined in the corpus filter attribute schema. May be empty if no description was provided during corpus creation.<br/>
        /// Example: The category of the document (e.g., contract, invoice, report).
        /// </summary>
        /// <example>The category of the document (e.g., contract, invoice, report).</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Array of the most frequently occurring distinct values for this field, ordered by occurrence count (descending). Limited by the max_values query parameter. For list-type attributes, each array element is counted independently.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FilterAttributeValue> Values { get; set; }

        /// <summary>
        /// Statistical aggregations for numeric filter attributes (integer, real_number, and their list variants). Provides summary statistics across all values in the corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::G.FilterAttributeNumericStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeStat" /> class.
        /// </summary>
        /// <param name="name">
        /// The qualified field name in the format 'level.fieldname' (e.g., 'doc.category' for document-level or 'part.status' for part-level metadata). This name can be used in metadata filter expressions.<br/>
        /// Example: doc.category
        /// </param>
        /// <param name="type">
        /// The data type of this filter attribute, which determines the aggregation behavior. Numeric types (integer, real_number, and their list variants) include statistical aggregations, while text and boolean types provide value distributions.<br/>
        /// Example: text
        /// </param>
        /// <param name="description">
        /// Human-readable description of what this field represents, as defined in the corpus filter attribute schema. May be empty if no description was provided during corpus creation.<br/>
        /// Example: The category of the document (e.g., contract, invoice, report).
        /// </param>
        /// <param name="values">
        /// Array of the most frequently occurring distinct values for this field, ordered by occurrence count (descending). Limited by the max_values query parameter. For list-type attributes, each array element is counted independently.
        /// </param>
        /// <param name="stats">
        /// Statistical aggregations for numeric filter attributes (integer, real_number, and their list variants). Provides summary statistics across all values in the corpus.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterAttributeStat(
            string name,
            global::G.FilterAttributeStatType type,
            global::System.Collections.Generic.IList<global::G.FilterAttributeValue> values,
            string? description,
            global::G.FilterAttributeNumericStats? stats)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.Description = description;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeStat" /> class.
        /// </summary>
        public FilterAttributeStat()
        {
        }
    }
}