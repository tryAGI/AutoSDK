//HintName: G.IDatasetsClient.PostDatasetIdInsert.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Insert dataset events<br/>
        /// Insert a set of events into the dataset
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsertEventsResponse> PostDatasetIdInsertAsync(
            global::System.Guid datasetId,

            global::G.InsertDatasetEventRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Insert dataset events<br/>
        /// Insert a set of events into the dataset
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="events">
        /// A list of dataset events to insert
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InsertEventsResponse> PostDatasetIdInsertAsync(
            global::System.Guid datasetId,
            global::System.Collections.Generic.IList<global::G.InsertDatasetEvent> events,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}