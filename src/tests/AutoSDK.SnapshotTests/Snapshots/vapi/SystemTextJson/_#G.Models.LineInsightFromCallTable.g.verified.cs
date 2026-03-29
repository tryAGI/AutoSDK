//HintName: G.Models.LineInsightFromCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LineInsightFromCallTable
    {
        /// <summary>
        /// This is the name of the Insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the type of the Insight.<br/>
        /// It is required to be `line` to create a line insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LineInsightFromCallTableTypeJsonConverter))]
        public global::G.LineInsightFromCallTableType Type { get; set; }

        /// <summary>
        /// Formulas are mathematical expressions applied on the data returned by the queries to transform them before being used to create the insight.<br/>
        /// The formulas needs to be a valid mathematical expression, supported by MathJS - https://mathjs.org/docs/expressions/syntax.html<br/>
        /// A formula is created by using the query names as the variable.<br/>
        /// The formulas must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
        /// For example, if you have 2 queries, 'Was Booking Made' and 'Average Call Duration', you can create a formula like this:<br/>
        /// ```<br/>
        /// {{['Query 1']}} / {{['Query 2']}} * 100<br/>
        /// ```<br/>
        /// ```<br/>
        /// ({{[Query 1]}} * 10) + {{[Query 2]}}<br/>
        /// ```<br/>
        /// This will take the<br/>
        /// You can also use the query names as the variable in the formula.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formulas")]
        public global::System.Collections.Generic.IList<global::G.InsightFormula>? Formulas { get; set; }

        /// <summary>
        /// This is the metadata for the insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.LineInsightMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::G.InsightTimeRangeWithStep? TimeRange { get; set; }

        /// <summary>
        /// This is the group by column for the insight when table is `call`.<br/>
        /// These are the columns to group the results by.<br/>
        /// All results are grouped by the time range step by default.<br/>
        /// Example: [assistant_id]
        /// </summary>
        /// <example>[assistant_id]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LineInsightFromCallTableGroupByJsonConverter))]
        public global::G.LineInsightFromCallTableGroupBy? GroupBy { get; set; }

        /// <summary>
        /// These are the queries to run to generate the insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn>> Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LineInsightFromCallTable" /> class.
        /// </summary>
        /// <param name="queries">
        /// These are the queries to run to generate the insight.
        /// </param>
        /// <param name="name">
        /// This is the name of the Insight.
        /// </param>
        /// <param name="type">
        /// This is the type of the Insight.<br/>
        /// It is required to be `line` to create a line insight.
        /// </param>
        /// <param name="formulas">
        /// Formulas are mathematical expressions applied on the data returned by the queries to transform them before being used to create the insight.<br/>
        /// The formulas needs to be a valid mathematical expression, supported by MathJS - https://mathjs.org/docs/expressions/syntax.html<br/>
        /// A formula is created by using the query names as the variable.<br/>
        /// The formulas must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
        /// For example, if you have 2 queries, 'Was Booking Made' and 'Average Call Duration', you can create a formula like this:<br/>
        /// ```<br/>
        /// {{['Query 1']}} / {{['Query 2']}} * 100<br/>
        /// ```<br/>
        /// ```<br/>
        /// ({{[Query 1]}} * 10) + {{[Query 2]}}<br/>
        /// ```<br/>
        /// This will take the<br/>
        /// You can also use the query names as the variable in the formula.
        /// </param>
        /// <param name="metadata">
        /// This is the metadata for the insight.
        /// </param>
        /// <param name="timeRange"></param>
        /// <param name="groupBy">
        /// This is the group by column for the insight when table is `call`.<br/>
        /// These are the columns to group the results by.<br/>
        /// All results are grouped by the time range step by default.<br/>
        /// Example: [assistant_id]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LineInsightFromCallTable(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn>> queries,
            string? name,
            global::G.LineInsightFromCallTableType type,
            global::System.Collections.Generic.IList<global::G.InsightFormula>? formulas,
            global::G.LineInsightMetadata? metadata,
            global::G.InsightTimeRangeWithStep? timeRange,
            global::G.LineInsightFromCallTableGroupBy? groupBy)
        {
            this.Name = name;
            this.Type = type;
            this.Formulas = formulas;
            this.Metadata = metadata;
            this.TimeRange = timeRange;
            this.GroupBy = groupBy;
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineInsightFromCallTable" /> class.
        /// </summary>
        public LineInsightFromCallTable()
        {
        }
    }
}