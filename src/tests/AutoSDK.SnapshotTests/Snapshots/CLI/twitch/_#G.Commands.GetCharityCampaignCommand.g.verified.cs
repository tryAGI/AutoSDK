//HintName: G.Commands.GetCharityCampaignCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetCharityCampaignCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetCharityCampaignResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that’s currently running a charity campaign. This ID must match the user ID in the access token.",
        };

        public GetCharityCampaignCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Gets information about the charity campaign that a broadcaster is running. For example, the campaign’s fundraising goal and the current amount of donations.

To receive events when progress is made towards the campaign’s goal or the broadcaster changes the fundraising goal, subscribe to the [channel.charity\_campaign.progress](https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#channelcharity%5Fcampaignprogress) subscription type.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:read:charity** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Charity.GetCharityCampaignAsync(
                broadcasterId: broadcasterId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}