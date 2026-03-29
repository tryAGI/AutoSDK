//HintName: G.Commands.PromptsGetPromptVersionByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsGetPromptVersionByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid versionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PromptVersionDetail response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> VersionId { get; } = new(
            name: "versionId")
        {
            Description = @"",
        };



        public PromptsGetPromptVersionByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get prompt version by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(VersionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var versionId = parseResult.GetRequiredValue(VersionId);

            Validate(
                parseResult: parseResult,
                versionId: versionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Prompts.GetPromptVersionByIdAsync(
                versionId: versionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}