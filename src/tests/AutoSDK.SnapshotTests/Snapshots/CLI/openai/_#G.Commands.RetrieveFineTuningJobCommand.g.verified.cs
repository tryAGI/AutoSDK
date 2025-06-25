//HintName: G.Commands.RetrieveFineTuningJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RetrieveFineTuningJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fineTuningJobId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FineTuningJob response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FineTuningJobId { get; } = new(
            name: "fineTuningJobId")
        {
            Description = "",
        };

        public RetrieveFineTuningJobCommand(G.IOpenAiClient client) : base(
            name: "retrieve",
            description: @"")
        {
            _client = client;

            Arguments.Add(FineTuningJobId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fineTuningJobId = parseResult.GetRequiredValue(FineTuningJobId);

            Validate(
                parseResult: parseResult,
                fineTuningJobId: fineTuningJobId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.RetrieveFineTuningJobAsync(
                fineTuningJobId: fineTuningJobId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}