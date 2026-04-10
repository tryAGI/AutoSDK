//HintName: G.IInferenceClient.InferenceRouterOpenrouterModelsInferenceRouterOpenrouterModelsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Inference Router Openrouter Models<br/>
        /// Returns a list of models that are available to be used with OpenRouter.<br/>
        /// This API is available without authentication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RouterOpenRouterModelsRes> InferenceRouterOpenrouterModelsInferenceRouterOpenrouterModelsGetAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}