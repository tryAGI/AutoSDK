//HintName: G.Commands.CreatePredictionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePredictionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string title,
            global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcome> outcomes,
            int predictionWindow,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreatePredictionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcome>> Outcomes { get; } = new(
            name: "outcomes")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> PredictionWindow { get; } = new(
            name: "predictionWindow")
        {
            Description = @"",
        };

        public CreatePredictionCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a Channel Points Prediction.

With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome. The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Title);
            Arguments.Add(Outcomes);
            Arguments.Add(PredictionWindow);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var title = parseResult.GetRequiredValue(Title);
            var outcomes = parseResult.GetRequiredValue(Outcomes);
            var predictionWindow = parseResult.GetRequiredValue(PredictionWindow);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                title: title,
                outcomes: outcomes,
                predictionWindow: predictionWindow,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Predictions.CreatePredictionAsync(
                broadcasterId: broadcasterId,
                title: title,
                outcomes: outcomes,
                predictionWindow: predictionWindow,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}