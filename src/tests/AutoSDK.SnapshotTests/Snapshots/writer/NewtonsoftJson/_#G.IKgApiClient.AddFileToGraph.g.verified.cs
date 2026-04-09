//HintName: G.IKgApiClient.AddFileToGraph.g.cs
#nullable enable

namespace G
{
    public partial interface IKgApiClient
    {
        /// <summary>
        /// Add file to graph<br/>
        /// Add a file to a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/graphs/{graph_id}/file \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"file_id":"string"}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.FileResponse> AddFileToGraphAsync(
            global::System.Guid graphId,

            global::G.GraphFileRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add file to graph<br/>
        /// Add a file to a Knowledge Graph.
        /// </summary>
        /// <param name="graphId"></param>
        /// <param name="fileId">
        /// The unique identifier of the file.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileResponse> AddFileToGraphAsync(
            global::System.Guid graphId,
            string fileId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}