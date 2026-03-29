//HintName: G.Models.AnalyticsOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsOperation
    {
        /// <summary>
        /// This is the aggregation operation you want to perform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnalyticsOperationOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnalyticsOperationOperation Operation { get; set; }

        /// <summary>
        /// This is the columns you want to perform the aggregation operation on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnalyticsOperationColumnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnalyticsOperationColumn Column { get; set; }

        /// <summary>
        /// This is the alias for column name returned. Defaults to `${operation}${column}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsOperation" /> class.
        /// </summary>
        /// <param name="operation">
        /// This is the aggregation operation you want to perform.
        /// </param>
        /// <param name="column">
        /// This is the columns you want to perform the aggregation operation on.
        /// </param>
        /// <param name="alias">
        /// This is the alias for column name returned. Defaults to `${operation}${column}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsOperation(
            global::G.AnalyticsOperationOperation operation,
            global::G.AnalyticsOperationColumn column,
            string? alias)
        {
            this.Operation = operation;
            this.Column = column;
            this.Alias = alias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsOperation" /> class.
        /// </summary>
        public AnalyticsOperation()
        {
        }
    }
}