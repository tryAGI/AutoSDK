//HintName: G.Models.GetBillingEventsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing billing event data with pagination support
    /// </summary>
    public sealed partial class GetBillingEventsResponse
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
        /// List of billing event records
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_events", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetBillingEventsResponseBillingEvent> BillingEvents { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponse" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Boolean indicating if more results are available (convenience field derived from next_cursor)
        /// </param>
        /// <param name="billingEvents">
        /// List of billing event records
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results, null if no more pages
        /// </param>
        public GetBillingEventsResponse(
            bool hasMore,
            global::System.Collections.Generic.IList<global::G.GetBillingEventsResponseBillingEvent> billingEvents,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
            this.BillingEvents = billingEvents ?? throw new global::System.ArgumentNullException(nameof(billingEvents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBillingEventsResponse" /> class.
        /// </summary>
        public GetBillingEventsResponse()
        {
        }
    }
}