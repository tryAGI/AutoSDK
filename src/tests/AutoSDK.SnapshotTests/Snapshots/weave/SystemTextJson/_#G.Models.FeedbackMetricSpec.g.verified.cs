//HintName: G.Models.FeedbackMetricSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a feedback payload metric to aggregate.
    /// </summary>
    public sealed partial class FeedbackMetricSpec
    {
        /// <summary>
        /// Dot path into payload_dump (e.g. 'output', 'output.score').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JsonPath { get; set; }

        /// <summary>
        /// Type of value at path. numeric: avg/min/max; boolean: count_true/count_false.<br/>
        /// Default Value: numeric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FeedbackMetricSpecValueTypeJsonConverter))]
        public global::G.FeedbackMetricSpecValueType? ValueType { get; set; }

        /// <summary>
        /// Aggregation functions to compute. If empty, defaults are chosen based on value_type: numeric-&gt;avg/min/max, boolean-&gt;count_true/count_false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregations")]
        public global::System.Collections.Generic.IList<global::G.AggregationType>? Aggregations { get; set; }

        /// <summary>
        /// Percentile values to compute (0–100), e.g. [5, 50, 95]. Only applicable for numeric value_type fields; ignored for boolean/categorical.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentiles")]
        public global::System.Collections.Generic.IList<double>? Percentiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackMetricSpec" /> class.
        /// </summary>
        /// <param name="jsonPath">
        /// Dot path into payload_dump (e.g. 'output', 'output.score').
        /// </param>
        /// <param name="valueType">
        /// Type of value at path. numeric: avg/min/max; boolean: count_true/count_false.<br/>
        /// Default Value: numeric
        /// </param>
        /// <param name="aggregations">
        /// Aggregation functions to compute. If empty, defaults are chosen based on value_type: numeric-&gt;avg/min/max, boolean-&gt;count_true/count_false.
        /// </param>
        /// <param name="percentiles">
        /// Percentile values to compute (0–100), e.g. [5, 50, 95]. Only applicable for numeric value_type fields; ignored for boolean/categorical.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackMetricSpec(
            string jsonPath,
            global::G.FeedbackMetricSpecValueType? valueType,
            global::System.Collections.Generic.IList<global::G.AggregationType>? aggregations,
            global::System.Collections.Generic.IList<double>? percentiles)
        {
            this.JsonPath = jsonPath ?? throw new global::System.ArgumentNullException(nameof(jsonPath));
            this.ValueType = valueType;
            this.Aggregations = aggregations;
            this.Percentiles = percentiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackMetricSpec" /> class.
        /// </summary>
        public FeedbackMetricSpec()
        {
        }
    }
}