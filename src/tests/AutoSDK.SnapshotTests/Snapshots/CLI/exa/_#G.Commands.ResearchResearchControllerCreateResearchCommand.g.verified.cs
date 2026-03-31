//HintName: G.Commands.ResearchResearchControllerCreateResearchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResearchResearchControllerCreateResearchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ResearchCreateRequestDtoClassModel? model,
            string instructions,
            object? outputSchema,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ResearchDtoClass response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Instructions { get; } = new(
            name: "instructions")
        {
            Description = @"Instructions for what research should be conducted",
        };

        private global::System.CommandLine.Option<global::G.ResearchCreateRequestDtoClassModel?> Model { get; } = new(
            name: "model")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> OutputSchema { get; } = new(
            name: "outputSchema")
        {
            Description = @"",
        };


        public ResearchResearchControllerCreateResearchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "research",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Instructions);
            Options.Add(Model);
            Options.Add(OutputSchema);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var instructions = parseResult.GetRequiredValue(Instructions);
            var outputSchema = parseResult.GetRequiredValue(OutputSchema);

            Validate(
                parseResult: parseResult,
                model: model,
                instructions: instructions,
                outputSchema: outputSchema,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ResearchControllerCreateResearchAsync(
                model: model,
                instructions: instructions,
                outputSchema: outputSchema,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}