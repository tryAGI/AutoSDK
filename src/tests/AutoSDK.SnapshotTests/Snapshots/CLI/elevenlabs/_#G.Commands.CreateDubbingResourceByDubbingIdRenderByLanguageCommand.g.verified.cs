//HintName: G.Commands.CreateDubbingResourceByDubbingIdRenderByLanguageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDubbingResourceByDubbingIdRenderByLanguageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string dubbingId,
            string language,
            string? xiApiKey,
            global::G.RenderType renderType,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DubbingRenderResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DubbingId { get; } = new(
            name: "dubbingId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.RenderType> RenderType { get; } = new(
            name: "renderType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateDubbingResourceByDubbingIdRenderByLanguageCommand(G.IApi client) : base(
            name: "create",
            description: @"Regenerate the output media for a language using the latest Studio state. Please ensure all segments have been dubbed before rendering, otherwise they will be omitted. Renders are generated asynchronously, and to check the status of all renders please use the 'Get Dubbing Resource' endpoint.")
        {
            _client = client;

            Arguments.Add(DubbingId);
            Arguments.Add(Language);
            Arguments.Add(RenderType);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var dubbingId = parseResult.GetRequiredValue(DubbingId);
            var language = parseResult.GetRequiredValue(Language);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var renderType = parseResult.GetRequiredValue(RenderType);

            Validate(
                parseResult: parseResult,
                dubbingId: dubbingId,
                language: language,
                xiApiKey: xiApiKey,
                renderType: renderType,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dubbing.CreateDubbingResourceByDubbingIdRenderByLanguageAsync(
                dubbingId: dubbingId,
                language: language,
                xiApiKey: xiApiKey,
                renderType: renderType,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}