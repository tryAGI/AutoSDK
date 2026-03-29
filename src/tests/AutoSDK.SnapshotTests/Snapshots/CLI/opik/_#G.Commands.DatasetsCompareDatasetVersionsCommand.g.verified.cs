//HintName: G.Commands.DatasetsCompareDatasetVersionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsCompareDatasetVersionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetVersionDiff response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };



        public DatasetsCompareDatasetVersionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "compare",
            description: @"Compare the latest committed dataset version with the current draft state. This endpoint provides insights into changes made since the last version was committed. The comparison calculates additions, modifications, deletions, and unchanged items between the latest version snapshot and current draft.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.CompareDatasetVersionsAsync(
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}