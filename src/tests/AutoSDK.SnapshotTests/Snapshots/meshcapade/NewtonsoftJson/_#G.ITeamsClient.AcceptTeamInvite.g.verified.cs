//HintName: G.ITeamsClient.AcceptTeamInvite.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Accept team invitation
        /// </summary>
        /// <param name="teamID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AcceptTeamInviteAsync(
            string teamID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}