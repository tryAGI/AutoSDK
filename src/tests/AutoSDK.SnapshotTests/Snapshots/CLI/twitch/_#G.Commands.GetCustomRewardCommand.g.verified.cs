//HintName: G.Commands.GetCustomRewardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetCustomRewardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? id,
            bool? onlyManageableRewards,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetCustomRewardResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> OnlyManageableRewards { get; } = new(
            name: "onlyManageableRewards")
        {
            Description = "",
        };
        public GetCustomRewardCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets a list of custom rewards that the specified broadcaster created.

**NOTE**: A channel may offer a maximum of 50 rewards, which includes both enabled and disabled rewards.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:redemptions** or **channel:manage:redemptions** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Options.Add(Id);
            Options.Add(OnlyManageableRewards);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);
            var onlyManageableRewards = parseResult.GetRequiredValue(OnlyManageableRewards);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                onlyManageableRewards: onlyManageableRewards,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChannelPoints.GetCustomRewardAsync(
                broadcasterId: broadcasterId,
                id: id,
                onlyManageableRewards: onlyManageableRewards,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}