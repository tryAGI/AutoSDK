//HintName: G.OrgsClient.OrgsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::G.OrgsUpdateRequest request);
        partial void PrepareOrgsUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::G.OrgsUpdateRequest request);
        partial void ProcessOrgsUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an organization<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Parameter deprecation notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Parameter deprecation notice:** Code security product enablement for new repositories through the organization API is deprecated. Please use [code security configurations](https://docs.github.com/rest/code-security/configurations#set-a-code-security-configuration-as-a-default-for-an-organization) to set defaults instead. For more information on setting a default security configuration, see the [changelog](https://github.blog/changelog/2024-07-09-sunsetting-security-settings-defaults-parameters-in-the-organizations-rest-api/).<br/>
        /// Updates the organization's profile and member privileges.<br/>
        /// The authenticated user must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationFull> OrgsUpdateAsync(
            string org,
            global::G.OrgsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareOrgsUpdateArguments(
                httpClient: _httpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsUpdateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsUpdateResponseContent(
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
                global::G.OrganizationFull.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an organization<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Parameter deprecation notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Parameter deprecation notice:** Code security product enablement for new repositories through the organization API is deprecated. Please use [code security configurations](https://docs.github.com/rest/code-security/configurations#set-a-code-security-configuration-as-a-default-for-an-organization) to set defaults instead. For more information on setting a default security configuration, see the [changelog](https://github.blog/changelog/2024-07-09-sunsetting-security-settings-defaults-parameters-in-the-organizations-rest-api/).<br/>
        /// Updates the organization's profile and member privileges.<br/>
        /// The authenticated user must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="billingEmail">
        /// Billing email address. This address is not publicized.
        /// </param>
        /// <param name="company">
        /// The company name.
        /// </param>
        /// <param name="email">
        /// The publicly visible email address.
        /// </param>
        /// <param name="twitterUsername">
        /// The Twitter username of the company.
        /// </param>
        /// <param name="location">
        /// The location.
        /// </param>
        /// <param name="name">
        /// The shorthand name of the company.
        /// </param>
        /// <param name="description">
        /// The description of the company. The maximum size is 160 characters.
        /// </param>
        /// <param name="hasOrganizationProjects">
        /// Whether an organization can use organization projects.
        /// </param>
        /// <param name="hasRepositoryProjects">
        /// Whether repositories that belong to the organization can use repository projects.
        /// </param>
        /// <param name="defaultRepositoryPermission">
        /// Default permission level members have for organization repositories.<br/>
        /// Default Value: read
        /// </param>
        /// <param name="membersCanCreateRepositories">
        /// Whether of non-admin organization members can create repositories. **Note:** A parameter can override this parameter. See `members_allowed_repository_creation_type` in this table for details.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="membersCanCreateInternalRepositories">
        /// Whether organization members can create internal repositories, which are visible to all enterprise members. You can only allow members to create internal repositories if your organization is associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </param>
        /// <param name="membersCanCreatePrivateRepositories">
        /// Whether organization members can create private repositories, which are visible to organization members with permission. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </param>
        /// <param name="membersCanCreatePublicRepositories">
        /// Whether organization members can create public repositories, which are visible to anyone. For more information, see "[Restricting repository creation in your organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/restricting-repository-creation-in-your-organization)" in the GitHub Help documentation.
        /// </param>
        /// <param name="membersAllowedRepositoryCreationType">
        /// Specifies which types of repositories non-admin organization members can create. `private` is only available to repositories that are part of an organization on GitHub Enterprise Cloud. <br/>
        /// **Note:** This parameter is deprecated and will be removed in the future. Its return value ignores internal repositories. Using this parameter overrides values set in `members_can_create_repositories`. See the parameter deprecation notice in the operation description for details.
        /// </param>
        /// <param name="membersCanCreatePages">
        /// Whether organization members can create GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="membersCanCreatePublicPages">
        /// Whether organization members can create public GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="membersCanCreatePrivatePages">
        /// Whether organization members can create private GitHub Pages sites. Existing published sites will not be impacted.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="membersCanForkPrivateRepositories">
        /// Whether organization members can fork private organization repositories.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webCommitSignoffRequired">
        /// Whether contributors to organization repositories are required to sign off on commits they make through GitHub's web interface.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="blog">
        /// Example: "http://github.blog"
        /// </param>
        /// <param name="secretScanningPushProtectionCustomLinkEnabled">
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.
        /// </param>
        /// <param name="secretScanningPushProtectionCustomLink">
        /// If `secret_scanning_push_protection_custom_link_enabled` is true, the URL that will be displayed to contributors who are blocked from pushing a secret.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationFull> OrgsUpdateAsync(
            string org,
            string? billingEmail = default,
            string? company = default,
            string? email = default,
            string? twitterUsername = default,
            string? location = default,
            string? name = default,
            string? description = default,
            bool? hasOrganizationProjects = default,
            bool? hasRepositoryProjects = default,
            global::G.OrgsUpdateRequestDefaultRepositoryPermission? defaultRepositoryPermission = global::G.OrgsUpdateRequestDefaultRepositoryPermission.Read,
            bool? membersCanCreateRepositories = true,
            bool? membersCanCreateInternalRepositories = default,
            bool? membersCanCreatePrivateRepositories = default,
            bool? membersCanCreatePublicRepositories = default,
            global::G.OrgsUpdateRequestMembersAllowedRepositoryCreationType? membersAllowedRepositoryCreationType = default,
            bool? membersCanCreatePages = true,
            bool? membersCanCreatePublicPages = true,
            bool? membersCanCreatePrivatePages = true,
            bool? membersCanForkPrivateRepositories = false,
            bool? webCommitSignoffRequired = false,
            string? blog = default,
            bool? secretScanningPushProtectionCustomLinkEnabled = default,
            string? secretScanningPushProtectionCustomLink = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.OrgsUpdateRequest
            {
                BillingEmail = billingEmail,
                Company = company,
                Email = email,
                TwitterUsername = twitterUsername,
                Location = location,
                Name = name,
                Description = description,
                HasOrganizationProjects = hasOrganizationProjects,
                HasRepositoryProjects = hasRepositoryProjects,
                DefaultRepositoryPermission = defaultRepositoryPermission,
                MembersCanCreateRepositories = membersCanCreateRepositories,
                MembersCanCreateInternalRepositories = membersCanCreateInternalRepositories,
                MembersCanCreatePrivateRepositories = membersCanCreatePrivateRepositories,
                MembersCanCreatePublicRepositories = membersCanCreatePublicRepositories,
                MembersAllowedRepositoryCreationType = membersAllowedRepositoryCreationType,
                MembersCanCreatePages = membersCanCreatePages,
                MembersCanCreatePublicPages = membersCanCreatePublicPages,
                MembersCanCreatePrivatePages = membersCanCreatePrivatePages,
                MembersCanForkPrivateRepositories = membersCanForkPrivateRepositories,
                WebCommitSignoffRequired = webCommitSignoffRequired,
                Blog = blog,
                SecretScanningPushProtectionCustomLinkEnabled = secretScanningPushProtectionCustomLinkEnabled,
                SecretScanningPushProtectionCustomLink = secretScanningPushProtectionCustomLink,
            };

            return await OrgsUpdateAsync(
                org: org,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}