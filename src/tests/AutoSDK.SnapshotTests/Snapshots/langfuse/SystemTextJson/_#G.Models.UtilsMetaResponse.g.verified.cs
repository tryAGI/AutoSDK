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
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Page { get; set; }

        /// <summary>
        /// number of items per page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// number of total items given the current filters/selection (if any)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalItems")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalItems { get; set; }

        /// <summary>
        /// number of total pages given the current limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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