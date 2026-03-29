//HintName: G.Models.MessageSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for searching messages across the organization
    /// </summary>
    public sealed partial class MessageSearchRequest
    {
        /// <summary>
        /// Text query for full-text search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Search mode to use<br/>
        /// Default Value: hybrid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageSearchRequestSearchModeJsonConverter))]
        public global::G.MessageSearchRequestSearchMode? SearchMode { get; set; }

        /// <summary>
        /// Filter messages by role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::G.MessageRole>? Roles { get; set; }

        /// <summary>
        /// Filter messages by agent ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Filter messages by project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Filter messages by template ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Filter messages by conversation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Filter messages created after this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Filter messages created on or before this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSearchRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Text query for full-text search
        /// </param>
        /// <param name="searchMode">
        /// Search mode to use<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="roles">
        /// Filter messages by role
        /// </param>
        /// <param name="agentId">
        /// Filter messages by agent ID
        /// </param>
        /// <param name="projectId">
        /// Filter messages by project ID
        /// </param>
        /// <param name="templateId">
        /// Filter messages by template ID
        /// </param>
        /// <param name="conversationId">
        /// Filter messages by conversation ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// Filter messages created after this date
        /// </param>
        /// <param name="endDate">
        /// Filter messages created on or before this date
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageSearchRequest(
            string? query,
            global::G.MessageSearchRequestSearchMode? searchMode,
            global::System.Collections.Generic.IList<global::G.MessageRole>? roles,
            string? agentId,
            string? projectId,
            string? templateId,
            string? conversationId,
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate)
        {
            this.Query = query;
            this.SearchMode = searchMode;
            this.Roles = roles;
            this.AgentId = agentId;
            this.ProjectId = projectId;
            this.TemplateId = templateId;
            this.ConversationId = conversationId;
            this.Limit = limit;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSearchRequest" /> class.
        /// </summary>
        public MessageSearchRequest()
        {
        }
    }
}