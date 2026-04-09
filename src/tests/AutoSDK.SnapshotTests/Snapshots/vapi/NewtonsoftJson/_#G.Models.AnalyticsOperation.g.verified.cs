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
        [global::Newtonsoft.Json.JsonProperty("operation", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnalyticsOperationOperationJsonConverter))]
        public global::G.AnalyticsOperationOperation Operation { get; set; } = default!;

        /// <summary>
        /// This is the columns you want to perform the aggregation operation on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AnalyticsOperationColumnJsonConverter))]
        public global::G.AnalyticsOperationColumn Column { get; set; } = default!;

        /// <summary>
        /// This is the alias for column name returned. Defaults to `${operation}${column}`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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