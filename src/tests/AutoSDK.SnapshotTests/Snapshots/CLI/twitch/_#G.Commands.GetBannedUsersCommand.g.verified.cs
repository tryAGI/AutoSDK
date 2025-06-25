//HintName: G.Commands.GetBannedUsersCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetBannedUsersCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            global::System.Collections.Generic.IList<string>? userId,
            int? first,
            string? after,
            string? before,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetBannedUsersResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> UserId { get; } = new(
            name: "userId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> First { get; } = new(
            name: "first")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };
        public GetBannedUsersCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets all users that the broadcaster banned or put in a timeout.

__Authorization:__

Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **moderation:read** or **moderator:manage:banned\_users** scope.")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Options.Add(UserId);
            Options.Add(First);
            Options.Add(After);
            Options.Add(Before);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var userId = parseResult.GetRequiredValue(UserId);
            var first = parseResult.GetRequiredValue(First);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.GetBannedUsersAsync(
                broadcasterId: broadcasterId,
                userId: userId,
                first: first,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}