//HintName: G.Models.GetPricingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing pricing information for requested endpoints
    /// </summary>
    public sealed partial class GetPricingResponse
    {
        /// <summary>
        /// Cursor for the next page of results, null if no more pages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Pricing information for requested endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetPricingResponsePrice> Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="prices">
        /// Pricing information for requested endpoints
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPricingResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.GetPricingResponsePrice> prices,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.Prices = prices ?? throw new global::System.ArgumentNullException(nameof(prices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingResponse" /> class.
        /// </summary>
        public GetPricingResponse()
        {
        }
    }
}