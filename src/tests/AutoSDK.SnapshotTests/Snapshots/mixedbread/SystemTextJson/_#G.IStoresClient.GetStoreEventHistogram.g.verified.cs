//HintName: G.IStoresClient.GetStoreEventHistogram.g.cs
#nullable enable

namespace G
{
    public partial interface IStoresClient
    {
        /// <summary>
        /// Get store event histogram<br/>
        /// Get histogram of store events over time.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     histogram_params: Parameters for histogram generation.<br/>
        /// Returns:<br/>
        ///     StoreEventHistogramResponse: The event histogram.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreEventHistogramResponse> GetStoreEventHistogramAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,

            global::G.StoreEventHistogramParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get store event histogram<br/>
        /// Get histogram of store events over time.<br/>
        /// Args:<br/>
        ///     store_identifier: The ID or name of the store.<br/>
        ///     histogram_params: Parameters for histogram generation.<br/>
        /// Returns:<br/>
        ///     StoreEventHistogramResponse: The event histogram.
        /// </summary>
        /// <param name="storeIdentifier">
        /// The ID or name of the store
        /// </param>
        /// <param name="startTime">
        /// Start time of the histogram
        /// </param>
        /// <param name="endTime">
        /// End time of the histogram
        /// </param>
        /// <param name="bucketSeconds">
        /// Number of seconds in each bucket<br/>
        /// Default Value: 7200
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.StoreEventHistogramResponse> GetStoreEventHistogramAsync(
            global::G.AnyOf<string, global::System.Guid?> storeIdentifier,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? bucketSeconds = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}