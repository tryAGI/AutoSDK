//HintName: G.IDatasetsClient.DatasetCreateV2EntityProjectDatasetsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Dataset Create<br/>
        /// Create a dataset object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetCreateRes> DatasetCreateV2EntityProjectDatasetsPostAsync(
            string entity,
            string project,

            global::G.DatasetCreateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Dataset Create<br/>
        /// Create a dataset object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="name">
        /// The name of this dataset.  Datasets with the same name will be versioned together.
        /// </param>
        /// <param name="description">
        /// A description of this dataset
        /// </param>
        /// <param name="rows">
        /// Dataset rows
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetCreateRes> DatasetCreateV2EntityProjectDatasetsPostAsync(
            string entity,
            string project,
            global::System.Collections.Generic.IList<object> rows,
            string? name = default,
            string? description = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}