//HintName: G.Commands.ReposListDeploymentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposListDeploymentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? sha,
            string? @ref,
            string? task,
            string? environment,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Deployment> response,
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

        private global::System.CommandLine.Option<string?> Sha { get; } = new(
            name: "sha")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Task { get; } = new(
            name: "task")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Environment { get; } = new(
            name: "environment")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };
        public ReposListDeploymentsCommand(G.IApi client) : base(
            name: "repos",
            description: @"Simple filtering of deployments is available via query parameters:")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Sha);
            Options.Add(Ref);
            Options.Add(Task);
            Options.Add(Environment);
            Options.Add(PerPage);
            Options.Add(Page);

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
            var @ref = parseResult.GetRequiredValue(Ref);
            var task = parseResult.GetRequiredValue(Task);
            var environment = parseResult.GetRequiredValue(Environment);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                sha: sha,
                @ref: @ref,
                task: task,
                environment: environment,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposListDeploymentsAsync(
                owner: owner,
                repo: repo,
                sha: sha,
                @ref: @ref,
                task: task,
                environment: environment,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}