//HintName: G.ILargeLanguageModelsClient.ListLLMs.g.cs
#nullable enable

namespace G
{
    public partial interface ILargeLanguageModelsClient
    {
        /// <summary>
        /// List LLMs<br/>
        /// List LLMs that can be used with query and chat endpoints. The LLM is not directly specified in a query,<br/>
        /// but instead a `generation_preset_name` is used. The `generation_preset_name` property in generation parameters<br/>
        /// can be found as the `name` property on the Generations Presets retrieved from `/v2/generation_presets`.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="filter"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="pageKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListLLMsResponse> ListLLMsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? filter = default,
            int? limit = default,
            string? pageKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}