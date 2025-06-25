//HintName: G.Commands.ReposCreateCommitStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateCommitStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string sha,
            global::G.ReposCreateCommitStatusRequestState state,
            string? targetUrl,
            string? description,
            string? context,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Status response,
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

        private global::System.CommandLine.Argument<string> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ReposCreateCommitStatusRequestState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TargetUrl { get; } = new(
            name: "targetUrl")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Context { get; } = new(
            name: "context")
        {
            Description = "",
        };
        public ReposCreateCommitStatusCommand(G.IApi client) : base(
            name: "repos",
            description: @"Users with push access in a repository can create commit statuses for a given SHA.

Note: there is a limit of 1000 statuses per `sha` and `context` within a repository. Attempts to create more than 1000 statuses will result in a validation error.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Sha);
            Arguments.Add(State);
            Options.Add(TargetUrl);
            Options.Add(Description);
            Options.Add(Context);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var sha = parseResult.GetRequiredValue(Sha);
            var state = parseResult.GetRequiredValue(State);
            var targetUrl = parseResult.GetRequiredValue(TargetUrl);
            var description = parseResult.GetRequiredValue(Description);
            var context = parseResult.GetRequiredValue(Context);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                sha: sha,
                state: state,
                targetUrl: targetUrl,
                description: description,
                context: context,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateCommitStatusAsync(
                owner: owner,
                repo: repo,
                sha: sha,
                state: state,
                targetUrl: targetUrl,
                description: description,
                context: context,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}