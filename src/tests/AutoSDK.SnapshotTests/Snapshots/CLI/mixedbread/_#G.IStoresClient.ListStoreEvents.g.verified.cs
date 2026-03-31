//HintName: G.IStoresClient.ListStoreEvents.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// List events for a store<br/>
        /// List events for a store.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     options: The pagination options.<br/>
        /// Returns:<br/>
        ///     StoreEventListResponse: The list of events for the store.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return per page (1-100)<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="after">
        /// Cursor for forward pagination - get items after this position. Use last_cursor from previous response.
        /// </param>
        /// <param name="before">
        /// Cursor for backward pagination - get items before this position. Use first_cursor from previous response.
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include total count in response (expensive operation)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="filterBefore">
        /// Time to filter events before
        /// </param>
        /// <param name="filterAfter">
        /// Time to filter events after
        /// </param>
        /// <param name="eventType">
        /// The type of event to list
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreEventListResponse> ListStoreEventsAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::G.ListStoreEventsEventType eventType,
            int? limit = default,
            string? after = default,
            string? before = default,
            bool? includeTotal = default,
            global::System.DateTime? filterBefore = default,
            global::System.DateTime? filterAfter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}