//HintName: G.Commands.LemurTaskCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LemurTaskCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LemurTaskResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public LemurTaskCommand(G.IApi client) : base(
            name: "lemur",
            description: @"Use the LeMUR task endpoint to input your own LLM prompt.")
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
            var response = await _client.LeMUR.LemurTaskAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}