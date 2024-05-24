//HintName: G.OrgsClient.OrgsListPendingInvitations.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// List pending organization invitations
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="role"></param>
        /// <param name="invitationSource"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task OrgsListPendingInvitationsAsync(
            string org,
            int perPage,
            int page,
            OrgsListPendingInvitationsRole role,
            OrgsListPendingInvitationsInvitationSource invitationSource,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var roleValue = role switch
            {
                OrgsListPendingInvitationsRole.All => "all",
                OrgsListPendingInvitationsRole.Admin => "admin",
                OrgsListPendingInvitationsRole.DirectMember => "direct_member",
                OrgsListPendingInvitationsRole.BillingManager => "billing_manager",
                OrgsListPendingInvitationsRole.HiringManager => "hiring_manager",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var invitationSourceValue = invitationSource switch
            {
                OrgsListPendingInvitationsInvitationSource.All => "all",
                OrgsListPendingInvitationsInvitationSource.Member => "member",
                OrgsListPendingInvitationsInvitationSource.Scim => "scim",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/invitations?per_page={perPage}&page={page}&role={roleValue}&invitation_source={invitationSourceValue}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}