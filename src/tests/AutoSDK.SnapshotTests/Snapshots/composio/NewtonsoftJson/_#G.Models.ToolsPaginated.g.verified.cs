//HintName: G.Models.ToolsPaginated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsPaginated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Tool> Items { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalPages { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_page", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentPage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_items", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalItems { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPaginated" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="totalPages"></param>
        /// <param name="currentPage"></param>
        /// <param name="totalItems"></param>
        /// <param name="nextCursor"></param>
        public ToolsPaginated(
            global::System.Collections.Generic.IList<global::G.Tool> items,
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
        /// Initializes a new instance of the <see cref="ToolsPaginated" /> class.
        /// </summary>
        public ToolsPaginated()
        {
        }
    }
}