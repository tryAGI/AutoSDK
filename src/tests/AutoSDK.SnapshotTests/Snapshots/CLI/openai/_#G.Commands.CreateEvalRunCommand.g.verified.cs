//HintName: G.Commands.CreateEvalRunCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateEvalRunCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string evalId,
            string? name,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.OneOf<global::G.CreateEvalJsonlRunDataSource, global::G.CreateEvalCompletionsRunDataSource, global::G.CreateEvalResponsesRunDataSource> dataSource,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.EvalRun response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> EvalId { get; } = new(
            name: "evalId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.OneOf<global::G.CreateEvalJsonlRunDataSource, global::G.CreateEvalCompletionsRunDataSource, global::G.CreateEvalResponsesRunDataSource>> DataSource { get; } = new(
            name: "dataSource")
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
        public CreateEvalRunCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(EvalId);
            Arguments.Add(DataSource);
            Options.Add(Name);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var evalId = parseResult.GetRequiredValue(EvalId);
            var name = parseResult.GetRequiredValue(Name);
            var metadata = parseResult.GetRequiredValue(Metadata);
            var dataSource = parseResult.GetRequiredValue(DataSource);

            Validate(
                parseResult: parseResult,
                evalId: evalId,
                name: name,
                metadata: metadata,
                dataSource: dataSource,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Evals.CreateEvalRunAsync(
                evalId: evalId,
                name: name,
                metadata: metadata,
                dataSource: dataSource,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}