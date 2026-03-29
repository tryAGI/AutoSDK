//HintName: G.Commands.PromptsRestorePromptVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsRestorePromptVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid promptId,
            global::System.Guid versionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PromptVersionDetail response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> PromptId { get; } = new(
            name: "promptId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Guid> VersionId { get; } = new(
            name: "versionId")
        {
            Description = @"",
        };



        public PromptsRestorePromptVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "restore",
            description: @"Restore a prompt version by creating a new version with the content from the specified version")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(PromptId);
            Arguments.Add(VersionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var promptId = parseResult.GetRequiredValue(PromptId);
            var versionId = parseResult.GetRequiredValue(VersionId);

            Validate(
                parseResult: parseResult,
                promptId: promptId,
                versionId: versionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.RestorePromptVersionAsync(
                promptId: promptId,
                versionId: versionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}