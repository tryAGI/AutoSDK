//HintName: G.Commands.UpdateCustomRewardCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateCustomRewardCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Prompt { get; } = new(
            name: "prompt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> Cost { get; } = new(
            name: "cost")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> BackgroundColor { get; } = new(
            name: "backgroundColor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsEnabled { get; } = new(
            name: "isEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsUserInputRequired { get; } = new(
            name: "isUserInputRequired")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerStreamEnabled { get; } = new(
            name: "isMaxPerStreamEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> MaxPerStream { get; } = new(
            name: "maxPerStream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsMaxPerUserPerStreamEnabled { get; } = new(
            name: "isMaxPerUserPerStreamEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> MaxPerUserPerStream { get; } = new(
            name: "maxPerUserPerStream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsGlobalCooldownEnabled { get; } = new(
            name: "isGlobalCooldownEnabled")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> GlobalCooldownSeconds { get; } = new(
            name: "globalCooldownSeconds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsPaused { get; } = new(
            name: "isPaused")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ShouldRedemptionsSkipRequestQueue { get; } = new(
            name: "shouldRedemptionsSkipRequestQueue")
        {
            Description = "",
        };
        public UpdateCustomRewardCommand(G.IApi client) : base(
            name: "update",
            description: @"Updates a custom reward. The app used to create the reward is the only app that may update the reward.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/api/authentication#user-access-tokens) that includes the **channel:manage:redemptions** scope.

__Request Body:__

The body of the request should contain only the fields you’re updating.")
        {
            _client = client;

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