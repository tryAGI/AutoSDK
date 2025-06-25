//HintName: G.Commands.CreateEvalCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEvalCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.OneOf<global::G.CreateEvalCustomDataSourceConfig, global::G.CreateEvalLogsDataSourceConfig, global::G.CreateEvalStoredCompletionsDataSourceConfig> dataSourceConfig,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalLabelModelGrader, global::G.EvalGraderStringCheck?, global::G.EvalGraderTextSimilarity?, global::G.EvalGraderPython?, global::G.EvalGraderScoreModel?>> testingCriteria,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Eval response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<global::G.CreateEvalCustomDataSourceConfig, global::G.CreateEvalLogsDataSourceConfig, global::G.CreateEvalStoredCompletionsDataSourceConfig>> DataSourceConfig { get; } = new(
            name: "dataSourceConfig")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateEvalLabelModelGrader, global::G.EvalGraderStringCheck?, global::G.EvalGraderTextSimilarity?, global::G.EvalGraderPython?, global::G.EvalGraderScoreModel?>>> TestingCriteria { get; } = new(
            name: "testingCriteria")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public CreateEvalCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(DataSourceConfig);
            Arguments.Add(TestingCriteria);
            Options.Add(Name);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var dataSourceConfig = parseResult.GetRequiredValue(DataSourceConfig);
            var testingCriteria = parseResult.GetRequiredValue(TestingCriteria);

            Validate(
                parseResult: parseResult,
                name: name,
                metadata: metadata,
                dataSourceConfig: dataSourceConfig,
                testingCriteria: testingCriteria,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Evals.CreateEvalAsync(
                name: name,
                metadata: metadata,
                dataSourceConfig: dataSourceConfig,
                testingCriteria: testingCriteria,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}