//HintName: G.Models.QueryExampleSchemaWithRuns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryExampleSchemaWithRuns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public global::System.Guid? ComparativeExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRuns" /> class.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public QueryExampleSchemaWithRuns(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::System.Guid? comparativeExperimentId,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters,
            int? offset,
            int? limit)
        {
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
            this.ComparativeExperimentId = comparativeExperimentId;
            this.Filters = filters;
            this.Offset = offset;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRuns" /> class.
        /// </summary>
        public QueryExampleSchemaWithRuns()
        {
        }
    }
}