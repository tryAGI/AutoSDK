//HintName: G.Models.ReturnPagedChatGroups.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnPagedChatGroups
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnPagedChatGroupsPaginationDirectionJsonConverter))]
        public global::G.ReturnPagedChatGroupsPaginationDirection? PaginationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_groups_page")]
        public global::System.Collections.Generic.IList<global::G.ReturnChatGroup>? ChatGroupsPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPagedChatGroups" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
        /// <param name="paginationDirection"></param>
        /// <param name="chatGroupsPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnPagedChatGroups(
            int? pageNumber,
            int? pageSize,
            int? totalPages,
            global::G.ReturnPagedChatGroupsPaginationDirection? paginationDirection,
            global::System.Collections.Generic.IList<global::G.ReturnChatGroup>? chatGroupsPage)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.PaginationDirection = paginationDirection;
            this.ChatGroupsPage = chatGroupsPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPagedChatGroups" /> class.
        /// </summary>
        public ReturnPagedChatGroups()
        {
        }
    }
}