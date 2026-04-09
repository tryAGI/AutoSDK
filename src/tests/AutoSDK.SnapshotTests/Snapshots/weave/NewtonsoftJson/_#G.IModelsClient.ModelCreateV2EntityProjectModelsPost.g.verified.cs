//HintName: G.IModelsClient.ModelCreateV2EntityProjectModelsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Model Create<br/>
        /// Create a model object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelCreateRes> ModelCreateV2EntityProjectModelsPostAsync(
            string entity,
            string project,

            global::G.ModelCreateBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Create<br/>
        /// Create a model object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="name">
        /// The name of this model. Models with the same name will be versioned together.
        /// </param>
        /// <param name="description">
        /// A description of this model
        /// </param>
        /// <param name="sourceCode">
        /// Complete source code for the Model class including imports
        /// </param>
        /// <param name="attributes">
        /// Additional attributes to be stored with the model
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelCreateRes> ModelCreateV2EntityProjectModelsPostAsync(
            string entity,
            string project,
            string name,
            string sourceCode,
            string? description = default,
            object? attributes = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}