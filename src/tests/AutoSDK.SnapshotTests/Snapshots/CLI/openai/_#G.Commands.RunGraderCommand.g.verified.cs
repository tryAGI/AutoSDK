//HintName: G.Commands.RunGraderCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunGraderCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> grader,
            object? item,
            string modelSample,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.RunGraderResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti>> Grader { get; } = new(
            name: "grader")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModelSample { get; } = new(
            name: "modelSample")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> Item { get; } = new(
            name: "item")
        {
            Description = "",
        };
        public RunGraderCommand(G.IOpenAiClient client) : base(
            name: "run",
            description: @"")
        {
            _client = client;

            Arguments.Add(Grader);
            Arguments.Add(ModelSample);
            Options.Add(Item);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var grader = parseResult.GetRequiredValue(Grader);
            var item = parseResult.GetRequiredValue(Item);
            var modelSample = parseResult.GetRequiredValue(ModelSample);

            Validate(
                parseResult: parseResult,
                grader: grader,
                item: item,
                modelSample: modelSample,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.RunGraderAsync(
                grader: grader,
                item: item,
                modelSample: modelSample,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}