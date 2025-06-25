//HintName: G.Commands.LemurSummaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LemurSummaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LemurSummaryResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public LemurSummaryCommand(G.IApi client) : base(
            name: "lemur",
            description: @"Custom Summary allows you to distill a piece of audio into a few impactful sentences.
You can give the model context to obtain more targeted results while outputting the results in a variety of formats described in human language.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.LeMUR.LemurSummaryAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}