//HintName: G.Models.QueryGroupedExamplesWithRuns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryGroupedExamplesWithRuns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GroupExampleRunsByFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GroupExampleRunsByField GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetadataKey { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_group_limit")]
        public int? PerGroupLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryGroupedExamplesWithRuns" /> class.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="metadataKey"></param>
        /// <param name="perGroupLimit">
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryGroupedExamplesWithRuns(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::G.GroupExampleRunsByField groupBy,
            string metadataKey,
            int? offset,
            int? limit,
            bool? preview,
            int? perGroupLimit)
        {
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
            this.GroupBy = groupBy;
            this.MetadataKey = metadataKey ?? throw new global::System.ArgumentNullException(nameof(metadataKey));
            this.Offset = offset;
            this.Limit = limit;
            this.Preview = preview;
            this.PerGroupLimit = perGroupLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryGroupedExamplesWithRuns" /> class.
        /// </summary>
        public QueryGroupedExamplesWithRuns()
        {
        }
    }
}