//HintName: G.ICrossObjectClient.PostCrossObjectInsert.g.cs
#nullable enable

namespace G
{
    public partial interface ICrossObjectClient
    {
        /// <summary>
        /// Cross-object insert<br/>
        /// Insert events and feedback across object types
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CrossObjectInsertResponse> PostCrossObjectInsertAsync(

            global::G.CrossObjectInsertRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cross-object insert<br/>
        /// Insert events and feedback across object types
        /// </summary>
        /// <param name="experiment">
        /// A mapping from experiment id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="dataset">
        /// A mapping from dataset id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="projectLogs">
        /// A mapping from project id to a set of log events and feedback items to insert
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CrossObjectInsertResponse> PostCrossObjectInsertAsync(
            global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestExperiment2>? experiment = default,
            global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestDataset2>? dataset = default,
            global::System.Collections.Generic.Dictionary<string, global::G.CrossObjectInsertRequestProjectLogs2>? projectLogs = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}