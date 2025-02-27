//HintName: G.IApi.ModelsList.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List Models<br/>
        /// List available models.<br/>
        /// The Models API response can be used to determine which models are available for use in the API. More recently released models are listed first.
        /// </summary>
        /// <param name="beforeId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately before this object.
        /// </param>
        /// <param name="afterId">
        /// ID of the object to use as a cursor for pagination. When provided, returns the page of results immediately after this object.
        /// </param>
        /// <param name="limit">
        /// Number of items to return per page.<br/>
        /// Defaults to `20`. Ranges from `1` to `1000`.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="anthropicVersion">
        /// The version of the Anthropic API you want to use.<br/>
        /// Read more about versioning and our version history [here](https://docs.anthropic.com/en/api/versioning).
        /// </param>
        /// <param name="xApiKey">
        /// Your unique API key for authentication.<br/>
        /// This key is required in the header of all API requests, to authenticate your account and access Anthropic's services. Get your API key through the [Console](https://console.anthropic.com/settings/keys). Each key is scoped to a Workspace.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListResponseModelInfo> ModelsListAsync(
            string? beforeId = default,
            string? afterId = default,
            int? limit = default,
            string? anthropicVersion = default,
            string? xApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}