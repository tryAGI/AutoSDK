//HintName: G.Models.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse
    {
        /// <summary>
        /// List of files in the mount
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem> Items { get; set; }

        /// <summary>
        /// Cursor for the next page of results. If absent, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// List of files in the mount
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results. If absent, there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse(
            global::System.Collections.Generic.IList<global::G.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponseItem> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse()
        {
        }
    }
}