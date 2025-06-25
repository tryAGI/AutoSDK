//HintName: G.Commands.CreateCustomRewardsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateCustomRewardsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string title,
            long cost,
            string? prompt,
            bool? isEnabled,
            string? backgroundColor,
            bool? isUserInputRequired,
            bool? isMaxPerStreamEnabled,
            int? maxPerStream,
            bool? isMaxPerUserPerStreamEnabled,
            int? maxPerUserPerStream,
            bool? isGlobalCooldownEnabled,
            int? globalCooldownSeconds,
            bool? shouldRedemptionsSkipRequestQueue,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateCustomRewardsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster to add the custom reward to. This ID must match the user ID found in the OAuth token.",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = @"The custom reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.",
        };

        private global::System.CommandLine.Argument<long> Cost { get; } = new(
            name: "cost")
        {
            Description = @"The cost of the reward, in Channel Points. The minimum is 1 point.",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.",
        };

        private global::System.CommandLine.Option<bool?> IsEnabled { get; } = new(
            name: "isEnabled")
        {
            Description = @"A Boolean value that determines whether the reward is enabled. Viewers see only enabled rewards. The default is **true**.",
        };

        private global::System.CommandLine.Option<string?> BackgroundColor { get; } = new(
            name: "backgroundColor")
        {
            Description = @"The background color to use for the reward. Specify the color using Hex format (for example, #9147FF).",
        };

        private global::System.CommandLine.Option<bool?> IsUserInputRequired { get; } = new(
            name: "isUserInputRequired")
        {
            Description = @"A Boolean value that determines whether the user needs to enter information when redeeming the reward. See the `prompt` field. The default is **false**.",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerStreamEnabled { get; } = new(
            name: "isMaxPerStreamEnabled")
        {
            Description = @"A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). The default is **false**.",
        };

        private global::System.CommandLine.Option<int?> MaxPerStream { get; } = new(
            name: "maxPerStream")
        {
            Description = @"The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerUserPerStreamEnabled { get; } = new(
            name: "isMaxPerUserPerStreamEnabled")
        {
            Description = @"A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see the `max_per_user_per_stream` field). The default is **false**.",
        };

        private global::System.CommandLine.Option<int?> MaxPerUserPerStream { get; } = new(
            name: "maxPerUserPerStream")
        {
            Description = @"The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**. The minimum value is 1.",
        };

        private global::System.CommandLine.Option<bool?> IsGlobalCooldownEnabled { get; } = new(
            name: "isGlobalCooldownEnabled")
        {
            Description = @"A Boolean value that determines whether to apply a cooldown period between redemptions (see the `global_cooldown_seconds` field for the duration of the cooldown period). The default is **false**.",
        };

        private global::System.CommandLine.Option<int?> GlobalCooldownSeconds { get; } = new(
            name: "globalCooldownSeconds")
        {
            Description = @"The cooldown period, in seconds. Applied only if the `is_global_cooldown_enabled` field is **true**. The minimum value is 1; however, the minimum value is 60 for it to be shown in the Twitch UX.",
        };

        private global::System.CommandLine.Option<bool?> ShouldRedemptionsSkipRequestQueue { get; } = new(
            name: "shouldRedemptionsSkipRequestQueue")
        {
            Description = @"A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process. The default is **false**.",
        };
        public CreateCustomRewardsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a Custom Reward in the broadcaster’s channel. The maximum number of custom rewards per channel is 50, which includes both enabled and disabled rewards.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Title);
            Arguments.Add(Cost);
            Options.Add(Prompt);
            Options.Add(IsEnabled);
            Options.Add(BackgroundColor);
            Options.Add(IsUserInputRequired);
            Options.Add(IsMaxPerStreamEnabled);
            Options.Add(MaxPerStream);
            Options.Add(IsMaxPerUserPerStreamEnabled);
            Options.Add(MaxPerUserPerStream);
            Options.Add(IsGlobalCooldownEnabled);
            Options.Add(GlobalCooldownSeconds);
            Options.Add(ShouldRedemptionsSkipRequestQueue);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var title = parseResult.GetRequiredValue(Title);
            var cost = parseResult.GetRequiredValue(Cost);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var isEnabled = parseResult.GetRequiredValue(IsEnabled);
            var backgroundColor = parseResult.GetRequiredValue(BackgroundColor);
            var isUserInputRequired = parseResult.GetRequiredValue(IsUserInputRequired);
            var isMaxPerStreamEnabled = parseResult.GetRequiredValue(IsMaxPerStreamEnabled);
            var maxPerStream = parseResult.GetRequiredValue(MaxPerStream);
            var isMaxPerUserPerStreamEnabled = parseResult.GetRequiredValue(IsMaxPerUserPerStreamEnabled);
            var maxPerUserPerStream = parseResult.GetRequiredValue(MaxPerUserPerStream);
            var isGlobalCooldownEnabled = parseResult.GetRequiredValue(IsGlobalCooldownEnabled);
            var globalCooldownSeconds = parseResult.GetRequiredValue(GlobalCooldownSeconds);
            var shouldRedemptionsSkipRequestQueue = parseResult.GetRequiredValue(ShouldRedemptionsSkipRequestQueue);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                title: title,
                cost: cost,
                prompt: prompt,
                isEnabled: isEnabled,
                backgroundColor: backgroundColor,
                isUserInputRequired: isUserInputRequired,
                isMaxPerStreamEnabled: isMaxPerStreamEnabled,
                maxPerStream: maxPerStream,
                isMaxPerUserPerStreamEnabled: isMaxPerUserPerStreamEnabled,
                maxPerUserPerStream: maxPerUserPerStream,
                isGlobalCooldownEnabled: isGlobalCooldownEnabled,
                globalCooldownSeconds: globalCooldownSeconds,
                shouldRedemptionsSkipRequestQueue: shouldRedemptionsSkipRequestQueue,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChannelPoints.CreateCustomRewardsAsync(
                broadcasterId: broadcasterId,
                title: title,
                cost: cost,
                prompt: prompt,
                isEnabled: isEnabled,
                backgroundColor: backgroundColor,
                isUserInputRequired: isUserInputRequired,
                isMaxPerStreamEnabled: isMaxPerStreamEnabled,
                maxPerStream: maxPerStream,
                isMaxPerUserPerStreamEnabled: isMaxPerUserPerStreamEnabled,
                maxPerUserPerStream: maxPerUserPerStream,
                isGlobalCooldownEnabled: isGlobalCooldownEnabled,
                globalCooldownSeconds: globalCooldownSeconds,
                shouldRedemptionsSkipRequestQueue: shouldRedemptionsSkipRequestQueue,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}