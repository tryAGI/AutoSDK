//HintName: G.IAuthClient.GetTeams.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// List all teams
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Team>> GetTeamsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}