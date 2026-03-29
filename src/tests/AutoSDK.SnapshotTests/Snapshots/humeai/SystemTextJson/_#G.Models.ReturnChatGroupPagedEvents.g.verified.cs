//HintName: G.Models.ReturnChatGroupPagedEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChatGroupPagedEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination_direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReturnChatGroupPagedEventsPaginationDirectionJsonConverter))]
        public global::G.ReturnChatGroupPagedEventsPaginationDirection? PaginationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_page")]
        public global::System.Collections.Generic.IList<global::G.ReturnChatEvent>? EventsPage { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatGroupPagedEvents" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="paginationDirection"></param>
        /// <param name="eventsPage"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnChatGroupPagedEvents(
            string? id,
            global::G.ReturnChatGroupPagedEventsPaginationDirection? paginationDirection,
            global::System.Collections.Generic.IList<global::G.ReturnChatEvent>? eventsPage,
            int? pageNumber,
            int? pageSize,
            int? totalPages)
        {
            this.Id = id;
            this.PaginationDirection = paginationDirection;
            this.EventsPage = eventsPage;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatGroupPagedEvents" /> class.
        /// </summary>
        public ReturnChatGroupPagedEvents()
        {
        }
    }
}