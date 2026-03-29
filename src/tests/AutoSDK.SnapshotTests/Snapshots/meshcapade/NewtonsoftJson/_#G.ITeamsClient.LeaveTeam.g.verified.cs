//HintName: G.ITeamsClient.LeaveTeam.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Leave team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task LeaveTeamAsync(
            string teamID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}