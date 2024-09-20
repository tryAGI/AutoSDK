//HintName: G.MembershipClient.UpdateUserMembership.g.cs

#nullable enable

namespace G
{
    public partial class MembershipClient
    {
        partial void PrepareUpdateUserMembershipArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string userId,
            ref string organizationId,
            ref string updateMask,
            global::G.UserMembership request);
        partial void PrepareUpdateUserMembershipRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string userId,
            string organizationId,
            string updateMask,
            global::G.UserMembership request);
        partial void ProcessUpdateUserMembershipResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateUserMembershipResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a user membership<br/>
        /// Accesses and updates a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateUserMembershipResponse> UpdateUserMembershipAsync(
            string userId,
            string organizationId,
            string updateMask,
            global::G.UserMembership request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateUserMembershipArguments(
                httpClient: _httpClient,
                userId: ref userId,
                organizationId: ref organizationId,
                updateMask: ref updateMask,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1beta/users/{userId}/memberships/{organizationId}",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("updateMask", updateMask) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateUserMembershipRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                userId: userId,
                organizationId: organizationId,
                updateMask: updateMask,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateUserMembershipResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateUserMembershipResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.UpdateUserMembershipResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a user membership<br/>
        /// Accesses and updates a user membership by parent and membership IDs.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="organizationId"></param>
        /// <param name="updateMask"></param>
        /// <param name="name">
        /// The resource name of the membership, which allows its access by user and<br/>
        /// organization ID.<br/>
        /// - Format: `users/{user.id}/memberships/{organization.id}`.
        /// </param>
        /// <param name="role">
        /// Role of the user in the organization.
        /// </param>
        /// <param name="organization">
        /// Organizations group several users. As entities, they can own resources such<br/>
        /// as pipelines or releases.
        /// </param>
        /// <param name="user">
        /// User describes an individual that interacts with Instill AI. It doesn't<br/>
        /// contain any private information about the user.
        /// </param>
        /// <param name="state">
        /// MembershipState describes the state of a user membership to an organization.<br/>
        ///  - MEMBERSHIP_STATE_ACTIVE: Active.<br/>
        ///  - MEMBERSHIP_STATE_PENDING: Pending, i.e., a request has been sent to the user to join an<br/>
        /// organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateUserMembershipResponse> UpdateUserMembershipAsync(
            string userId,
            string organizationId,
            string updateMask,
            global::G.MembershipState state,
            string? name = default,
            string? role = default,
            global::G.Organization? organization = default,
            global::G.User? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.UserMembership
            {
                Name = name,
                Role = role,
                Organization = organization,
                User = user,
                State = state,
            };

            return await UpdateUserMembershipAsync(
                userId: userId,
                organizationId: organizationId,
                updateMask: updateMask,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}