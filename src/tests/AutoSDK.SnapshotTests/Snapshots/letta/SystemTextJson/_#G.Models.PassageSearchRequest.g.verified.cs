//HintName: G.Models.PassageSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for searching passages across archives.
    /// </summary>
    public sealed partial class PassageSearchRequest
    {
        /// <summary>
        /// Text query for semantic search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Filter passages by agent ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Filter passages by archive ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archive_id")]
        public string? ArchiveId { get; set; }

        /// <summary>
        /// Optional list of tags to filter search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
        /// Default Value: any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_match_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PassageSearchRequestTagMatchModeJsonConverter))]
        public global::G.PassageSearchRequestTagMatchMode? TagMatchMode { get; set; }

        /// <summary>
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Filter results to passages created after this datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Filter results to passages created before this datetime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Text query for semantic search
        /// </param>
        /// <param name="agentId">
        /// Filter passages by agent ID
        /// </param>
        /// <param name="archiveId">
        /// Filter passages by archive ID
        /// </param>
        /// <param name="tags">
        /// Optional list of tags to filter search results
        /// </param>
        /// <param name="tagMatchMode">
        /// How to match tags - 'any' to match passages with any of the tags, 'all' to match only passages with all tags<br/>
        /// Default Value: any
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// Filter results to passages created after this datetime
        /// </param>
        /// <param name="endDate">
        /// Filter results to passages created before this datetime
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassageSearchRequest(
            string? query,
            string? agentId,
            string? archiveId,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.PassageSearchRequestTagMatchMode? tagMatchMode,
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate)
        {
            this.Query = query;
            this.AgentId = agentId;
            this.ArchiveId = archiveId;
            this.Tags = tags;
            this.TagMatchMode = tagMatchMode;
            this.Limit = limit;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassageSearchRequest" /> class.
        /// </summary>
        public PassageSearchRequest()
        {
        }
    }
}