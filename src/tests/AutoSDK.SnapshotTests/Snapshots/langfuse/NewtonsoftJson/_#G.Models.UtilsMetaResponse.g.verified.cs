//HintName: G.Models.UtilsMetaResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UtilsMetaResponse
    {
        /// <summary>
        /// current page number
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page", Required = global::Newtonsoft.Json.Required.Always)]
        public int Page { get; set; } = default!;

        /// <summary>
        /// number of items per page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// number of total items given the current filters/selection (if any)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalItems", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalItems { get; set; } = default!;

        /// <summary>
        /// number of total pages given the current limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalPages", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalPages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsMetaResponse" /> class.
        /// </summary>
        /// <param name="page">
        /// current page number
        /// </param>
        /// <param name="limit">
        /// number of items per page
        /// </param>
        /// <param name="totalItems">
        /// number of total items given the current filters/selection (if any)
        /// </param>
        /// <param name="totalPages">
        /// number of total pages given the current limit
        /// </param>
        public UtilsMetaResponse(
            int page,
            int limit,
            int totalItems,
            int totalPages)
        {
            this.Page = page;
            this.Limit = limit;
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UtilsMetaResponse" /> class.
        /// </summary>
        public UtilsMetaResponse()
        {
        }
    }
}