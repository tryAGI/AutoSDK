//HintName: G.Commands.ActivitySetThreadSubscriptionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivitySetThreadSubscriptionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int threadId,
            bool? ignored,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ThreadSubscription response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Ignored { get; } = new(
            name: "ignored")
        {
            Description = "",
        };
        public ActivitySetThreadSubscriptionCommand(G.IApi client) : base(
            name: "activity",
            description: @"If you are watching a repository, you receive notifications for all threads by default. Use this endpoint to ignore future notifications for threads until you comment on the thread or get an **@mention**.

You can also use this endpoint to subscribe to threads that you are currently not receiving notifications for or to subscribed to threads that you have previously ignored.

Unsubscribing from a conversation in a repository that you are not watching is functionally equivalent to the [Delete a thread subscription](https://docs.github.com/rest/activity/notifications#delete-a-thread-subscription) endpoint.")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Options.Add(Ignored);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var ignored = parseResult.GetRequiredValue(Ignored);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                ignored: ignored,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Activity.ActivitySetThreadSubscriptionAsync(
                threadId: threadId,
                ignored: ignored,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}