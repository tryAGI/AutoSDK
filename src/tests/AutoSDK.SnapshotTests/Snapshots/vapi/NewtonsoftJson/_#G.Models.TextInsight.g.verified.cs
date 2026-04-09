//HintName: G.Models.TextInsight.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextInsight
    {
        /// <summary>
        /// This is the name of the Insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the type of the Insight.<br/>
        /// It is required to be `text` to create a text insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TextInsightTypeJsonConverter))]
        public global::G.TextInsightType Type { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("formula")]
        public object? Formula { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeRange")]
        public global::G.InsightTimeRange? TimeRange { get; set; }

        /// <summary>
        /// These are the queries to run to generate the insight.<br/>
        /// For Text Insights, we only allow a single query, or require a formula if multiple queries are provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn>> Queries { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the Insight.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this Insight belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the Insight was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the Insight was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInsight" /> class.
        /// </summary>
        /// <param name="queries">
        /// These are the queries to run to generate the insight.<br/>
        /// For Text Insights, we only allow a single query, or require a formula if multiple queries are provided
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the Insight.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this Insight belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the Insight was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the Insight was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the Insight.
        /// </param>
        /// <param name="type">
        /// This is the type of the Insight.<br/>
        /// It is required to be `text` to create a text insight.
        /// </param>
        /// <param name="formula">
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
        public TextInsight(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn>> queries,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            global::G.TextInsightType type,
            object? formula,
            global::G.InsightTimeRange? timeRange)
        {
            this.Name = name;
            this.Type = type;
            this.Formula = formula;
            this.TimeRange = timeRange;
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInsight" /> class.
        /// </summary>
        public TextInsight()
        {
        }
    }
}