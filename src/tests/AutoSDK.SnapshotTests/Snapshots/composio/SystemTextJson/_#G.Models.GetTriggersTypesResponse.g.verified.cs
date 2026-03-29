//HintName: G.Models.GetTriggersTypesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTriggersTypesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetTriggersTypesResponseItem> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CurrentPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="totalPages"></param>
        /// <param name="currentPage"></param>
        /// <param name="totalItems"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTriggersTypesResponse(
            global::System.Collections.Generic.IList<global::G.GetTriggersTypesResponseItem> items,
            double totalPages,
            double currentPage,
            double totalItems,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
            this.TotalItems = totalItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTriggersTypesResponse" /> class.
        /// </summary>
        public GetTriggersTypesResponse()
        {
        }
    }
}