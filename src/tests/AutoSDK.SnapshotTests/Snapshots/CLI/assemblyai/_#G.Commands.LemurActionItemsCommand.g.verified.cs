//HintName: G.Commands.LemurActionItemsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LemurActionItemsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.LemurActionItemsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public LemurActionItemsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "lemur",
            description: @"Use LeMUR to generate a list of action items from a transcript")
        {
            _client = client;
            _serviceProvider = serviceProvider;


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
            var response = await _client.LeMUR.LemurActionItemsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}