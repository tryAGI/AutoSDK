//HintName: G.Commands.CreateCustomRewardsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateCustomRewardsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<long> Cost { get; } = new(
            name: "cost")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsEnabled { get; } = new(
            name: "isEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> BackgroundColor { get; } = new(
            name: "backgroundColor")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsUserInputRequired { get; } = new(
            name: "isUserInputRequired")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerStreamEnabled { get; } = new(
            name: "isMaxPerStreamEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxPerStream { get; } = new(
            name: "maxPerStream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerUserPerStreamEnabled { get; } = new(
            name: "isMaxPerUserPerStreamEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> MaxPerUserPerStream { get; } = new(
            name: "maxPerUserPerStream")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsGlobalCooldownEnabled { get; } = new(
            name: "isGlobalCooldownEnabled")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> GlobalCooldownSeconds { get; } = new(
            name: "globalCooldownSeconds")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> ShouldRedemptionsSkipRequestQueue { get; } = new(
            name: "shouldRedemptionsSkipRequestQueue")
        {
            Description = @"",
        };
        public CreateCustomRewardsCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a Custom Reward in the broadcaster’s channel. The maximum number of custom rewards per channel is 50, which includes both enabled and disabled rewards.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.")
        {
            _client = client;

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