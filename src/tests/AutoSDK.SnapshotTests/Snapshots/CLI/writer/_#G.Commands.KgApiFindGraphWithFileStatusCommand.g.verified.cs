//HintName: G.Commands.KgApiFindGraphWithFileStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiFindGraphWithFileStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid graphId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Graph response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> GraphId { get; } = new(
            name: "graphId")
        {
            Description = @"The unique identifier of the Knowledge Graph.",
        };



        public KgApiFindGraphWithFileStatusCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Retrieve a Knowledge Graph.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GraphId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var graphId = parseResult.GetRequiredValue(GraphId);

            Validate(
                parseResult: parseResult,
                graphId: graphId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.KgApi.FindGraphWithFileStatusAsync(
                graphId: graphId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}