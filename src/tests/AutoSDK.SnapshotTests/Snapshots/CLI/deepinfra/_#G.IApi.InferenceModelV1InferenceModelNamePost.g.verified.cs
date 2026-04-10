//HintName: G.IApi.InferenceModelV1InferenceModelNamePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Inference Model
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="version">
        /// model version to run inference against
        /// </param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InferenceModelV1InferenceModelNamePostAsync(
            string modelName,
            string? version = default,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}