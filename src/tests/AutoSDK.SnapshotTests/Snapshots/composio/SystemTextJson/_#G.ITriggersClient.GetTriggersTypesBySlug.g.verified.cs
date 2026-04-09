//HintName: G.ITriggersClient.GetTriggersTypesBySlug.g.cs
#nullable enable

namespace G
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Get trigger type by slug<br/>
        /// Retrieve detailed information about a specific trigger type using its slug identifier
        /// </summary>
        /// <param name="slug">
        /// The unique slug identifier for the trigger type. Case-insensitive (internally normalized to uppercase).<br/>
        /// Example: SLACK_NEW_MESSAGE
        /// </param>
        /// <param name="toolkitVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTriggersTypesBySlugResponse> GetTriggersTypesBySlugAsync(
            string slug,
            global::G.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}