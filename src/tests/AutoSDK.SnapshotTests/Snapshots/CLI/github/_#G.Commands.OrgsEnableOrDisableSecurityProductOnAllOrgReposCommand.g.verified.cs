//HintName: G.Commands.OrgsEnableOrDisableSecurityProductOnAllOrgReposCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsEnableOrDisableSecurityProductOnAllOrgReposCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct securityProduct,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement enablement,
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? querySuite,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposSecurityProduct> SecurityProduct { get; } = new(
            name: "securityProduct")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposEnablement> Enablement { get; } = new(
            name: "enablement")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite?> QuerySuite { get; } = new(
            name: "querySuite")
        {
            Description = "",
        };
        public OrgsEnableOrDisableSecurityProductOnAllOrgReposCommand(G.IApi client) : base(
            name: "orgs",
            description: @"> [!WARNING]
> **Deprecation notice:** The ability to enable or disable a security feature for all eligible repositories in an organization is deprecated. Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead. For more information, see the [changelog](https://github.blog/changelog/2024-07-22-deprecation-of-api-endpoint-to-enable-or-disable-a-security-feature-for-an-organization/).

Enables or disables the specified security feature for all eligible repositories in an organization. For more information, see ""[Managing security managers in your organization](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).""

The authenticated user must be an organization owner or be member of a team with the security manager role to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `admin:org`, `write:org`, or `repo` scopes to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(SecurityProduct);
            Arguments.Add(Enablement);
            Options.Add(QuerySuite);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var securityProduct = parseResult.GetRequiredValue(SecurityProduct);
            var enablement = parseResult.GetRequiredValue(Enablement);
            var querySuite = parseResult.GetRequiredValue(QuerySuite);

            Validate(
                parseResult: parseResult,
                org: org,
                securityProduct: securityProduct,
                enablement: enablement,
                querySuite: querySuite,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Orgs.OrgsEnableOrDisableSecurityProductOnAllOrgReposAsync(
                org: org,
                securityProduct: securityProduct,
                enablement: enablement,
                querySuite: querySuite,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}