//HintName: G.Commands.CancelPredictionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelPredictionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string predictionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> PredictionId { get; } = new(
            name: "predictionId")
        {
            Description = @"",
        };

        public CancelPredictionsCommand(G.IApi client) : base(
            name: "cancel",
            description: @"")
        {
            _client = client;

            Arguments.Add(PredictionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var predictionId = parseResult.GetRequiredValue(PredictionId);

            Validate(
                parseResult: parseResult,
                predictionId: predictionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CancelPredictionsAsync(
                predictionId: predictionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}