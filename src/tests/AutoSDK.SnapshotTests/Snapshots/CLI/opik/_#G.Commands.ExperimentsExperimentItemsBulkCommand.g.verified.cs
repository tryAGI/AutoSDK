//HintName: G.Commands.ExperimentsExperimentItemsBulkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsExperimentItemsBulkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string experimentName,
            string datasetName,
            global::System.Guid? experimentId,
            global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecordExperimentItemBulkWriteView> items,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExperimentName { get; } = new(
            name: "experimentName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> DatasetName { get; } = new(
            name: "datasetName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ExperimentItemBulkRecordExperimentItemBulkWriteView>> Items { get; } = new(
            name: "items")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ExperimentId { get; } = new(
            name: "experimentId")
        {
            Description = @"Optional experiment ID. If provided, items will be added to the existing experiment and experimentName will be ignored. If not provided or experiment with that ID doesn't exist, a new experiment will be created with the given experimentName",
        };


        public ExperimentsExperimentItemsBulkCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "experiment",
            description: @"Record experiment items in bulk with traces, spans, and feedback scores. Maximum request size is 4MB.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExperimentName);
            Arguments.Add(DatasetName);
            Arguments.Add(Items);
            Options.Add(ExperimentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var experimentName = parseResult.GetRequiredValue(ExperimentName);
            var datasetName = parseResult.GetRequiredValue(DatasetName);
            var experimentId = parseResult.GetRequiredValue(ExperimentId);
            var items = parseResult.GetRequiredValue(Items);

            Validate(
                parseResult: parseResult,
                experimentName: experimentName,
                datasetName: datasetName,
                experimentId: experimentId,
                items: items,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Experiments.ExperimentItemsBulkAsync(
                experimentName: experimentName,
                datasetName: datasetName,
                experimentId: experimentId,
                items: items,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}