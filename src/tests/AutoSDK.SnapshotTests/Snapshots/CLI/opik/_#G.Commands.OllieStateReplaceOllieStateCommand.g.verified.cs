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

            byte[] request,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<long?> ContentLength { get; } = new(
            name: "contentLength")
        {
            Description = @"",
        };


        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: "request-body")
        {
            Description = @"The request body as JSON.",
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

            Arguments.Add(RequestBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var contentLength = parseResult.GetRequiredValue(ContentLength);

            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<byte[]>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException("Failed to deserialize request body.");

            Validate(
                parseResult: parseResult,
                contentLength: contentLength,

                request: request,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.OllieState.ReplaceOllieStateAsync(
                contentLength: contentLength,

                request: request,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}