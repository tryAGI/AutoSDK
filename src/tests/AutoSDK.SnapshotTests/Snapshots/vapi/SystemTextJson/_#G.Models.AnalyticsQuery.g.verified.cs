//HintName: G.Models.AnalyticsQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQuery
    {
        /// <summary>
        /// This is the table you want to query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnalyticsQueryTableJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnalyticsQueryTable Table { get; set; }

        /// <summary>
        /// This is the list of columns you want to group by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public global::System.Collections.Generic.IList<global::G.AnalyticsQueryGroupByItem>? GroupBy { get; set; }

        /// <summary>
        /// This is the list of variable value keys you want to group by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupByVariableValue")]
        public global::System.Collections.Generic.IList<global::G.VariableValueGroupBy>? GroupByVariableValue { get; set; }

        /// <summary>
        /// This is the name of the query. This will be used to identify the query in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the time range for the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::G.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// This is the list of operations you want to perform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnalyticsOperation> Operations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQuery" /> class.
        /// </summary>
        /// <param name="table">
        /// This is the table you want to query.
        /// </param>
        /// <param name="name">
        /// This is the name of the query. This will be used to identify the query in the response.
        /// </param>
        /// <param name="operations">
        /// This is the list of operations you want to perform.
        /// </param>
        /// <param name="groupBy">
        /// This is the list of columns you want to group by.
        /// </param>
        /// <param name="groupByVariableValue">
        /// This is the list of variable value keys you want to group by.
        /// </param>
        /// <param name="timeRange">
        /// This is the time range for the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQuery(
            global::G.AnalyticsQueryTable table,
            string name,
            global::System.Collections.Generic.IList<global::G.AnalyticsOperation> operations,
            global::System.Collections.Generic.IList<global::G.AnalyticsQueryGroupByItem>? groupBy,
            global::System.Collections.Generic.IList<global::G.VariableValueGroupBy>? groupByVariableValue,
            global::G.TimeRange? timeRange)
        {
            this.Table = table;
            this.GroupBy = groupBy;
            this.GroupByVariableValue = groupByVariableValue;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TimeRange = timeRange;
            this.Operations = operations ?? throw new global::System.ArgumentNullException(nameof(operations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQuery" /> class.
        /// </summary>
        public AnalyticsQuery()
        {
        }
    }
}