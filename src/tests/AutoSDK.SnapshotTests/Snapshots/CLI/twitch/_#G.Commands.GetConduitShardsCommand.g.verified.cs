//HintName: G.Commands.GetConduitShardsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetConduitShardsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string conduitId,
            string? status,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetConduitShardsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ConduitId { get; } = new(
            name: "conduitId")
        {
            Description = @"Conduit ID.",
        };

        private global::System.CommandLine.Option<string?> Status { get; } = new(
            name: "status")
        {
            Description = @"Status to filter by.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The cursor used to get the next page of results. The pagination object in the response contains the cursor’s value.",
        };
        public GetConduitShardsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"NEW Gets a lists of all shards for a [conduit](https://dev.twitch.tv/docs/eventsub/handling-conduit-events).

__Authorization:__

Requires an [app access token](https://dev.twitch.tv/docs/authentication#app-access-tokens).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ConduitId);
            Options.Add(Status);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var conduitId = parseResult.GetRequiredValue(ConduitId);
            var status = parseResult.GetRequiredValue(Status);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                conduitId: conduitId,
                status: status,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Conduits.GetConduitShardsAsync(
                conduitId: conduitId,
                status: status,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}