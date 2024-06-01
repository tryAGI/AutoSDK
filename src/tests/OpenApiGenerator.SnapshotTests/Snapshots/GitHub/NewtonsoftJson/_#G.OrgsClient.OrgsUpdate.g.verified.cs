//HintName: G.OrgsClient.OrgsUpdate.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Update an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrganizationFull> OrgsUpdateAsync(
            string org,
            OrgsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<OrganizationFull?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="billingEmail"></param>
        /// <param name="company"></param>
        /// <param name="email"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="location"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="hasOrganizationProjects"></param>
        /// <param name="hasRepositoryProjects"></param>
        /// <param name="defaultRepositoryPermission"></param>
        /// <param name="membersCanCreateRepositories"></param>
        /// <param name="membersCanCreateInternalRepositories"></param>
        /// <param name="membersCanCreatePrivateRepositories"></param>
        /// <param name="membersCanCreatePublicRepositories"></param>
        /// <param name="membersAllowedRepositoryCreationType"></param>
        /// <param name="membersCanCreatePages"></param>
        /// <param name="membersCanCreatePublicPages"></param>
        /// <param name="membersCanCreatePrivatePages"></param>
        /// <param name="membersCanForkPrivateRepositories"></param>
        /// <param name="webCommitSignoffRequired"></param>
        /// <param name="blog"></param>
        /// <param name="advancedSecurityEnabledForNewRepositories"></param>
        /// <param name="dependabotAlertsEnabledForNewRepositories"></param>
        /// <param name="dependabotSecurityUpdatesEnabledForNewRepositories"></param>
        /// <param name="dependencyGraphEnabledForNewRepositories"></param>
        /// <param name="secretScanningEnabledForNewRepositories"></param>
        /// <param name="secretScanningPushProtectionEnabledForNewRepositories"></param>
        /// <param name="secretScanningPushProtectionCustomLinkEnabled"></param>
        /// <param name="secretScanningPushProtectionCustomLink"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrganizationFull> OrgsUpdateAsync(
            string org,
            string? billingEmail = default,
            string? company = default,
            string? email = default,
            string? twitterUsername = default,
            string? location = default,
            string? name = default,
            string? description = default,
            bool hasOrganizationProjects = default,
            bool hasRepositoryProjects = default,
            OrgsUpdateRequestDefaultRepositoryPermission? defaultRepositoryPermission = OrgsUpdateRequestDefaultRepositoryPermission.Read,
            bool membersCanCreateRepositories = true,
            bool membersCanCreateInternalRepositories = default,
            bool membersCanCreatePrivateRepositories = default,
            bool membersCanCreatePublicRepositories = default,
            OrgsUpdateRequestMembersAllowedRepositoryCreationType? membersAllowedRepositoryCreationType = default,
            bool membersCanCreatePages = true,
            bool membersCanCreatePublicPages = true,
            bool membersCanCreatePrivatePages = true,
            bool membersCanForkPrivateRepositories = false,
            bool webCommitSignoffRequired = false,
            string? blog = default,
            bool advancedSecurityEnabledForNewRepositories = default,
            bool dependabotAlertsEnabledForNewRepositories = default,
            bool dependabotSecurityUpdatesEnabledForNewRepositories = default,
            bool dependencyGraphEnabledForNewRepositories = default,
            bool secretScanningEnabledForNewRepositories = default,
            bool secretScanningPushProtectionEnabledForNewRepositories = default,
            bool secretScanningPushProtectionCustomLinkEnabled = default,
            string? secretScanningPushProtectionCustomLink = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsUpdateRequest
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
                AdvancedSecurityEnabledForNewRepositories = advancedSecurityEnabledForNewRepositories,
                DependabotAlertsEnabledForNewRepositories = dependabotAlertsEnabledForNewRepositories,
                DependabotSecurityUpdatesEnabledForNewRepositories = dependabotSecurityUpdatesEnabledForNewRepositories,
                DependencyGraphEnabledForNewRepositories = dependencyGraphEnabledForNewRepositories,
                SecretScanningEnabledForNewRepositories = secretScanningEnabledForNewRepositories,
                SecretScanningPushProtectionEnabledForNewRepositories = secretScanningPushProtectionEnabledForNewRepositories,
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