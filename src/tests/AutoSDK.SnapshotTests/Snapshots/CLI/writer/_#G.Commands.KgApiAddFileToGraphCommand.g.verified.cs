//HintName: G.Commands.KgApiAddFileToGraphCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiAddFileToGraphCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid graphId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FileResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> GraphId { get; } = new(
            name: "graphId")
        {
            Description = @"The unique identifier of the Knowledge Graph.",
        };

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The unique identifier of the file.",
        };



        public KgApiAddFileToGraphCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "add",
            description: @"Add a file to a Knowledge Graph.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GraphId);
            Arguments.Add(FileId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var graphId = parseResult.GetRequiredValue(GraphId);
            var fileId = parseResult.GetRequiredValue(FileId);

            Validate(
                parseResult: parseResult,
                graphId: graphId,
                fileId: fileId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.KgApi.AddFileToGraphAsync(
                graphId: graphId,
                fileId: fileId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}