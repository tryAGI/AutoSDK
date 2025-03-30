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
        [global::Newtonsoft.Json.JsonProperty("session_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GroupExampleRunsByField GroupBy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetadataKey { get; set; } = default!;

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_group_limit")]
        public int? PerGroupLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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