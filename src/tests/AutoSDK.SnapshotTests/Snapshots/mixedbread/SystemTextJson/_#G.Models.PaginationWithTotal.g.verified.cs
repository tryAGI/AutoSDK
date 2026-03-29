//HintName: G.Models.PaginationWithTotal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pagination model that includes total count of items.
    /// </summary>
    public sealed partial class PaginationWithTotal
    {
        /// <summary>
        /// Maximum number of items to return per page<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Offset of the first item to return<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Total number of items available<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationWithTotal" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return per page<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Offset of the first item to return<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="total">
        /// Total number of items available<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationWithTotal(
            int? limit,
            int? offset,
            int? total)
        {
            this.Limit = limit;
            this.Offset = offset;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationWithTotal" /> class.
        /// </summary>
        public PaginationWithTotal()
        {
        }
    }
}