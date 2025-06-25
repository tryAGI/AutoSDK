//HintName: G.Commands.ActivityMarkRepoNotificationsAsReadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityMarkRepoNotificationsAsReadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::System.DateTime? lastReadAt,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActivityMarkRepoNotificationsAsReadResponse response,
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

        private global::System.CommandLine.Option<global::System.DateTime?> LastReadAt { get; } = new(
            name: "lastReadAt")
        {
            Description = "",
        };
        public ActivityMarkRepoNotificationsAsReadCommand(G.IApi client) : base(
            name: "activity",
            description: @"Marks all notifications in a repository as ""read"" for the current user. If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as ""read."" To check whether any ""unread"" notifications remain, you can use the [List repository notifications for the authenticated user](https://docs.github.com/rest/activity/notifications#list-repository-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(LastReadAt);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var lastReadAt = parseResult.GetRequiredValue(LastReadAt);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                lastReadAt: lastReadAt,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Activity.ActivityMarkRepoNotificationsAsReadAsync(
                owner: owner,
                repo: repo,
                lastReadAt: lastReadAt,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}