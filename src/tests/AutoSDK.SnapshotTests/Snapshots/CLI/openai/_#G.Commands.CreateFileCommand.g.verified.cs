//HintName: G.Commands.CreateFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            byte[] file,
            string filename,
            global::G.CreateFileRequestPurpose purpose,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OpenAIFile response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<byte[]> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.CreateFileRequestPurpose> Purpose { get; } = new(
            name: "purpose")
        {
            Description = "",
        };

        public CreateFileCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Arguments.Add(Purpose);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var purpose = parseResult.GetRequiredValue(Purpose);

            Validate(
                parseResult: parseResult,
                file: file,
                filename: filename,
                purpose: purpose,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Files.CreateFileAsync(
                file: file,
                filename: filename,
                purpose: purpose,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}