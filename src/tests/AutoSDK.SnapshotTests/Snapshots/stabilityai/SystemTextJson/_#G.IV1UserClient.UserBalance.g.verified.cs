//HintName: G.IV1UserClient.UserBalance.g.cs
#nullable enable

namespace G
{
    public partial interface IV1UserClient
    {
        /// <summary>
        /// balance<br/>
        /// Get the credit balance of the account/organization associated with the API key
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// if [ -z "$STABILITY_API_KEY" ]; then<br/>
        ///     echo "STABILITY_API_KEY environment variable is not set"<br/>
        ///     exit 1<br/>
        /// fi<br/>
        /// # Determine the URL to use for the request<br/>
        /// BASE_URL=${API_HOST:-https://api.stability.ai}<br/>
        /// URL="$BASE_URL/v1/user/balance"<br/>
        /// curl -f -sS "$URL" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -H "Authorization: Bearer $STABILITY_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.BalanceResponseBody> UserBalanceAsync(
            string? organization = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}