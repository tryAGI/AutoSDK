//HintName: G.IToolsClient.GetToolsByToolSlug.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get tool by slug<br/>
        /// Retrieve detailed information about a specific tool using its slug identifier. This endpoint returns full metadata about a tool including input/output parameters, versions, and toolkit information.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="version"></param>
        /// <param name="toolkitVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Tool> GetToolsByToolSlugAsync(
            string toolSlug,
            string? version = default,
            global::G.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}