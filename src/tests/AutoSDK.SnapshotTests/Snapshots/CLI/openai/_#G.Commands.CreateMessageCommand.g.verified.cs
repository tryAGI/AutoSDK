//HintName: G.Commands.CreateMessageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateMessageCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string threadId,
            global::G.CreateMessageRequestRole role,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>>> content,
            global::System.Collections.Generic.IList<global::G.CreateMessageRequestAttachment>? attachments,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.MessageObject response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ThreadId { get; } = new(
            name: "threadId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.CreateMessageRequestRole> Role { get; } = new(
            name: "role")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentImageFileObject, global::G.MessageContentImageUrlObject, global::G.MessageRequestContentTextObject>>>> Content { get; } = new(
            name: "content")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateMessageRequestAttachment>?> Attachments { get; } = new(
            name: "attachments")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public CreateMessageCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(ThreadId);
            Arguments.Add(Role);
            Arguments.Add(Content);
            Options.Add(Attachments);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadId = parseResult.GetRequiredValue(ThreadId);
            var role = parseResult.GetRequiredValue(Role);
            var content = parseResult.GetRequiredValue(Content);
            var attachments = parseResult.GetRequiredValue(Attachments);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                threadId: threadId,
                role: role,
                content: content,
                attachments: attachments,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Assistants.CreateMessageAsync(
                threadId: threadId,
                role: role,
                content: content,
                attachments: attachments,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}