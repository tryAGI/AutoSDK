//HintName: G.ISubpackageModelsClient.ListModelsUser.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageModelsClient
    {
        /// <summary>
        /// List models filtered by user provider preferences, privacy settings, and guardrails<br/>
        /// List models filtered by user provider preferences, [privacy settings](https://openrouter.ai/docs/guides/privacy/logging), and [guardrails](https://openrouter.ai/docs/guides/features/guardrails). If requesting through `eu.openrouter.ai/api/v1/...` the results will be filtered to models that satisfy [EU in-region routing](https://openrouter.ai/docs/guides/privacy/logging#enterprise-eu-in-region-routing).
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelsListResponse> ListModelsUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}