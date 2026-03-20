//HintName: G.ICreditsClient.GetCredits.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// Get credits<br/>
        /// Get the credits information for the api user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Credits> GetCreditsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}