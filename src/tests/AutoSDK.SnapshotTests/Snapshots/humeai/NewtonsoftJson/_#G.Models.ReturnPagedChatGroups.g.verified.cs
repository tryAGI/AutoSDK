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
        [global::Newtonsoft.Json.JsonProperty("page_number")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination_direction")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ReturnPagedChatGroupsPaginationDirectionJsonConverter))]
        public global::G.ReturnPagedChatGroupsPaginationDirection? PaginationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chat_groups_page")]
        public global::System.Collections.Generic.IList<global::G.ReturnChatGroup>? ChatGroupsPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnPagedChatGroups" /> class.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
        /// <param name="paginationDirection"></param>
        /// <param name="chatGroupsPage"></param>
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