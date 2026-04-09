//HintName: G.IToolkitsClient.GetToolkitsBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Get toolkit by slug<br/>
        /// Retrieves comprehensive information about a specific toolkit using its unique slug identifier. This endpoint provides detailed metadata, authentication configuration options, and feature counts for the requested toolkit.
        /// </summary>
        /// <param name="slug">
        /// The unique slug identifier of the toolkit to retrieve<br/>
        /// Example: github
        /// </param>
        /// <param name="version">
        /// Version of the toolkit<br/>
        /// Default Value: latest<br/>
        /// Example: 20250905_00
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetToolkitsBySlugResponse> GetToolkitsBySlugAsync(
            string slug,
            string? version = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}