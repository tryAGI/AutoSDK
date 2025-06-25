//HintName: G.Commands.DeleteConvaiKnowledgeBaseByDocumentationIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteConvaiKnowledgeBaseByDocumentationIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string documentationId,
            bool? force,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DocumentationId { get; } = new(
            name: "documentationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Force { get; } = new(
            name: "force")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public DeleteConvaiKnowledgeBaseByDocumentationIdCommand(G.IApi client) : base(
            name: "delete",
            description: @"Delete a document from the knowledge base")
        {
            _client = client;

            Arguments.Add(DocumentationId);
            Options.Add(Force);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var documentationId = parseResult.GetRequiredValue(DocumentationId);
            var force = parseResult.GetRequiredValue(Force);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                documentationId: documentationId,
                force: force,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ConversationalAI.DeleteConvaiKnowledgeBaseByDocumentationIdAsync(
                documentationId: documentationId,
                force: force,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}