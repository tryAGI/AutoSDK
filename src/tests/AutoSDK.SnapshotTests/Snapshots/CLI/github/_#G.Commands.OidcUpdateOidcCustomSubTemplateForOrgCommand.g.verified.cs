//HintName: G.Commands.OidcUpdateOidcCustomSubTemplateForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OidcUpdateOidcCustomSubTemplateForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<string> includeClaimKeys,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> IncludeClaimKeys { get; } = new(
            name: "includeClaimKeys")
        {
            Description = "",
        };

        public OidcUpdateOidcCustomSubTemplateForOrgCommand(G.IApi client) : base(
            name: "oidc",
            description: @"Creates or updates the customization template for an OpenID Connect (OIDC) subject claim.

OAuth app tokens and personal access tokens (classic) need the `write:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(IncludeClaimKeys);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var includeClaimKeys = parseResult.GetRequiredValue(IncludeClaimKeys);

            Validate(
                parseResult: parseResult,
                org: org,
                includeClaimKeys: includeClaimKeys,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Oidc.OidcUpdateOidcCustomSubTemplateForOrgAsync(
                org: org,
                includeClaimKeys: includeClaimKeys,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}