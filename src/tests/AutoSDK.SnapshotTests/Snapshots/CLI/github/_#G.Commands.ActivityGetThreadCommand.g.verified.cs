//HintName: G.Commands.ActivityGetThreadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActivityGetThreadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int threadId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Thread response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        public ActivityGetThreadCommand(G.IApi client) : base(
            name: "activity",
            description: @"Gets information about a notification thread.")
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
            var response = await _client.Activity.ActivityGetThreadAsync(
                threadId: threadId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}