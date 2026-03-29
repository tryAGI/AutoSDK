//HintName: G.ITeamsClient.KickTeamMember.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Kick member from team
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task KickTeamMemberAsync(
            string teamID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}