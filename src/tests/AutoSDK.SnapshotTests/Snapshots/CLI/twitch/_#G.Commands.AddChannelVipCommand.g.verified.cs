//HintName: G.Commands.AddChannelVipCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AddChannelVipCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string userId,
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> UserId { get; } = new(
            name: "userId")
        {
            Description = @"The ID of the user to give VIP status to.",
        };

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that’s adding the user as a VIP. This ID must match the user ID in the access token.",
        };

        public AddChannelVipCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "add",
            description: @"Adds the specified user as a VIP in the broadcaster’s channel.

**Rate Limits**: The broadcaster may add a maximum of 10 VIPs within a 10-second window.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:vips** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(UserId);
            Arguments.Add(BroadcasterId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var userId = parseResult.GetRequiredValue(UserId);
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);

            Validate(
                parseResult: parseResult,
                userId: userId,
                broadcasterId: broadcasterId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Moderation.AddChannelVipAsync(
                userId: userId,
                broadcasterId: broadcasterId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}