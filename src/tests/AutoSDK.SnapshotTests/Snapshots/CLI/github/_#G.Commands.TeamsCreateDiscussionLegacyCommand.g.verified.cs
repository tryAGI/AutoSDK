//HintName: G.Commands.TeamsCreateDiscussionLegacyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsCreateDiscussionLegacyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int teamId,
            string title,
            string body,
            bool? @private,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TeamDiscussion response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Private { get; } = new(
            name: "@private")
        {
            Description = "",
        };
        public TeamsCreateDiscussionLegacyCommand(G.IApi client) : base(
            name: "teams",
            description: @"> [!WARNING]
> **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [`Create a discussion`](https://docs.github.com/rest/teams/discussions#create-a-discussion) endpoint.

Creates a new discussion post on a team's page.

This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see ""[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)"" and ""[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api).""

OAuth app tokens and personal access tokens (classic) need the `write:discussion` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(TeamId);
            Arguments.Add(Title);
            Arguments.Add(Body);
            Options.Add(Private);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var teamId = parseResult.GetRequiredValue(TeamId);
            var title = parseResult.GetRequiredValue(Title);
            var body = parseResult.GetRequiredValue(Body);
            var @private = parseResult.GetRequiredValue(Private);

            Validate(
                parseResult: parseResult,
                teamId: teamId,
                title: title,
                body: body,
                @private: @private,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Teams.TeamsCreateDiscussionLegacyAsync(
                teamId: teamId,
                title: title,
                body: body,
                @private: @private,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}