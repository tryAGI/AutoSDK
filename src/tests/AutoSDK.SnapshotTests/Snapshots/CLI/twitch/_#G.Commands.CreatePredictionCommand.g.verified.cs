//HintName: G.Commands.CreatePredictionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreatePredictionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = @"The question that the broadcaster is asking. For example, _Will I finish this entire pizza?_ The title is limited to a maximum of 45 characters.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.CreatePredictionBodyOutcome>> Outcomes { get; } = new(
            name: "outcomes")
        {
            Description = @"The list of possible outcomes that the viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 10 choices.",
        };

        private global::System.CommandLine.Argument<int> PredictionWindow { get; } = new(
            name: "predictionWindow")
        {
            Description = @"The length of time (in seconds) that the prediction will run for. The minimum is 30 seconds and the maximum is 1800 seconds (30 minutes).",
        };

        public CreatePredictionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a Channel Points Prediction.

With a Channel Points Prediction, the broadcaster poses a question and viewers try to predict the outcome. The prediction runs as soon as it’s created. The broadcaster may run only one prediction at a time.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:predictions** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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