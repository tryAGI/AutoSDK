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
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Pricing information for requested endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetPricingResponsePrice> Prices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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