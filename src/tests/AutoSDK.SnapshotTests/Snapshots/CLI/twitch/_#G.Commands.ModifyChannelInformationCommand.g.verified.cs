//HintName: G.Commands.ModifyChannelInformationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModifyChannelInformationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

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
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> GameId { get; } = new(
            name: "gameId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> BroadcasterLanguage { get; } = new(
            name: "broadcasterLanguage")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Delay { get; } = new(
            name: "delay")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ModifyChannelInformationBodyContentClassificationLabel>?> ContentClassificationLabels { get; } = new(
            name: "contentClassificationLabels")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<bool?> IsBrandedContent { get; } = new(
            name: "isBrandedContent")
        {
            Description = @"",
        };
        public ModifyChannelInformationCommand(G.IApi client) : base(
            name: "modify",
            description: @"Updates a channel’s properties.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **channel:manage:broadcast** scope.

__Request Body:__

All fields are optional, but you must specify at least one field.")
        {
            _client = client;

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