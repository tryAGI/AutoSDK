//HintName: G.Commands.ModifyChannelInformationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModifyChannelInformationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string? gameId,
            string? broadcasterLanguage,
            string? title,
            int? delay,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>? contentClassificationLabels,
            bool? isBrandedContent,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = @"The ID of the broadcaster whose channel you want to update. This ID must match the user ID in the user access token.",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"The ID of the game that the user plays. The game is not updated if the ID isn’t a game ID that Twitch recognizes. To unset this field, use “0” or “” (an empty string).",
        };

        private global::System.CommandLine.Option<string?> BroadcasterLanguage { get; } = new(
            name: "broadcasterLanguage")
        {
            Description = @"The user’s preferred language. Set the value to an ISO 639-1 two-letter language code (for example, _en_ for English). Set to “other” if the user’s preferred language is not a Twitch supported language. The language isn’t updated if the language code isn’t a Twitch supported language.",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"The title of the user’s stream. You may not set this field to an empty string.",
        };

        private global::System.CommandLine.Option<int?> Delay { get; } = new(
            name: "delay")
        {
            Description = @"The number of seconds you want your broadcast buffered before streaming it live. The delay helps ensure fairness during competitive play. Only users with Partner status may set this field. The maximum delay is 900 seconds (15 minutes).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"A list of channel-defined tags to apply to the channel. To remove all tags from the channel, set tags to an empty array. Tags help identify the content that the channel streams. [Learn More](https://help.twitch.tv/s/article/guide-to-tags)  
A channel may specify a maximum of 10 tags. Each tag is limited to a maximum of 25 characters and may not be an empty string or contain spaces or special characters. Tags are case insensitive. For readability, consider using camelCasing or PascalCasing.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>?> ContentClassificationLabels { get; } = new(
            name: "contentClassificationLabels")
        {
            Description = @"List of labels that should be set as the Channel’s CCLs.",
        };

        private global::System.CommandLine.Option<bool?> IsBrandedContent { get; } = new(
            name: "isBrandedContent")
        {
            Description = @"Boolean flag indicating if the channel has branded content.",
        };
        public ModifyChannelInformationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "modify",
            description: @"Updates a channel’s properties.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.

__Request Body:__

All fields are optional, but you must specify at least one field.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(BroadcasterId);
            Options.Add(GameId);
            Options.Add(BroadcasterLanguage);
            Options.Add(Title);
            Options.Add(Delay);
            Options.Add(Tags);
            Options.Add(ContentClassificationLabels);
            Options.Add(IsBrandedContent);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var gameId = parseResult.GetRequiredValue(GameId);
            var broadcasterLanguage = parseResult.GetRequiredValue(BroadcasterLanguage);
            var title = parseResult.GetRequiredValue(Title);
            var delay = parseResult.GetRequiredValue(Delay);
            var tags = parseResult.GetRequiredValue(Tags);
            var contentClassificationLabels = parseResult.GetRequiredValue(ContentClassificationLabels);
            var isBrandedContent = parseResult.GetRequiredValue(IsBrandedContent);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                gameId: gameId,
                broadcasterLanguage: broadcasterLanguage,
                title: title,
                delay: delay,
                tags: tags,
                contentClassificationLabels: contentClassificationLabels,
                isBrandedContent: isBrandedContent,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Channels.ModifyChannelInformationAsync(
                broadcasterId: broadcasterId,
                gameId: gameId,
                broadcasterLanguage: broadcasterLanguage,
                title: title,
                delay: delay,
                tags: tags,
                contentClassificationLabels: contentClassificationLabels,
                isBrandedContent: isBrandedContent,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}