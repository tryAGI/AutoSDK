//HintName: G.Commands.ActivityGetRepoSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityGetRepoSubscriptionCommand : global::System.CommandLine.Command
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
            global::G.RepositorySubscription response,
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

        public ActivityGetRepoSubscriptionCommand(G.IApi client) : base(
            name: "activity",
            description: @"Gets information about whether the authenticated user is subscribed to the repository.")
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
            var response = await _client.Activity.ActivityGetRepoSubscriptionAsync(
                owner: owner,
                repo: repo,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}