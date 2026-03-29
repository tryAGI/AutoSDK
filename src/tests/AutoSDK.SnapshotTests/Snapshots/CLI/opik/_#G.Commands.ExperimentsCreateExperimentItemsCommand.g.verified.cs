//HintName: G.Commands.ExperimentsCreateExperimentItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsCreateExperimentItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ExperimentItem> experimentItems,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.ExperimentItem>> ExperimentItems { get; } = new(
            name: "experimentItems")
        {
            Description = @"",
        };



        public ExperimentsCreateExperimentItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create experiment items")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExperimentItems);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var experimentItems = parseResult.GetRequiredValue(ExperimentItems);

            Validate(
                parseResult: parseResult,
                experimentItems: experimentItems,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Experiments.CreateExperimentItemsAsync(
                experimentItems: experimentItems,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}