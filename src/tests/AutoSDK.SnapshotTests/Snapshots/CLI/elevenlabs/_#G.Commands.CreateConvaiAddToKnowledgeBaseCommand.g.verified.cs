//HintName: G.Commands.CreateConvaiAddToKnowledgeBaseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateConvaiAddToKnowledgeBaseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string? name,
            string? url,
            byte[]? file,
            string? filename,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddKnowledgeBaseResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


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

        private global::System.CommandLine.Option<string?> Url { get; } = new(
            name: "url")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };
        public CreateConvaiAddToKnowledgeBaseCommand(G.IApi client) : base(
            name: "create",
            description: @"Uploads a file or reference a webpage for the agent to use as part of it's knowledge base")
        {
            _client = client;

            Options.Add(XiApiKey);
            Options.Add(Name);
            Options.Add(Url);
            Options.Add(File);
            Options.Add(Filename);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var url = parseResult.GetRequiredValue(Url);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                url: url,
                file: file,
                filename: filename,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.CreateConvaiAddToKnowledgeBaseAsync(
                xiApiKey: xiApiKey,
                name: name,
                url: url,
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