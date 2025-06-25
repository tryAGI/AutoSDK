//HintName: G.Commands.IssuesUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class IssuesUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int issueNumber,
            global::G.OneOf<string, int?>? title,
            string? body,
            string? assignee,
            global::G.IssuesUpdateRequestState? state,
            global::G.IssuesUpdateRequestStateReason? stateReason,
            global::G.OneOf<string, int?>? milestone,
            global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.IssuesUpdateRequestLabel>>? labels,
            global::System.Collections.Generic.IList<string>? assignees,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Issue response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> IssueNumber { get; } = new(
            name: "issueNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, int?>?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Body { get; } = new(
            name: "body")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Assignee { get; } = new(
            name: "assignee")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesUpdateRequestState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.IssuesUpdateRequestStateReason?> StateReason { get; } = new(
            name: "stateReason")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<string, int?>?> Milestone { get; } = new(
            name: "milestone")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.OneOf<string, global::G.IssuesUpdateRequestLabel>>?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Assignees { get; } = new(
            name: "assignees")
        {
            Description = "",
        };
        public IssuesUpdateCommand(G.IApi client) : base(
            name: "issues",
            description: @"Issue owners and users with push access or Triage role can edit an issue.

This endpoint supports the following custom media types. For more information, see ""[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types).""

- **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.
- **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.
- **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.
- **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(IssueNumber);
            Options.Add(Title);
            Options.Add(Body);
            Options.Add(Assignee);
            Options.Add(State);
            Options.Add(StateReason);
            Options.Add(Milestone);
            Options.Add(Labels);
            Options.Add(Assignees);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var issueNumber = parseResult.GetRequiredValue(IssueNumber);
            var title = parseResult.GetRequiredValue(Title);
            var body = parseResult.GetRequiredValue(Body);
            var assignee = parseResult.GetRequiredValue(Assignee);
            var state = parseResult.GetRequiredValue(State);
            var stateReason = parseResult.GetRequiredValue(StateReason);
            var milestone = parseResult.GetRequiredValue(Milestone);
            var labels = parseResult.GetRequiredValue(Labels);
            var assignees = parseResult.GetRequiredValue(Assignees);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                title: title,
                body: body,
                assignee: assignee,
                state: state,
                stateReason: stateReason,
                milestone: milestone,
                labels: labels,
                assignees: assignees,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Issues.IssuesUpdateAsync(
                owner: owner,
                repo: repo,
                issueNumber: issueNumber,
                title: title,
                body: body,
                assignee: assignee,
                state: state,
                stateReason: stateReason,
                milestone: milestone,
                labels: labels,
                assignees: assignees,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}