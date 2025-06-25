//HintName: G.Commands.OrgsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string? billingEmail,
            string? company,
            string? email,
            string? twitterUsername,
            string? location,
            string? name,
            string? description,
            bool? hasOrganizationProjects,
            bool? hasRepositoryProjects,
            global::G.OrgsUpdateRequestDefaultRepositoryPermission? defaultRepositoryPermission,
            bool? membersCanCreateRepositories,
            bool? membersCanCreateInternalRepositories,
            bool? membersCanCreatePrivateRepositories,
            bool? membersCanCreatePublicRepositories,
            global::G.OrgsUpdateRequestMembersAllowedRepositoryCreationType? membersAllowedRepositoryCreationType,
            bool? membersCanCreatePages,
            bool? membersCanCreatePublicPages,
            bool? membersCanCreatePrivatePages,
            bool? membersCanForkPrivateRepositories,
            bool? webCommitSignoffRequired,
            string? blog,
            bool? advancedSecurityEnabledForNewRepositories,
            bool? dependabotAlertsEnabledForNewRepositories,
            bool? dependabotSecurityUpdatesEnabledForNewRepositories,
            bool? dependencyGraphEnabledForNewRepositories,
            bool? secretScanningEnabledForNewRepositories,
            bool? secretScanningPushProtectionEnabledForNewRepositories,
            bool? secretScanningPushProtectionCustomLinkEnabled,
            string? secretScanningPushProtectionCustomLink,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OrganizationFull response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> BillingEmail { get; } = new(
            name: "billingEmail")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Company { get; } = new(
            name: "company")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TwitterUsername { get; } = new(
            name: "twitterUsername")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Location { get; } = new(
            name: "location")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasOrganizationProjects { get; } = new(
            name: "hasOrganizationProjects")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasRepositoryProjects { get; } = new(
            name: "hasRepositoryProjects")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsUpdateRequestDefaultRepositoryPermission?> DefaultRepositoryPermission { get; } = new(
            name: "defaultRepositoryPermission")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreateRepositories { get; } = new(
            name: "membersCanCreateRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreateInternalRepositories { get; } = new(
            name: "membersCanCreateInternalRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreatePrivateRepositories { get; } = new(
            name: "membersCanCreatePrivateRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreatePublicRepositories { get; } = new(
            name: "membersCanCreatePublicRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsUpdateRequestMembersAllowedRepositoryCreationType?> MembersAllowedRepositoryCreationType { get; } = new(
            name: "membersAllowedRepositoryCreationType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreatePages { get; } = new(
            name: "membersCanCreatePages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreatePublicPages { get; } = new(
            name: "membersCanCreatePublicPages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanCreatePrivatePages { get; } = new(
            name: "membersCanCreatePrivatePages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MembersCanForkPrivateRepositories { get; } = new(
            name: "membersCanForkPrivateRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> WebCommitSignoffRequired { get; } = new(
            name: "webCommitSignoffRequired")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Blog { get; } = new(
            name: "blog")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AdvancedSecurityEnabledForNewRepositories { get; } = new(
            name: "advancedSecurityEnabledForNewRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DependabotAlertsEnabledForNewRepositories { get; } = new(
            name: "dependabotAlertsEnabledForNewRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DependabotSecurityUpdatesEnabledForNewRepositories { get; } = new(
            name: "dependabotSecurityUpdatesEnabledForNewRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DependencyGraphEnabledForNewRepositories { get; } = new(
            name: "dependencyGraphEnabledForNewRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> SecretScanningEnabledForNewRepositories { get; } = new(
            name: "secretScanningEnabledForNewRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> SecretScanningPushProtectionEnabledForNewRepositories { get; } = new(
            name: "secretScanningPushProtectionEnabledForNewRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> SecretScanningPushProtectionCustomLinkEnabled { get; } = new(
            name: "secretScanningPushProtectionCustomLinkEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> SecretScanningPushProtectionCustomLink { get; } = new(
            name: "secretScanningPushProtectionCustomLink")
        {
            Description = "",
        };
        public OrgsUpdateCommand(G.IApi client) : base(
            name: "orgs",
            description: @"> [!WARNING]
> **Parameter deprecation notice:** GitHub will replace and discontinue `members_allowed_repository_creation_type` in favor of more granular permissions. The new input parameters are `members_can_create_public_repositories`, `members_can_create_private_repositories` for all organizations and `members_can_create_internal_repositories` for organizations associated with an enterprise account using GitHub Enterprise Cloud or GitHub Enterprise Server 2.20+. For more information, see the [blog post](https://developer.github.com/changes/2019-12-03-internal-visibility-changes).

> [!WARNING]
> **Parameter deprecation notice:** Code security product enablement for new repositories through the organization API is deprecated. Please use [code security configurations](https://docs.github.com/rest/code-security/configurations#set-a-code-security-configuration-as-a-default-for-an-organization) to set defaults instead. For more information on setting a default security configuration, see the [changelog](https://github.blog/changelog/2024-07-09-sunsetting-security-settings-defaults-parameters-in-the-organizations-rest-api/).

Updates the organization's profile and member privileges.

The authenticated user must be an organization owner to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `admin:org` or `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(BillingEmail);
            Options.Add(Company);
            Options.Add(Email);
            Options.Add(TwitterUsername);
            Options.Add(Location);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(HasOrganizationProjects);
            Options.Add(HasRepositoryProjects);
            Options.Add(DefaultRepositoryPermission);
            Options.Add(MembersCanCreateRepositories);
            Options.Add(MembersCanCreateInternalRepositories);
            Options.Add(MembersCanCreatePrivateRepositories);
            Options.Add(MembersCanCreatePublicRepositories);
            Options.Add(MembersAllowedRepositoryCreationType);
            Options.Add(MembersCanCreatePages);
            Options.Add(MembersCanCreatePublicPages);
            Options.Add(MembersCanCreatePrivatePages);
            Options.Add(MembersCanForkPrivateRepositories);
            Options.Add(WebCommitSignoffRequired);
            Options.Add(Blog);
            Options.Add(AdvancedSecurityEnabledForNewRepositories);
            Options.Add(DependabotAlertsEnabledForNewRepositories);
            Options.Add(DependabotSecurityUpdatesEnabledForNewRepositories);
            Options.Add(DependencyGraphEnabledForNewRepositories);
            Options.Add(SecretScanningEnabledForNewRepositories);
            Options.Add(SecretScanningPushProtectionEnabledForNewRepositories);
            Options.Add(SecretScanningPushProtectionCustomLinkEnabled);
            Options.Add(SecretScanningPushProtectionCustomLink);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var billingEmail = parseResult.GetRequiredValue(BillingEmail);
            var company = parseResult.GetRequiredValue(Company);
            var email = parseResult.GetRequiredValue(Email);
            var twitterUsername = parseResult.GetRequiredValue(TwitterUsername);
            var location = parseResult.GetRequiredValue(Location);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var hasOrganizationProjects = parseResult.GetRequiredValue(HasOrganizationProjects);
            var hasRepositoryProjects = parseResult.GetRequiredValue(HasRepositoryProjects);
            var defaultRepositoryPermission = parseResult.GetRequiredValue(DefaultRepositoryPermission);
            var membersCanCreateRepositories = parseResult.GetRequiredValue(MembersCanCreateRepositories);
            var membersCanCreateInternalRepositories = parseResult.GetRequiredValue(MembersCanCreateInternalRepositories);
            var membersCanCreatePrivateRepositories = parseResult.GetRequiredValue(MembersCanCreatePrivateRepositories);
            var membersCanCreatePublicRepositories = parseResult.GetRequiredValue(MembersCanCreatePublicRepositories);
            var membersAllowedRepositoryCreationType = parseResult.GetRequiredValue(MembersAllowedRepositoryCreationType);
            var membersCanCreatePages = parseResult.GetRequiredValue(MembersCanCreatePages);
            var membersCanCreatePublicPages = parseResult.GetRequiredValue(MembersCanCreatePublicPages);
            var membersCanCreatePrivatePages = parseResult.GetRequiredValue(MembersCanCreatePrivatePages);
            var membersCanForkPrivateRepositories = parseResult.GetRequiredValue(MembersCanForkPrivateRepositories);
            var webCommitSignoffRequired = parseResult.GetRequiredValue(WebCommitSignoffRequired);
            var blog = parseResult.GetRequiredValue(Blog);
            var advancedSecurityEnabledForNewRepositories = parseResult.GetRequiredValue(AdvancedSecurityEnabledForNewRepositories);
            var dependabotAlertsEnabledForNewRepositories = parseResult.GetRequiredValue(DependabotAlertsEnabledForNewRepositories);
            var dependabotSecurityUpdatesEnabledForNewRepositories = parseResult.GetRequiredValue(DependabotSecurityUpdatesEnabledForNewRepositories);
            var dependencyGraphEnabledForNewRepositories = parseResult.GetRequiredValue(DependencyGraphEnabledForNewRepositories);
            var secretScanningEnabledForNewRepositories = parseResult.GetRequiredValue(SecretScanningEnabledForNewRepositories);
            var secretScanningPushProtectionEnabledForNewRepositories = parseResult.GetRequiredValue(SecretScanningPushProtectionEnabledForNewRepositories);
            var secretScanningPushProtectionCustomLinkEnabled = parseResult.GetRequiredValue(SecretScanningPushProtectionCustomLinkEnabled);
            var secretScanningPushProtectionCustomLink = parseResult.GetRequiredValue(SecretScanningPushProtectionCustomLink);

            Validate(
                parseResult: parseResult,
                org: org,
                billingEmail: billingEmail,
                company: company,
                email: email,
                twitterUsername: twitterUsername,
                location: location,
                name: name,
                description: description,
                hasOrganizationProjects: hasOrganizationProjects,
                hasRepositoryProjects: hasRepositoryProjects,
                defaultRepositoryPermission: defaultRepositoryPermission,
                membersCanCreateRepositories: membersCanCreateRepositories,
                membersCanCreateInternalRepositories: membersCanCreateInternalRepositories,
                membersCanCreatePrivateRepositories: membersCanCreatePrivateRepositories,
                membersCanCreatePublicRepositories: membersCanCreatePublicRepositories,
                membersAllowedRepositoryCreationType: membersAllowedRepositoryCreationType,
                membersCanCreatePages: membersCanCreatePages,
                membersCanCreatePublicPages: membersCanCreatePublicPages,
                membersCanCreatePrivatePages: membersCanCreatePrivatePages,
                membersCanForkPrivateRepositories: membersCanForkPrivateRepositories,
                webCommitSignoffRequired: webCommitSignoffRequired,
                blog: blog,
                advancedSecurityEnabledForNewRepositories: advancedSecurityEnabledForNewRepositories,
                dependabotAlertsEnabledForNewRepositories: dependabotAlertsEnabledForNewRepositories,
                dependabotSecurityUpdatesEnabledForNewRepositories: dependabotSecurityUpdatesEnabledForNewRepositories,
                dependencyGraphEnabledForNewRepositories: dependencyGraphEnabledForNewRepositories,
                secretScanningEnabledForNewRepositories: secretScanningEnabledForNewRepositories,
                secretScanningPushProtectionEnabledForNewRepositories: secretScanningPushProtectionEnabledForNewRepositories,
                secretScanningPushProtectionCustomLinkEnabled: secretScanningPushProtectionCustomLinkEnabled,
                secretScanningPushProtectionCustomLink: secretScanningPushProtectionCustomLink,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsUpdateAsync(
                org: org,
                billingEmail: billingEmail,
                company: company,
                email: email,
                twitterUsername: twitterUsername,
                location: location,
                name: name,
                description: description,
                hasOrganizationProjects: hasOrganizationProjects,
                hasRepositoryProjects: hasRepositoryProjects,
                defaultRepositoryPermission: defaultRepositoryPermission,
                membersCanCreateRepositories: membersCanCreateRepositories,
                membersCanCreateInternalRepositories: membersCanCreateInternalRepositories,
                membersCanCreatePrivateRepositories: membersCanCreatePrivateRepositories,
                membersCanCreatePublicRepositories: membersCanCreatePublicRepositories,
                membersAllowedRepositoryCreationType: membersAllowedRepositoryCreationType,
                membersCanCreatePages: membersCanCreatePages,
                membersCanCreatePublicPages: membersCanCreatePublicPages,
                membersCanCreatePrivatePages: membersCanCreatePrivatePages,
                membersCanForkPrivateRepositories: membersCanForkPrivateRepositories,
                webCommitSignoffRequired: webCommitSignoffRequired,
                blog: blog,
                advancedSecurityEnabledForNewRepositories: advancedSecurityEnabledForNewRepositories,
                dependabotAlertsEnabledForNewRepositories: dependabotAlertsEnabledForNewRepositories,
                dependabotSecurityUpdatesEnabledForNewRepositories: dependabotSecurityUpdatesEnabledForNewRepositories,
                dependencyGraphEnabledForNewRepositories: dependencyGraphEnabledForNewRepositories,
                secretScanningEnabledForNewRepositories: secretScanningEnabledForNewRepositories,
                secretScanningPushProtectionEnabledForNewRepositories: secretScanningPushProtectionEnabledForNewRepositories,
                secretScanningPushProtectionCustomLinkEnabled: secretScanningPushProtectionCustomLinkEnabled,
                secretScanningPushProtectionCustomLink: secretScanningPushProtectionCustomLink,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}