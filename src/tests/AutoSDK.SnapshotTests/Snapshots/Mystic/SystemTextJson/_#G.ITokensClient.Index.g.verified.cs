//HintName: G.ITokensClient.Index.g.cs
#nullable enable

namespace G
{
    public partial interface ITokensClient
    {
        /// <summary>
        /// Index<br/>
        /// Retrieve a Catalyst API Bearer token for an authenticated user.
        /// </summary>
        /// <param name="allTeam">
        /// Default Value: false
        /// </param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedTokenGet> IndexAsync(
            bool? allTeam = default,
            int? skip = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}