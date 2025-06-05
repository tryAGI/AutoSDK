//HintName: G.IApi.TeamSetDisplayNameV1MeTeamDisplayNamePost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Team Set Display Name
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TeamSetDisplayNameV1MeTeamDisplayNamePostAsync(
            global::G.DisplayNameIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Team Set Display Name
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="displayName">
        /// String with length between 1 and 39 characters. Only alphanumeric characters and dashes allowed. Must contain no leading, trailing or consecutive dashes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TeamSetDisplayNameV1MeTeamDisplayNamePostAsync(
            string displayName,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}