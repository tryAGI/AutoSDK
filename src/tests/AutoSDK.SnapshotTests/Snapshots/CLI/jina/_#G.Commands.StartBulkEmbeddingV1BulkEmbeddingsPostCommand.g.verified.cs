//HintName: G.Commands.StartBulkEmbeddingV1BulkEmbeddingsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartBulkEmbeddingV1BulkEmbeddingsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            string? email,
            string model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BulkEmbeddingJobResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Email { get; } = new(
            name: "email")
        {
            Description = @"",
        };
        public StartBulkEmbeddingV1BulkEmbeddingsPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "start",
            description: @"Upload a file and get embeddings for each row")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Model);
            Options.Add(Email);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var email = parseResult.GetRequiredValue(Email);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                email: email,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.BulkEmbeddings.StartBulkEmbeddingV1BulkEmbeddingsPostAsync(
                file: file,
                filename: filename,
                email: email,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}