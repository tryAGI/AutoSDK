//HintName: G.Models.ReturnChatPagedEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChatPagedEvents
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination_direction")]
        public global::G.ReturnChatPagedEventsPaginationDirection? PaginationDirection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events_page")]
        public global::System.Collections.Generic.IList<global::G.ReturnChatEvent>? EventsPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatPagedEvents" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="paginationDirection"></param>
        /// <param name="eventsPage"></param>
        /// <param name="metadata"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="totalPages"></param>
        public ReturnChatPagedEvents(
            string? id,
            string? status,
            global::G.ReturnChatPagedEventsPaginationDirection? paginationDirection,
            global::System.Collections.Generic.IList<global::G.ReturnChatEvent>? eventsPage,
            string? metadata,
            int? pageNumber,
            int? pageSize,
            int? totalPages)
        {
            this.Id = id;
            this.Status = status;
            this.PaginationDirection = paginationDirection;
            this.EventsPage = eventsPage;
            this.Metadata = metadata;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatPagedEvents" /> class.
        /// </summary>
        public ReturnChatPagedEvents()
        {
        }
    }
}