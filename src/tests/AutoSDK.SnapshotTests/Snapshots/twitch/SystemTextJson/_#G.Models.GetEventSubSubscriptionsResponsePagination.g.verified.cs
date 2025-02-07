//HintName: G.Models.GetEventSubSubscriptionsResponsePagination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that contains the cursor used to get the next page of subscriptions. The object is empty if there are no more pages to get. The number of subscriptions returned per page is undertermined.
    /// </summary>
    public sealed partial class GetEventSubSubscriptionsResponsePagination
    {
        /// <summary>
        /// The cursor value that you set the _after_ query parameter to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventSubSubscriptionsResponsePagination" /> class.
        /// </summary>
        /// <param name="cursor">
        /// The cursor value that you set the _after_ query parameter to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEventSubSubscriptionsResponsePagination(
            string? cursor)
        {
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventSubSubscriptionsResponsePagination" /> class.
        /// </summary>
        public GetEventSubSubscriptionsResponsePagination()
        {
        }
    }
}