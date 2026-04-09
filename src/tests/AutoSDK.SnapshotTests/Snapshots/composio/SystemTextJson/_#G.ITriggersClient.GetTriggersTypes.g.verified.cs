//HintName: G.ITriggersClient.GetTriggersTypes.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// List trigger types<br/>
        /// Retrieve a list of available trigger types with optional filtering by toolkit. Results are paginated and can be filtered by toolkit.
        /// </summary>
        /// <param name="toolkitSlugs">
        /// Array of toolkit slugs to filter triggers by<br/>
        /// Example: [slack, github]
        /// </param>
        /// <param name="toolkitVersions"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTriggersTypesResponse> GetTriggersTypesAsync(
            global::System.Collections.Generic.IList<string>? toolkitSlugs = default,
            global::G.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            double? limit = default,
            string? cursor = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}