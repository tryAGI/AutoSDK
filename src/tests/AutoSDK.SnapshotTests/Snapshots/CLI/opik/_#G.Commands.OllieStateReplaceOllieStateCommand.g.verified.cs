//HintName: G.Commands.OllieStateReplaceOllieStateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OllieStateReplaceOllieStateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            long? contentLength,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<long?> ContentLength { get; } = new(
            name: "contentLength")
        {
            Description = @"",
        };


        public OllieStateReplaceOllieStateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "replace",
            description: @"Upload gzip-compressed SQLite DB file, replacing any existing state")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ContentLength);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentLength = parseResult.GetRequiredValue(ContentLength);

            Validate(
                parseResult: parseResult,
                contentLength: contentLength,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.OllieState.ReplaceOllieStateAsync(
                contentLength: contentLength,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}