//HintName: G.OrganizationClient.UpdateOrganization.g.cs

#nullable enable

namespace G
{
    public partial class OrganizationClient
    {
        partial void PrepareUpdateOrganizationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId,
            global::G.Organization7 request);
        partial void PrepareUpdateOrganizationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId,
            global::G.Organization7 request);
        partial void ProcessUpdateOrganizationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateOrganizationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an organization<br/>
        /// Accesses and updates an organization by ID.<br/>
        /// In REST requests, only the supplied organization fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateOrganizationResponse> UpdateOrganizationAsync(
            string organizationId,
            global::G.Organization7 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateOrganizationArguments(
                httpClient: _httpClient,
                organizationId: ref organizationId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/organizations/{organizationId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateOrganizationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                organizationId: organizationId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateOrganizationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateOrganizationResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UpdateOrganizationResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an organization<br/>
        /// Accesses and updates an organization by ID.<br/>
        /// In REST requests, only the supplied organization fields will be taken into<br/>
        /// account when updating the resource.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="name">
        /// The name of the organization, defined by its ID.<br/>
        /// - Format: `organization/{organization.id}`.
        /// </param>
        /// <param name="uid">
        /// Organization UUID.
        /// </param>
        /// <param name="id">
        /// Resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.<br/>
        /// Note that the ID can be updated.
        /// </param>
        /// <param name="createTime">
        /// Creation time.
        /// </param>
        /// <param name="updateTime">
        /// Update time.
        /// </param>
        /// <param name="owner">
        /// The user that owns the organization.
        /// </param>
        /// <param name="profile">
        /// Profile.
        /// </param>
        /// <param name="permission"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UpdateOrganizationResponse> UpdateOrganizationAsync(
            string organizationId,
            global::G.AllOf<global::G.OrganizationProfile> profile,
            string? name = default,
            string? uid = default,
            string? id = default,
            global::System.DateTime createTime = default,
            global::System.DateTime updateTime = default,
            global::G.AllOf<global::G.User9>? owner = default,
            global::G.AllOf<global::G.Permission2>? permission = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Organization7
            {
                Name = name,
                Uid = uid,
                Id = id,
                CreateTime = createTime,
                UpdateTime = updateTime,
                Owner = owner,
                Profile = profile,
                Permission = permission,
            };

            return await UpdateOrganizationAsync(
                organizationId: organizationId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}