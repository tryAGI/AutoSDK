//HintName: G.Commands.ActivityMarkNotificationsAsReadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityMarkNotificationsAsReadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.DateTime? lastReadAt,
            bool? read,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActivityMarkNotificationsAsReadResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::System.DateTime?> LastReadAt { get; } = new(
            name: "lastReadAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Read { get; } = new(
            name: "read")
        {
            Description = "",
        };
        public ActivityMarkNotificationsAsReadCommand(G.IApi client) : base(
            name: "activity",
            description: @"Marks all notifications as ""read"" for the current user. If the number of notifications is too large to complete in one request, you will receive a `202 Accepted` status and GitHub will run an asynchronous process to mark notifications as ""read."" To check whether any ""unread"" notifications remain, you can use the [List notifications for the authenticated user](https://docs.github.com/rest/activity/notifications#list-notifications-for-the-authenticated-user) endpoint and pass the query parameter `all=false`.")
        {
            _client = client;

            Options.Add(LastReadAt);
            Options.Add(Read);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var lastReadAt = parseResult.GetRequiredValue(LastReadAt);
            var read = parseResult.GetRequiredValue(Read);

            Validate(
                parseResult: parseResult,
                lastReadAt: lastReadAt,
                read: read,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Activity.ActivityMarkNotificationsAsReadAsync(
                lastReadAt: lastReadAt,
                read: read,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}