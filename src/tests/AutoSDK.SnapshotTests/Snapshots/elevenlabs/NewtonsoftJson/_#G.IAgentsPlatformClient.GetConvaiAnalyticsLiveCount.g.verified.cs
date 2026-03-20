//HintName: G.IAgentsPlatformClient.GetConvaiAnalyticsLiveCount.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {

        /// <summary>
        /// Get Live Count<br/>
        /// Get the live count of the ongoing conversations.
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent to restrict the analytics to.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetLiveCountResponse> GetConvaiAnalyticsLiveCountAsync(
            string? agentId = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}