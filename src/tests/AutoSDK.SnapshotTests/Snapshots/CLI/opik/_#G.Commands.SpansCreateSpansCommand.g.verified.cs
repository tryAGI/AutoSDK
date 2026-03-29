//HintName: G.Commands.SpansCreateSpansCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SpansCreateSpansCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.SpanWrite> spans,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.SpanWrite>> Spans { get; } = new(
            name: "spans")
        {
            Description = @"",
        };



        public SpansCreateSpansCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create spans")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Spans);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var spans = parseResult.GetRequiredValue(Spans);

            Validate(
                parseResult: parseResult,
                spans: spans,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Spans.CreateSpansAsync(
                spans: spans,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}