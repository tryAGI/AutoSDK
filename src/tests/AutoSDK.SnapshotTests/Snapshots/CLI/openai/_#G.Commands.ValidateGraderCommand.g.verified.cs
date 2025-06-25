//HintName: G.Commands.ValidateGraderCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ValidateGraderCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti> grader,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ValidateGraderResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderMulti>> Grader { get; } = new(
            name: "grader")
        {
            Description = "",
        };

        public ValidateGraderCommand(G.IOpenAiClient client) : base(
            name: "validate",
            description: @"")
        {
            _client = client;

            Arguments.Add(Grader);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var grader = parseResult.GetRequiredValue(Grader);

            Validate(
                parseResult: parseResult,
                grader: grader,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.ValidateGraderAsync(
                grader: grader,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}