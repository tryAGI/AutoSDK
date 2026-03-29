//HintName: G.Models.UpdatePieInsightFromCallTableDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePieInsightFromCallTableDTO
    {
        /// <summary>
        /// This is the name of the Insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the type of the Insight.<br/>
        /// It is required to be `pie` to create a pie insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdatePieInsightFromCallTableDTOTypeJsonConverter))]
        public global::G.UpdatePieInsightFromCallTableDTOType? Type { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::G.InsightTimeRange? TimeRange { get; set; }

        /// <summary>
        /// This is the group by column for the insight when table is `call`.<br/>
        /// These are the columns to group the results by.<br/>
        /// All results are grouped by the time range step by default.<br/>
        /// Example: [assistant_id]
        /// </summary>
        /// <example>[assistant_id]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdatePieInsightFromCallTableDTOGroupByJsonConverter))]
        public global::G.UpdatePieInsightFromCallTableDTOGroupBy? GroupBy { get; set; }

        /// <summary>
        /// These are the queries to run to generate the insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn>>? Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePieInsightFromCallTableDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the Insight.
        /// </param>
        /// <param name="type">
        /// This is the type of the Insight.<br/>
        /// It is required to be `pie` to create a pie insight.
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
        /// <param name="timeRange"></param>
        /// <param name="groupBy">
        /// This is the group by column for the insight when table is `call`.<br/>
        /// These are the columns to group the results by.<br/>
        /// All results are grouped by the time range step by default.<br/>
        /// Example: [assistant_id]
        /// </param>
        /// <param name="queries">
        /// These are the queries to run to generate the insight.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePieInsightFromCallTableDTO(
            string? name,
            global::G.UpdatePieInsightFromCallTableDTOType? type,
            global::System.Collections.Generic.IList<global::G.InsightFormula>? formulas,
            global::G.InsightTimeRange? timeRange,
            global::G.UpdatePieInsightFromCallTableDTOGroupBy? groupBy,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn>>? queries)
        {
            this.Name = name;
            this.Type = type;
            this.Formulas = formulas;
            this.TimeRange = timeRange;
            this.GroupBy = groupBy;
            this.Queries = queries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePieInsightFromCallTableDTO" /> class.
        /// </summary>
        public UpdatePieInsightFromCallTableDTO()
        {
        }
    }
}