//HintName: G.Commands.ActionsSetCustomOidcSubClaimForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsSetCustomOidcSubClaimForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            bool useDefault,
            global::System.Collections.Generic.IList<string>? includeClaimKeys,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EmptyObject response,
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

        private global::System.CommandLine.Argument<bool> UseDefault { get; } = new(
            name: "useDefault")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> IncludeClaimKeys { get; } = new(
            name: "includeClaimKeys")
        {
            Description = "",
        };
        public ActionsSetCustomOidcSubClaimForRepoCommand(G.IApi client) : base(
            name: "actions",
            description: @"Sets the customization template and `opt-in` or `opt-out` flag for an OpenID Connect (OIDC) subject claim for a repository.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(UseDefault);
            Options.Add(IncludeClaimKeys);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var useDefault = parseResult.GetRequiredValue(UseDefault);
            var includeClaimKeys = parseResult.GetRequiredValue(IncludeClaimKeys);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                useDefault: useDefault,
                includeClaimKeys: includeClaimKeys,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsSetCustomOidcSubClaimForRepoAsync(
                owner: owner,
                repo: repo,
                useDefault: useDefault,
                includeClaimKeys: includeClaimKeys,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}