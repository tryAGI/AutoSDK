//HintName: G.Commands.ActionsSetAllowedActionsRepositoryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetAllowedActionsRepositoryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            bool? githubOwnedAllowed,
            bool? verifiedAllowed,
            global::System.Collections.Generic.IList<string>? patternsAllowed,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
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
        public ActionsSetAllowedActionsRepositoryCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the actions and reusable workflows that are allowed in a repository. To use this endpoint, the repository permission policy for `allowed_actions` must be configured to `selected`. For more information, see ""[Set GitHub Actions permissions for a repository](#set-github-actions-permissions-for-a-repository).""

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
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
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var githubOwnedAllowed = parseResult.GetRequiredValue(GithubOwnedAllowed);
            var verifiedAllowed = parseResult.GetRequiredValue(VerifiedAllowed);
            var patternsAllowed = parseResult.GetRequiredValue(PatternsAllowed);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                githubOwnedAllowed: githubOwnedAllowed,
                verifiedAllowed: verifiedAllowed,
                patternsAllowed: patternsAllowed,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsSetAllowedActionsRepositoryAsync(
                owner: owner,
                repo: repo,
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