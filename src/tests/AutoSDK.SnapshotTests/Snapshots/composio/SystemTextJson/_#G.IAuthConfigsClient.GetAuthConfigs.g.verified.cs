//HintName: G.IAuthConfigsClient.GetAuthConfigs.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// List authentication configurations with optional filters<br/>
        /// Retrieves all auth configs for your project. Auth configs define how users authenticate with external services (OAuth, API keys, etc.). Use filters to find configs for specific toolkits or to distinguish between Composio-managed and custom configurations.
        /// </summary>
        /// <param name="isComposioManaged">
        /// Whether to filter by composio managed auth configs
        /// </param>
        /// <param name="toolkitSlug"></param>
        /// <param name="deprecatedAppId">
        /// DEPRECATED: This parameter will be removed in a future version. Please use toolkit_slug instead.
        /// </param>
        /// <param name="deprecatedStatus">
        /// DEPRECATED: This parameter will be removed in a future version.
        /// </param>
        /// <param name="showDisabled">
        /// Show disabled auth configs<br/>
        /// Default Value: false
        /// </param>
        /// <param name="search">
        /// Search auth configs by name or id
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAuthConfigsResponse> GetAuthConfigsAsync(
            global::G.AnyOf<string, bool?>? isComposioManaged = default,
            string? toolkitSlug = default,
            string? deprecatedAppId = default,
            string? deprecatedStatus = default,
            bool? showDisabled = default,
            string? search = default,
            double? limit = default,
            string? cursor = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}