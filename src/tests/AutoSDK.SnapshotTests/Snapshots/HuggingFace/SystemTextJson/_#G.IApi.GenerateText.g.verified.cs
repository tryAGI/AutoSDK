//HintName: G.IApi.GenerateText.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            global::G.GenerateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="inputs">
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            string? inputs,
            global::G.GenerateTextRequestParameters? parameters = default,
            global::G.GenerateTextRequestOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}