//HintName: G.Models.ExportChatDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportChatDTO
    {
        /// <summary>
        /// This is the unique identifier for the chat to filter by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the assistant that will be used for the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Filter by multiple assistant IDs. Provide as comma-separated values.<br/>
        /// Example: assistant-1,assistant-2,assistant-3
        /// </summary>
        /// <example>assistant-1,assistant-2,assistant-3</example>
        [global::Newtonsoft.Json.JsonProperty("assistantIdAny")]
        public string? AssistantIdAny { get; set; }

        /// <summary>
        /// This is the unique identifier for the squad that will be used for the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the unique identifier for the session that will be used for the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// This is the unique identifier for the previous chat to filter by.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previousChatId")]
        public string? PreviousChatId { get; set; }

        /// <summary>
        /// Columns to include in the CSV export<br/>
        /// Default Value: [assistantId, cost, createdAt, id, messages, output, previousChatId, sessionId, squadId, updatedAt]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExportChatDTOColumnsJsonConverter))]
        public global::G.ExportChatDTOColumns? Columns { get; set; }

        /// <summary>
        /// This is the email address to send the export to.<br/>
        /// Required if userId is not available in the request context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// This is the format of the export.<br/>
        /// @default csv<br/>
        /// Default Value: csv
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExportChatDTOFormatJsonConverter))]
        public global::G.ExportChatDTOFormat? Format { get; set; }

        /// <summary>
        /// This is the page number to return. Defaults to 1.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public double? Page { get; set; }

        /// <summary>
        /// This is the sort order for pagination. Defaults to 'DESC'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sortOrder")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExportChatDTOSortOrderJsonConverter))]
        public global::G.ExportChatDTOSortOrder? SortOrder { get; set; }

        /// <summary>
        /// This is the maximum number of items to return. Defaults to 100.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGt")]
        public global::System.DateTime? CreatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLt")]
        public global::System.DateTime? CreatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the createdAt is greater than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtGe")]
        public global::System.DateTime? CreatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the createdAt is less than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAtLe")]
        public global::System.DateTime? CreatedAtLe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtGt")]
        public global::System.DateTime? UpdatedAtGt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtLt")]
        public global::System.DateTime? UpdatedAtLt { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is greater than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtGe")]
        public global::System.DateTime? UpdatedAtGe { get; set; }

        /// <summary>
        /// This will return items where the updatedAt is less than or equal to the specified value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAtLe")]
        public global::System.DateTime? UpdatedAtLe { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportChatDTO" /> class.
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
        /// <param name="columns">
        /// Columns to include in the CSV export<br/>
        /// Default Value: [assistantId, cost, createdAt, id, messages, output, previousChatId, sessionId, squadId, updatedAt]
        /// </param>
        /// <param name="email">
        /// This is the email address to send the export to.<br/>
        /// Required if userId is not available in the request context.
        /// </param>
        /// <param name="format">
        /// This is the format of the export.<br/>
        /// @default csv<br/>
        /// Default Value: csv
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
        public ExportChatDTO(
            string? id,
            string? assistantId,
            string? assistantIdAny,
            string? squadId,
            string? sessionId,
            string? previousChatId,
            global::G.ExportChatDTOColumns? columns,
            string? email,
            global::G.ExportChatDTOFormat? format,
            double? page,
            global::G.ExportChatDTOSortOrder? sortOrder,
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
            this.Columns = columns;
            this.Email = email;
            this.Format = format;
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
        /// Initializes a new instance of the <see cref="ExportChatDTO" /> class.
        /// </summary>
        public ExportChatDTO()
        {
        }
    }
}