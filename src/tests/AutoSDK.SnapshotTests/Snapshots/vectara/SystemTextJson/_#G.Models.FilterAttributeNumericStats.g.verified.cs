//HintName: G.Models.FilterAttributeNumericStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Statistical aggregations for numeric filter attributes (integer, real_number, and their list variants). Provides summary statistics across all values in the corpus.
    /// </summary>
    public sealed partial class FilterAttributeNumericStats
    {
        /// <summary>
        /// Minimum value found across all documents or parts for this numeric field.<br/>
        /// Example: 2020
        /// </summary>
        /// <example>2020</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        /// Maximum value found across all documents or parts for this numeric field.<br/>
        /// Example: 2024
        /// </summary>
        /// <example>2024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        /// Average (mean) value across all documents or parts for this numeric field. For list types, all individual values are included in the calculation.<br/>
        /// Example: 2022.5
        /// </summary>
        /// <example>2022.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Avg { get; set; }

        /// <summary>
        /// Sum of all values across all documents or parts for this numeric field. For list types, all individual values are included in the sum.<br/>
        /// Example: 8090
        /// </summary>
        /// <example>8090</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Sum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeNumericStats" /> class.
        /// </summary>
        /// <param name="min">
        /// Minimum value found across all documents or parts for this numeric field.<br/>
        /// Example: 2020
        /// </param>
        /// <param name="max">
        /// Maximum value found across all documents or parts for this numeric field.<br/>
        /// Example: 2024
        /// </param>
        /// <param name="avg">
        /// Average (mean) value across all documents or parts for this numeric field. For list types, all individual values are included in the calculation.<br/>
        /// Example: 2022.5
        /// </param>
        /// <param name="sum">
        /// Sum of all values across all documents or parts for this numeric field. For list types, all individual values are included in the sum.<br/>
        /// Example: 8090
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterAttributeNumericStats(
            double min,
            double max,
            double avg,
            double sum)
        {
            this.Min = min;
            this.Max = max;
            this.Avg = avg;
            this.Sum = sum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeNumericStats" /> class.
        /// </summary>
        public FilterAttributeNumericStats()
        {
        }
    }
}