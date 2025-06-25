//HintName: G.Commands.ActionsSetAllowedActionsOrganizationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetAllowedActionsOrganizationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            bool? githubOwnedAllowed,
            bool? verifiedAllowed,
            global::System.Collections.Generic.IList<string>? patternsAllowed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> GithubOwnedAllowed { get; } = new(
            name: "githubOwnedAllowed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> VerifiedAllowed { get; } = new(
            name: "verifiedAllowed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> PatternsAllowed { get; } = new(
            name: "patternsAllowed")
        {
            Description = "",
        };
        public ActionsSetAllowedActionsOrganizationCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the actions and reusable workflows that are allowed in an organization. To use this endpoint, the organization permission policy for `allowed_actions` must be configured to `selected`. For more information, see ""[Set GitHub Actions permissions for an organization](#set-github-actions-permissions-for-an-organization).""

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(GithubOwnedAllowed);
            Options.Add(VerifiedAllowed);
            Options.Add(PatternsAllowed);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var githubOwnedAllowed = parseResult.GetRequiredValue(GithubOwnedAllowed);
            var verifiedAllowed = parseResult.GetRequiredValue(VerifiedAllowed);
            var patternsAllowed = parseResult.GetRequiredValue(PatternsAllowed);

            Validate(
                parseResult: parseResult,
                org: org,
                githubOwnedAllowed: githubOwnedAllowed,
                verifiedAllowed: verifiedAllowed,
                patternsAllowed: patternsAllowed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetAllowedActionsOrganizationAsync(
                org: org,
                githubOwnedAllowed: githubOwnedAllowed,
                verifiedAllowed: verifiedAllowed,
                patternsAllowed: patternsAllowed,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}