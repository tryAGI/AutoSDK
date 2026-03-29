//HintName: G.Models.BarInsight.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BarInsight
    {
        /// <summary>
        /// This is the name of the Insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the type of the Insight.<br/>
        /// It is required to be `bar` to create a bar insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BarInsightTypeJsonConverter))]
        public global::G.BarInsightType Type { get; set; }

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
        public global::G.BarInsightMetadata? Metadata { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BarInsightGroupByJsonConverter))]
        public global::G.BarInsightGroupBy? GroupBy { get; set; }

        /// <summary>
        /// These are the queries to run to generate the insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn, global::G.JSONQueryOnEventsTable>> Queries { get; set; }

        /// <summary>
        /// This is the unique identifier for the Insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this Insight belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the Insight was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the Insight was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BarInsight" /> class.
        /// </summary>
        /// <param name="queries">
        /// These are the queries to run to generate the insight.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BarInsight(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.JSONQueryOnCallTableWithStringTypeColumn, global::G.JSONQueryOnCallTableWithNumberTypeColumn, global::G.JSONQueryOnCallTableWithStructuredOutputColumn, global::G.JSONQueryOnEventsTable>> queries,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            global::G.BarInsightType type,
            global::System.Collections.Generic.IList<global::G.InsightFormula>? formulas,
            global::G.BarInsightMetadata? metadata,
            global::G.InsightTimeRangeWithStep? timeRange,
            global::G.BarInsightGroupBy? groupBy)
        {
            this.Name = name;
            this.Type = type;
            this.Formulas = formulas;
            this.Metadata = metadata;
            this.TimeRange = timeRange;
            this.GroupBy = groupBy;
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarInsight" /> class.
        /// </summary>
        public BarInsight()
        {
        }
    }
}