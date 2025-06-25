//HintName: G.Commands.ActivityMarkThreadAsDoneCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityMarkThreadAsDoneCommand : global::System.CommandLine.Command
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

        public ActivityMarkThreadAsDoneCommand(G.IApi client) : base(
            name: "activity",
            description: @"Marks a thread as ""done."" Marking a thread as ""done"" is equivalent to marking a notification in your notification inbox on GitHub as done: https://github.com/notifications.")
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
            await _client.Activity.ActivityMarkThreadAsDoneAsync(
                threadId: threadId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}