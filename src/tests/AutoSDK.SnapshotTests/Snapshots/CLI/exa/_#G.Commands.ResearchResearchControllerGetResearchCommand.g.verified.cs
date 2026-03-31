//HintName: G.Commands.ResearchResearchControllerGetResearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResearchResearchControllerGetResearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string researchId,
            string stream,
            string events,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ResearchDtoClass response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResearchId { get; } = new(
            name: "researchId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Stream { get; } = new(
            name: "stream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Events { get; } = new(
            name: "events")
        {
            Description = @"",
        };



        public ResearchResearchControllerGetResearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "research",
            description: @"Retrieve research by ID. Add ?stream=true for real-time SSE updates.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ResearchId);
            Arguments.Add(Stream);
            Arguments.Add(Events);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var researchId = parseResult.GetRequiredValue(ResearchId);
            var stream = parseResult.GetRequiredValue(Stream);
            var events = parseResult.GetRequiredValue(Events);

            Validate(
                parseResult: parseResult,
                researchId: researchId,
                stream: stream,
                events: events,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ResearchControllerGetResearchAsync(
                researchId: researchId,
                stream: stream,
                events: events,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}