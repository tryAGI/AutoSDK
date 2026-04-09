//HintName: G.IApi.ModelAddModelAddPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Load a model<br/>
        /// Load the model with the given model ID
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsDescriptions> ModelAddModelAddPostAsync(

            global::G.AddModelRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Load a model<br/>
        /// Load the model with the given model ID
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="modelId">
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </param>
        /// <param name="modelType">
        /// The type of the model, usually referring to what task the model performs
        /// </param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsDescriptions> ModelAddModelAddPostAsync(
            string modelId,
            bool? countinference = default,
            string? serviceSecret = default,
            string? modelType = default,
            string? apiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}