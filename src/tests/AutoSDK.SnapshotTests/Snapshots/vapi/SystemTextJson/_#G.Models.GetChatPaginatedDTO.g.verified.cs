//HintName: G.Models.GetChatPaginatedDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChatPaginatedDTO
    {
        /// <summary>
        /// This is the unique identifier for the chat to filter by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the assistant that will be used for the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Filter by multiple assistant IDs. Provide as comma-separated values.<br/>
        /// Example: assistant-1,assistant-2,assistant-3
        /// </summary>
        /// <example>assistant-1,assistant-2,assistant-3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantIdAny")]
        public string? AssistantIdAny { get; set; }

        /// <summary>
        /// This is the unique identifier for the squad that will be used for the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the unique identifier for the session that will be used for the chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the unique identifier for the previous chat to filter by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousChatId")]
        public string? PreviousChatId { get; set; }

        /// <summary>
        /// This is the page number to return. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public double? Page { get; set; }

        /// <summary>
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetChatPaginatedDTOSortOrderJsonConverter))]
        public global::G.GetChatPaginatedDTOSortOrder? SortOrder { get; set; }

        /// <summary>
        /// This is the maximum number of items to return. Defaults to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtGt")]
        public global::System.DateTime? CreatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtLt")]
        public global::System.DateTime? CreatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtGe")]
        public global::System.DateTime? CreatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAtLe")]
        public global::System.DateTime? CreatedAtLe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAtGt")]
        public global::System.DateTime? UpdatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAtLt")]
        public global::System.DateTime? UpdatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAtGe")]
        public global::System.DateTime? UpdatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAtLe")]
        public global::System.DateTime? UpdatedAtLe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatPaginatedDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the chat to filter by.
        /// </param>
        /// <param name="assistantId">
        /// This is the unique identifier for the assistant that will be used for the chat.
        /// </param>
        /// <param name="assistantIdAny">
        /// Filter by multiple assistant IDs. Provide as comma-separated values.<br/>
        /// Example: assistant-1,assistant-2,assistant-3
        /// </param>
        /// <param name="squadId">
        /// This is the unique identifier for the squad that will be used for the chat.
        /// </param>
        /// <param name="sessionId">
        /// This is the unique identifier for the session that will be used for the chat.
        /// </param>
        /// <param name="previousChatId">
        /// This is the unique identifier for the previous chat to filter by.
        /// </param>
        /// <param name="page">
        /// This is the page number to return. Defaults to 1.
        /// </param>
        /// <param name="sortOrder">
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </param>
        /// <param name="limit">
        /// This is the maximum number of items to return. Defaults to 100.
        /// </param>
        /// <param name="createdAtGt">
        /// This will return items where the createdAt is greater than the specified value.
        /// </param>
        /// <param name="createdAtLt">
        /// This will return items where the createdAt is less than the specified value.
        /// </param>
        /// <param name="createdAtGe">
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </param>
        /// <param name="createdAtLe">
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </param>
        /// <param name="updatedAtGt">
        /// This will return items where the updatedAt is greater than the specified value.
        /// </param>
        /// <param name="updatedAtLt">
        /// This will return items where the updatedAt is less than the specified value.
        /// </param>
        /// <param name="updatedAtGe">
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </param>
        /// <param name="updatedAtLe">
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChatPaginatedDTO(
            string? id,
            string? assistantId,
            string? assistantIdAny,
            string? squadId,
            string? sessionId,
            string? previousChatId,
            double? page,
            global::G.GetChatPaginatedDTOSortOrder? sortOrder,
            double? limit,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLt,
            global::System.DateTime? createdAtGe,
            global::System.DateTime? createdAtLe,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLt,
            global::System.DateTime? updatedAtGe,
            global::System.DateTime? updatedAtLe)
        {
            this.Id = id;
            this.AssistantId = assistantId;
            this.AssistantIdAny = assistantIdAny;
            this.SquadId = squadId;
            this.SessionId = sessionId;
            this.PreviousChatId = previousChatId;
            this.Page = page;
            this.SortOrder = sortOrder;
            this.Limit = limit;
            this.CreatedAtGt = createdAtGt;
            this.CreatedAtLt = createdAtLt;
            this.CreatedAtGe = createdAtGe;
            this.CreatedAtLe = createdAtLe;
            this.UpdatedAtGt = updatedAtGt;
            this.UpdatedAtLt = updatedAtLt;
            this.UpdatedAtGe = updatedAtGe;
            this.UpdatedAtLe = updatedAtLe;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChatPaginatedDTO" /> class.
        /// </summary>
        public GetChatPaginatedDTO()
        {
        }
    }
}