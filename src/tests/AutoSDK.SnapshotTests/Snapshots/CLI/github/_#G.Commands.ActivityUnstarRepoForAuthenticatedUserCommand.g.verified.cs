//HintName: G.Commands.ActivityUnstarRepoForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityUnstarRepoForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
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

        public ActivityUnstarRepoForAuthenticatedUserCommand(G.IApi client) : base(
            name: "activity",
            description: @"Unstar a repository that the authenticated user has previously starred.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Activity.ActivityUnstarRepoForAuthenticatedUserAsync(
                owner: owner,
                repo: repo,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}