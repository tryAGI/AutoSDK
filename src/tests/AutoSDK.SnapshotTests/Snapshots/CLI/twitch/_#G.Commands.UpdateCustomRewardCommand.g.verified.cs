//HintName: G.Commands.UpdateCustomRewardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateCustomRewardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string id,
            string? title,
            string? prompt,
            long? cost,
            string? backgroundColor,
            bool? isEnabled,
            bool? isUserInputRequired,
            bool? isMaxPerStreamEnabled,
            long? maxPerStream,
            bool? isMaxPerUserPerStreamEnabled,
            long? maxPerUserPerStream,
            bool? isGlobalCooldownEnabled,
            long? globalCooldownSeconds,
            bool? isPaused,
            bool? shouldRedemptionsSkipRequestQueue,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateCustomRewardResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster that’s updating the reward. This ID must match the user ID found in the OAuth token.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of the reward to update.",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"The reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"The prompt shown to the viewer when they redeem the reward. Specify a prompt if `is_user_input_required` is **true**. The prompt is limited to a maximum of 200 characters.",
        };

        private global::System.CommandLine.Option<long?> Cost { get; } = new(
            name: "cost")
        {
            Description = @"The cost of the reward, in channel points. The minimum is 1 point.",
        };

        private global::System.CommandLine.Option<string?> BackgroundColor { get; } = new(
            name: "backgroundColor")
        {
            Description = @"The background color to use for the reward. Specify the color using Hex format (for example, \\#00E5CB).",
        };

        private global::System.CommandLine.Option<bool?> IsEnabled { get; } = new(
            name: "isEnabled")
        {
            Description = @"A Boolean value that indicates whether the reward is enabled. Set to **true** to enable the reward. Viewers see only enabled rewards.",
        };

        private global::System.CommandLine.Option<bool?> IsUserInputRequired { get; } = new(
            name: "isUserInputRequired")
        {
            Description = @"A Boolean value that determines whether users must enter information to redeem the reward. Set to **true** if user input is required. See the `prompt` field.",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerStreamEnabled { get; } = new(
            name: "isMaxPerStreamEnabled")
        {
            Description = @"A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the `max_per_stream` field). Set to **true** to limit redemptions.",
        };

        private global::System.CommandLine.Option<long?> MaxPerStream { get; } = new(
            name: "maxPerStream")
        {
            Description = @"The maximum number of redemptions allowed per live stream. Applied only if `is_max_per_stream_enabled` is **true**. The minimum value is 1.",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerUserPerStreamEnabled { get; } = new(
            name: "isMaxPerUserPerStreamEnabled")
        {
            Description = @"A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see `max_per_user_per_stream`). The minimum value is 1\. Set to **true** to limit redemptions.",
        };

        private global::System.CommandLine.Option<long?> MaxPerUserPerStream { get; } = new(
            name: "maxPerUserPerStream")
        {
            Description = @"The maximum number of redemptions allowed per user per stream. Applied only if `is_max_per_user_per_stream_enabled` is **true**.",
        };

        private global::System.CommandLine.Option<bool?> IsGlobalCooldownEnabled { get; } = new(
            name: "isGlobalCooldownEnabled")
        {
            Description = @"A Boolean value that determines whether to apply a cooldown period between redemptions. Set to **true** to apply a cooldown period. For the duration of the cooldown period, see `global_cooldown_seconds`.",
        };

        private global::System.CommandLine.Option<long?> GlobalCooldownSeconds { get; } = new(
            name: "globalCooldownSeconds")
        {
            Description = @"The cooldown period, in seconds. Applied only if `is_global_cooldown_enabled` is **true**. The minimum value is 1; however, for it to be shown in the Twitch UX, the minimum value is 60.",
        };

        private global::System.CommandLine.Option<bool?> IsPaused { get; } = new(
            name: "isPaused")
        {
            Description = @"A Boolean value that determines whether to pause the reward. Set to **true** to pause the reward. Viewers can’t redeem paused rewards..",
        };

        private global::System.CommandLine.Option<bool?> ShouldRedemptionsSkipRequestQueue { get; } = new(
            name: "shouldRedemptionsSkipRequestQueue")
        {
            Description = @"A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If **false**, status is set to UNFULFILLED and follows the normal request queue process.",
        };
        public UpdateCustomRewardCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Updates a custom reward. The app used to create the reward is the only app that may update the reward.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/api/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.

__Request Body:__

The body of the request should contain only the fields you’re updating.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Arguments.Add(Id);
            Options.Add(Title);
            Options.Add(Prompt);
            Options.Add(Cost);
            Options.Add(BackgroundColor);
            Options.Add(IsEnabled);
            Options.Add(IsUserInputRequired);
            Options.Add(IsMaxPerStreamEnabled);
            Options.Add(MaxPerStream);
            Options.Add(IsMaxPerUserPerStreamEnabled);
            Options.Add(MaxPerUserPerStream);
            Options.Add(IsGlobalCooldownEnabled);
            Options.Add(GlobalCooldownSeconds);
            Options.Add(IsPaused);
            Options.Add(ShouldRedemptionsSkipRequestQueue);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var id = parseResult.GetRequiredValue(Id);
            var title = parseResult.GetRequiredValue(Title);
            var prompt = parseResult.GetRequiredValue(Prompt);
            var cost = parseResult.GetRequiredValue(Cost);
            var backgroundColor = parseResult.GetRequiredValue(BackgroundColor);
            var isEnabled = parseResult.GetRequiredValue(IsEnabled);
            var isUserInputRequired = parseResult.GetRequiredValue(IsUserInputRequired);
            var isMaxPerStreamEnabled = parseResult.GetRequiredValue(IsMaxPerStreamEnabled);
            var maxPerStream = parseResult.GetRequiredValue(MaxPerStream);
            var isMaxPerUserPerStreamEnabled = parseResult.GetRequiredValue(IsMaxPerUserPerStreamEnabled);
            var maxPerUserPerStream = parseResult.GetRequiredValue(MaxPerUserPerStream);
            var isGlobalCooldownEnabled = parseResult.GetRequiredValue(IsGlobalCooldownEnabled);
            var globalCooldownSeconds = parseResult.GetRequiredValue(GlobalCooldownSeconds);
            var isPaused = parseResult.GetRequiredValue(IsPaused);
            var shouldRedemptionsSkipRequestQueue = parseResult.GetRequiredValue(ShouldRedemptionsSkipRequestQueue);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                id: id,
                title: title,
                prompt: prompt,
                cost: cost,
                backgroundColor: backgroundColor,
                isEnabled: isEnabled,
                isUserInputRequired: isUserInputRequired,
                isMaxPerStreamEnabled: isMaxPerStreamEnabled,
                maxPerStream: maxPerStream,
                isMaxPerUserPerStreamEnabled: isMaxPerUserPerStreamEnabled,
                maxPerUserPerStream: maxPerUserPerStream,
                isGlobalCooldownEnabled: isGlobalCooldownEnabled,
                globalCooldownSeconds: globalCooldownSeconds,
                isPaused: isPaused,
                shouldRedemptionsSkipRequestQueue: shouldRedemptionsSkipRequestQueue,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ChannelPoints.UpdateCustomRewardAsync(
                broadcasterId: broadcasterId,
                id: id,
                title: title,
                prompt: prompt,
                cost: cost,
                backgroundColor: backgroundColor,
                isEnabled: isEnabled,
                isUserInputRequired: isUserInputRequired,
                isMaxPerStreamEnabled: isMaxPerStreamEnabled,
                maxPerStream: maxPerStream,
                isMaxPerUserPerStreamEnabled: isMaxPerUserPerStreamEnabled,
                maxPerUserPerStream: maxPerUserPerStream,
                isGlobalCooldownEnabled: isGlobalCooldownEnabled,
                globalCooldownSeconds: globalCooldownSeconds,
                isPaused: isPaused,
                shouldRedemptionsSkipRequestQueue: shouldRedemptionsSkipRequestQueue,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}