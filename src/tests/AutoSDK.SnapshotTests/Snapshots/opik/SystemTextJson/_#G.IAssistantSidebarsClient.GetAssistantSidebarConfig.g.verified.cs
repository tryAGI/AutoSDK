//HintName: G.IAssistantSidebarsClient.GetAssistantSidebarConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IAssistantSidebarsClient
    {
        /// <summary>
        /// Get Assistant Sidebar configuration<br/>
        /// Get CDN configuration for loading the assistant sidebar at runtime
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AssistantSidebarConfigResponse> GetAssistantSidebarConfigAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}