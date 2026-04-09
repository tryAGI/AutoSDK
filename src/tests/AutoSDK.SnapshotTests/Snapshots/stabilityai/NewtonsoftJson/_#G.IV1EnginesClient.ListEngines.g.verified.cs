//HintName: G.IV1EnginesClient.ListEngines.g.cs
#nullable enable

namespace G
{
    public partial interface IV1EnginesClient
    {
        /// <summary>
        /// list<br/>
        /// List all engines available to your organization/user
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/engines/list"<br/>
        /// curl -f -sS "$URL" \<br/>
        ///   -H 'Accept: application/json' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Engine>> ListEnginesAsync(
            string? organization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}