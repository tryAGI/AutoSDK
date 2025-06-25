//HintName: G.Commands.EditConvaiKnowledgeBaseByDocumentationIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class EditConvaiKnowledgeBaseByDocumentationIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            string? xiApiKey,
            string name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public EditConvaiKnowledgeBaseByDocumentationIdCommand(G.IApi client) : base(
            name: "edit",
            description: @"Update the name of a document")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Arguments.Add(Name);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentationId = parseResult.GetRequiredValue(DocumentationId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.EditConvaiKnowledgeBaseByDocumentationIdAsync(
                documentationId: documentationId,
                xiApiKey: xiApiKey,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}