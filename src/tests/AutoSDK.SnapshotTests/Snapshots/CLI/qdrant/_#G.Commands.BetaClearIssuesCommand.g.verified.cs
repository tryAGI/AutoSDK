//HintName: G.Commands.BetaClearIssuesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BetaClearIssuesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ClearIssuesResponse response,
            global::System.Threading.CancellationToken cancellationToken);




        public BetaClearIssuesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "clear",
            description: @"Removes all issues reported so far")
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
            var response = await _client.Beta.ClearIssuesAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}