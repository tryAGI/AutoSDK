//HintName: G.Commands.DatasetsGetDatasetItemsOutputColumnsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsGetDatasetItemsOutputColumnsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? experimentIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PageColumns response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ExperimentIds { get; } = new(
            name: "experimentIds")
        {
            Description = @"",
        };


        public DatasetsGetDatasetItemsOutputColumnsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get dataset items output columns")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(ExperimentIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var experimentIds = parseResult.GetRequiredValue(ExperimentIds);

            Validate(
                parseResult: parseResult,
                id: id,
                experimentIds: experimentIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.GetDatasetItemsOutputColumnsAsync(
                id: id,
                experimentIds: experimentIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}