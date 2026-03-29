//HintName: G.IAuthConfigsClient.PostAuthConfigs.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Create new authentication configuration<br/>
        /// Creates a new auth config for a toolkit, allowing you to use your own OAuth credentials or API keys instead of Composio-managed authentication. This is required when you want to use custom OAuth apps (bring your own client ID/secret) or configure specific authentication parameters for a toolkit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostAuthConfigsResponse> PostAuthConfigsAsync(

            global::G.PostAuthConfigsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new authentication configuration<br/>
        /// Creates a new auth config for a toolkit, allowing you to use your own OAuth credentials or API keys instead of Composio-managed authentication. This is required when you want to use custom OAuth apps (bring your own client ID/secret) or configure specific authentication parameters for a toolkit.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig">
        /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostAuthConfigsResponse> PostAuthConfigsAsync(
            global::G.PostAuthConfigsRequestToolkit toolkit,
            global::G.OneOf<global::G.PostAuthConfigsRequestAuthConfigVariant1, global::G.PostAuthConfigsRequestAuthConfigVariant2>? authConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}