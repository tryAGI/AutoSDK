//HintName: G.Commands.GetConduitsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConduitsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetConduitsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public GetConduitsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"NEW Gets the [conduits](https://dev.twitch.tv/docs/eventsub/handling-conduit-events) for a client ID.

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).")
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
            var response = await _client.Conduits.GetConduitsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}