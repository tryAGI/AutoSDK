//HintName: G.Commands.CancelTrainingsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CancelTrainingsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string trainingId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> TrainingId { get; } = new(
            name: "trainingId")
        {
            Description = "",
        };

        public CancelTrainingsCommand(G.IApi client) : base(
            name: "cancel",
            description: @"")
        {
            _client = client;

            Arguments.Add(TrainingId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var trainingId = parseResult.GetRequiredValue(TrainingId);

            Validate(
                parseResult: parseResult,
                trainingId: trainingId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.CancelTrainingsAsync(
                trainingId: trainingId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}