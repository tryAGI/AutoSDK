//HintName: G.Commands.ActivityDeleteThreadSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityDeleteThreadSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int threadId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        public ActivityDeleteThreadSubscriptionCommand(G.IApi client) : base(
            name: "activity",
            description: @"Mutes all future notifications for a conversation until you comment on the thread or get an **@mention**. If you are watching the repository of the thread, you will still receive notifications. To ignore future notifications for a repository you are watching, use the [Set a thread subscription](https://docs.github.com/rest/activity/notifications#set-a-thread-subscription) endpoint and set `ignore` to `true`.")
        {
            _client = client;

            Arguments.Add(ThreadId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Activity.ActivityDeleteThreadSubscriptionAsync(
                threadId: threadId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}