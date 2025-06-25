//HintName: G.Commands.ActivitySetRepoSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivitySetRepoSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            bool? subscribed,
            bool? ignored,
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

        private global::System.CommandLine.Option<bool?> Subscribed { get; } = new(
            name: "subscribed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Ignored { get; } = new(
            name: "ignored")
        {
            Description = "",
        };
        public ActivitySetRepoSubscriptionCommand(G.IApi client) : base(
            name: "activity",
            description: @"If you would like to watch a repository, set `subscribed` to `true`. If you would like to ignore notifications made within a repository, set `ignored` to `true`. If you would like to stop watching a repository, [delete the repository's subscription](https://docs.github.com/rest/activity/watching#delete-a-repository-subscription) completely.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Subscribed);
            Options.Add(Ignored);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var subscribed = parseResult.GetRequiredValue(Subscribed);
            var ignored = parseResult.GetRequiredValue(Ignored);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                subscribed: subscribed,
                ignored: ignored,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Activity.ActivitySetRepoSubscriptionAsync(
                owner: owner,
                repo: repo,
                subscribed: subscribed,
                ignored: ignored,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}