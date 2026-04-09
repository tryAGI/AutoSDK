//HintName: G.IDatasetsClient.PostDataset.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Create dataset<br/>
        /// Create a new dataset. If there is an existing dataset in the project with the same name as the one specified in the request, will return the existing dataset unmodified
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> PostDatasetAsync(

            global::G.CreateDataset request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create dataset<br/>
        /// Create a new dataset. If there is an existing dataset in the project with the same name as the one specified in the request, will return the existing dataset unmodified
        /// </summary>
        /// <param name="projectId">
        /// Unique identifier for the project that the dataset belongs under
        /// </param>
        /// <param name="name">
        /// Name of the dataset. Within a project, dataset names are unique
        /// </param>
        /// <param name="description">
        /// Textual description of the dataset
        /// </param>
        /// <param name="metadata">
        /// User-controlled metadata about the dataset
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Dataset> PostDatasetAsync(
            global::System.Guid projectId,
            string name,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, object?>? metadata = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}