//HintName: G.Commands.ReposGetPagesDeploymentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetPagesDeploymentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.OneOf<int?, string> pagesDeploymentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PagesDeploymentStatus response,
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

        private global::System.CommandLine.Argument<global::G.OneOf<int?, string>> PagesDeploymentId { get; } = new(
            name: "pagesDeploymentId")
        {
            Description = "",
        };

        public ReposGetPagesDeploymentCommand(G.IApi client) : base(
            name: "repos",
            description: @"Gets the current status of a GitHub Pages deployment.

The authenticated user must have read permission for the GitHub Pages site.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(PagesDeploymentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var pagesDeploymentId = parseResult.GetRequiredValue(PagesDeploymentId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                pagesDeploymentId: pagesDeploymentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetPagesDeploymentAsync(
                owner: owner,
                repo: repo,
                pagesDeploymentId: pagesDeploymentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}