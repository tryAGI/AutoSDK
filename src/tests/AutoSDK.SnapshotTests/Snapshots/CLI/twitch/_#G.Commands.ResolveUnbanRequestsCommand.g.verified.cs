//HintName: G.Commands.ResolveUnbanRequestsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ResolveUnbanRequestsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string broadcasterId,
            string moderatorId,
            string unbanRequestId,
            string status,
            string? resolutionText,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ResolveUnbanRequestsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> BroadcasterId { get; } = new(
            name: "broadcasterId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> ModeratorId { get; } = new(
            name: "moderatorId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> UnbanRequestId { get; } = new(
            name: "unbanRequestId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Status { get; } = new(
            name: "status")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ResolutionText { get; } = new(
            name: "resolutionText")
        {
            Description = "",
        };
        public ResolveUnbanRequestsCommand(G.IApi client) : base(
            name: "resolve",
            description: @"NEW Resolves an unban request by approving or denying it.

__Authorization:__

* Requires a user access token that includes the **moderator:manage:unban\\\_requests** scope.
* Query parameter `moderator_id` must match the `user_id` in the[user access token](https://dev.twitch.tv/docs/authentication/#user-access-tokens).")
        {
            _client = client;

            Arguments.Add(BroadcasterId);
            Arguments.Add(ModeratorId);
            Arguments.Add(UnbanRequestId);
            Arguments.Add(Status);
            Options.Add(ResolutionText);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var broadcasterId = parseResult.GetRequiredValue(BroadcasterId);
            var moderatorId = parseResult.GetRequiredValue(ModeratorId);
            var unbanRequestId = parseResult.GetRequiredValue(UnbanRequestId);
            var status = parseResult.GetRequiredValue(Status);
            var resolutionText = parseResult.GetRequiredValue(ResolutionText);

            Validate(
                parseResult: parseResult,
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                unbanRequestId: unbanRequestId,
                status: status,
                resolutionText: resolutionText,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderation.ResolveUnbanRequestsAsync(
                broadcasterId: broadcasterId,
                moderatorId: moderatorId,
                unbanRequestId: unbanRequestId,
                status: status,
                resolutionText: resolutionText,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}