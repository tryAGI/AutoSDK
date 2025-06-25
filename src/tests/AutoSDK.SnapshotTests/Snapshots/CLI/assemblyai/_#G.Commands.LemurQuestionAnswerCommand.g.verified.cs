//HintName: G.Commands.LemurQuestionAnswerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LemurQuestionAnswerCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LemurQuestionAnswerResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public LemurQuestionAnswerCommand(G.IApi client) : base(
            name: "lemur",
            description: @"Question & Answer allows you to ask free-form questions about a single transcript or a group of transcripts.
The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
")
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
            var response = await _client.LeMUR.LemurQuestionAnswerAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}