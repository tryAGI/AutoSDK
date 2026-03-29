//HintName: G.IOrganizations2Client.ResetToken.g.cs
#nullable enable

namespace G
{
    public partial interface IOrganizations2Client
    {
        /// <summary>
        /// Reset organization token<br/>
        /// Reset the token used in the invitation link to invite someone to an organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OrganizationInvite> ResetTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}