//HintName: G.Models.UpdateBarInsightFromCallTableDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBarInsightFromCallTableDTO
    {
        /// <summary>
        /// This is the name of the Insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the type of the Insight.<br/>
        /// It is required to be `bar` to create a bar insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.UpdateBarInsightFromCallTableDTOType? Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("formulas")]
        public global::System.Collections.Generic.IList<global::G.InsightFormula>? Formulas { get; set; }

        /// <summary>
        /// This is the metadata for the insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.BarInsightMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeRange")]
        public global::G.InsightTimeRangeWithStep? TimeRange { get; set; }

        /// <summary>
        /// This is the group by column for the insight when table is `call`.<br/>
        /// These are the columns to group the results by.<br/>
        /// All results are grouped by the time range step by default.<br/>
        /// Example: [assistant_id]
        /// </summary>
        /// <example>[assistant_id]</example>
        [global::Newtonsoft.Json.JsonProperty("groupBy")]
        public global::G.UpdateBarInsightFromCallTableDTOGroupBy? GroupBy { get; set; }

        /// <summary>
        /// These are the queries to run to generate the insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn, global::G.JSONQueryOnEventsTable>>? Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBarInsightFromCallTableDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the Insight.
        /// </param>
        /// <param name="type">
        /// This is the type of the Insight.<br/>
        /// It is required to be `bar` to create a bar insight.
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
        /// <param name="queries">
        /// These are the queries to run to generate the insight.
        /// </param>
        public UpdateBarInsightFromCallTableDTO(
            string? name,
            global::G.UpdateBarInsightFromCallTableDTOType? type,
            global::System.Collections.Generic.IList<global::G.InsightFormula>? formulas,
            global::G.BarInsightMetadata? metadata,
            global::G.InsightTimeRangeWithStep? timeRange,
            global::G.UpdateBarInsightFromCallTableDTOGroupBy? groupBy,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn, global::G.JSONQueryOnEventsTable>>? queries)
        {
            this.Name = name;
            this.Type = type;
            this.Formulas = formulas;
            this.Metadata = metadata;
            this.TimeRange = timeRange;
            this.GroupBy = groupBy;
            this.Queries = queries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBarInsightFromCallTableDTO" /> class.
        /// </summary>
        public UpdateBarInsightFromCallTableDTO()
        {
        }
    }
}