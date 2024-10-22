//HintName: G.OrgsClient.OrgsSetMembershipForUser.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsSetMembershipForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string username,
            global::G.OrgsSetMembershipForUserRequest request);
        partial void PrepareOrgsSetMembershipForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string username,
            global::G.OrgsSetMembershipForUserRequest request);
        partial void ProcessOrgsSetMembershipForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsSetMembershipForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Set organization membership for a user<br/>
        /// Only authenticated organization owners can add a member to the organization or update the member's role.<br/>
        /// *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user's [membership status](https://docs.github.com/rest/orgs/members#get-organization-membership-for-a-user) will be `pending` until they accept the invitation.<br/>
        ///     <br/>
        /// *   Authenticated users can _update_ a user's membership by passing the `role` parameter. If the authenticated user changes a member's role to `admin`, the affected user will receive an email notifying them that they've been made an organization owner. If the authenticated user changes an owner's role to `member`, no email will be sent.<br/>
        /// **Rate limits**<br/>
        /// To prevent abuse, organization owners are limited to creating 50 organization invitations for an organization within a 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrgMembership> OrgsSetMembershipForUserAsync(
            string org,
            string username,
            global::G.OrgsSetMembershipForUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsSetMembershipForUserArguments(
                httpClient: HttpClient,
                org: ref org,
                username: ref username,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/memberships/{username}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsSetMembershipForUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                username: username,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsSetMembershipForUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsSetMembershipForUserResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.OrgMembership.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set organization membership for a user<br/>
        /// Only authenticated organization owners can add a member to the organization or update the member's role.<br/>
        /// *   If the authenticated user is _adding_ a member to the organization, the invited user will receive an email inviting them to the organization. The user's [membership status](https://docs.github.com/rest/orgs/members#get-organization-membership-for-a-user) will be `pending` until they accept the invitation.<br/>
        ///     <br/>
        /// *   Authenticated users can _update_ a user's membership by passing the `role` parameter. If the authenticated user changes a member's role to `admin`, the affected user will receive an email notifying them that they've been made an organization owner. If the authenticated user changes an owner's role to `member`, no email will be sent.<br/>
        /// **Rate limits**<br/>
        /// To prevent abuse, organization owners are limited to creating 50 organization invitations for an organization within a 24 hour period. If the organization is more than one month old or on a paid plan, the limit is 500 invitations per 24 hour period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="role">
        /// The role to give the user in the organization. Can be one of:  <br/>
        ///  * `admin` - The user will become an owner of the organization.  <br/>
        ///  * `member` - The user will become a non-owner member of the organization.<br/>
        /// Default Value: member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrgMembership> OrgsSetMembershipForUserAsync(
            string org,
            string username,
            global::G.OrgsSetMembershipForUserRequestRole? role = global::G.OrgsSetMembershipForUserRequestRole.Member,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OrgsSetMembershipForUserRequest
            {
                Role = role,
            };

            return await OrgsSetMembershipForUserAsync(
                org: org,
                username: username,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}