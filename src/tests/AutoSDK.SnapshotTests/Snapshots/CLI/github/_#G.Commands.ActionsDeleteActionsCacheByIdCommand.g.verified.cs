//HintName: G.Commands.ActionsDeleteActionsCacheByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsDeleteActionsCacheByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int cacheId,
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

        private global::System.CommandLine.Argument<int> CacheId { get; } = new(
            name: "cacheId")
        {
            Description = "",
        };

        public ActionsDeleteActionsCacheByIdCommand(G.IApi client) : base(
            name: "actions",
            description: @"Deletes a GitHub Actions cache for a repository, using a cache ID.

OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CacheId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var cacheId = parseResult.GetRequiredValue(CacheId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                cacheId: cacheId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Actions.ActionsDeleteActionsCacheByIdAsync(
                owner: owner,
                repo: repo,
                cacheId: cacheId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}