//HintName: G.IFunctionClient.AttachFunction.g.cs
#nullable enable

namespace G
{
    public partial interface IFunctionClient
    {
        /// <summary>
        /// Attach function<br/>
        /// Attaches a function to a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AttachFunctionResponse> AttachFunctionAsync(
            string tenant,
            string database,
            string collectionId,

            global::G.AttachFunctionRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach function<br/>
        /// Attaches a function to a collection.
        /// </summary>
        /// <param name="tenant"></param>
        /// <param name="database"></param>
        /// <param name="collectionId"></param>
        /// <param name="functionId"></param>
        /// <param name="name"></param>
        /// <param name="outputCollection"></param>
        /// <param name="params"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AttachFunctionResponse> AttachFunctionAsync(
            string tenant,
            string database,
            string collectionId,
            string functionId,
            string name,
            string outputCollection,
            object? @params = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}