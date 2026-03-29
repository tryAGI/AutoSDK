//HintName: G.Commands.ExperimentsStreamExperimentItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsStreamExperimentItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string experimentName,
            int? limit,
            global::System.Guid? lastRetrievedId,
            bool? truncate,
            string? projectName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExperimentName { get; } = new(
            name: "experimentName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> LastRetrievedId { get; } = new(
            name: "lastRetrievedId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> Truncate { get; } = new(
            name: "truncate")
        {
            Description = @"Truncate image included in either input, output or metadata",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };


        public ExperimentsStreamExperimentItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "stream",
            description: @"Stream experiment items")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExperimentName);
            Options.Add(Limit);
            Options.Add(LastRetrievedId);
            Options.Add(Truncate);
            Options.Add(ProjectName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var experimentName = parseResult.GetRequiredValue(ExperimentName);
            var limit = parseResult.GetRequiredValue(Limit);
            var lastRetrievedId = parseResult.GetRequiredValue(LastRetrievedId);
            var truncate = parseResult.GetRequiredValue(Truncate);
            var projectName = parseResult.GetRequiredValue(ProjectName);

            Validate(
                parseResult: parseResult,
                experimentName: experimentName,
                limit: limit,
                lastRetrievedId: lastRetrievedId,
                truncate: truncate,
                projectName: projectName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Experiments.StreamExperimentItemsAsync(
                experimentName: experimentName,
                limit: limit,
                lastRetrievedId: lastRetrievedId,
                truncate: truncate,
                projectName: projectName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}