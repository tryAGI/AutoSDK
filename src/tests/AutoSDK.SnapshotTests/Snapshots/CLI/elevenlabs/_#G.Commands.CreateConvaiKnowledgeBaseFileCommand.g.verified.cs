//HintName: G.Commands.CreateConvaiKnowledgeBaseFileCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiKnowledgeBaseFileCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            byte[] file,
            string filename,
            string? name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddKnowledgeBaseResponseModel response,
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

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };
        public CreateConvaiKnowledgeBaseFileCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a knowledge base document generated form the uploaded file.")
        {
            _client = client;

            Arguments.Add(File);
            Arguments.Add(Filename);
            Options.Add(XiApiKey);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiKnowledgeBaseFileAsync(
                xiApiKey: xiApiKey,
                file: file,
                filename: filename,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}