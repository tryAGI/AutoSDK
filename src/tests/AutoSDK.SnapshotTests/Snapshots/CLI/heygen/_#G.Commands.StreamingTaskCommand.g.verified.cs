//HintName: G.Commands.StreamingTaskCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StreamingTaskCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? sessionId,
            string? text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> SessionId { get; } = new(
            name: "sessionId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Text { get; } = new(
            name: "text")
        {
            Description = @"",
        };
        public StreamingTaskCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "streaming",
            description: @"streaming.task")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(SessionId);
            Options.Add(Text);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var sessionId = parseResult.GetRequiredValue(SessionId);
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                sessionId: sessionId,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.StreamingAPI.StreamingTaskAsync(
                sessionId: sessionId,
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}