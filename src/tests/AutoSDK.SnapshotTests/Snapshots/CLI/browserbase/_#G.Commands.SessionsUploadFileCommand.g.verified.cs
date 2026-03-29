//HintName: G.Commands.SessionsUploadFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SessionsUploadFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string id,
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.SessionsUploadFileResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

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



        public SessionsUploadFileCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "sessions",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(File);
            Arguments.Add(Filename);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);

            Validate(
                parseResult: parseResult,
                id: id,
                file: file,
                filename: filename,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SessionsUploadFileAsync(
                id: id,
                file: file,
                filename: filename,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}