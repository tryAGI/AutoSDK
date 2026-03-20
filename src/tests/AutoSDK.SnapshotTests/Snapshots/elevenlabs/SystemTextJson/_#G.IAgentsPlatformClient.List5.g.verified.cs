//HintName: G.IAgentsPlatformClient.List5.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Available Llms<br/>
        /// Returns a list of available LLM models that can be used with agents, including their capabilities and any deprecation status. The response is filtered based on the data residency of the deployment and any compliance requirements (e.g. HIPAA) of the workspace subscription.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LLMListResponseModelInput> List5Async(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}