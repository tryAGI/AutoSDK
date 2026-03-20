//HintName: G.IAgentsPlatformClient.Get9.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Get Knowledge Base Summaries By Ids<br/>
        /// Gets multiple knowledge base document summaries by their IDs.
        /// </summary>
        /// <param name="documentIds">
        /// The ids of knowledge base documents.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> Get9Async(
            global::System.Collections.Generic.IList<string> documentIds,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}