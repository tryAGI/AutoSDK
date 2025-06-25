//HintName: G.Commands.StartCommercialCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class StartCommercialCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            int length,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.StartCommercialResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> Length { get; } = new(
            name: "length")
        {
            Description = @"",
        };

        public StartCommercialCommand(G.IApi client) : base(
            name: "start",
            description: @"Starts a commercial on the specified channel.

**NOTE**: Only partners and affiliates may run commercials and they must be streaming live at the time.

**NOTE**: Only the broadcaster may start a commercial; the broadcaster’s editors and moderators may not start commercials on behalf of the broadcaster.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:edit:commercial** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Length);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var length = parseResult.GetRequiredValue(Length);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                length: length,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Ads.StartCommercialAsync(
                broadcasterId: broadcasterId,
                length: length,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}