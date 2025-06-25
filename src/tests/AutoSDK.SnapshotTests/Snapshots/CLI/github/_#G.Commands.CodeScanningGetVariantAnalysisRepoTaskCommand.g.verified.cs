//HintName: G.Commands.CodeScanningGetVariantAnalysisRepoTaskCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningGetVariantAnalysisRepoTaskCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int codeqlVariantAnalysisId,
            string repoOwner,
            string repoName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeScanningVariantAnalysisRepoTask response,
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

        private global::System.CommandLine.Argument<int> CodeqlVariantAnalysisId { get; } = new(
            name: "codeqlVariantAnalysisId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> RepoOwner { get; } = new(
            name: "repoOwner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> RepoName { get; } = new(
            name: "repoName")
        {
            Description = "",
        };

        public CodeScanningGetVariantAnalysisRepoTaskCommand(G.IApi client) : base(
            name: "code",
            description: @"Gets the analysis status of a repository in a CodeQL variant analysis.

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(CodeqlVariantAnalysisId);
            Arguments.Add(RepoOwner);
            Arguments.Add(RepoName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var codeqlVariantAnalysisId = parseResult.GetRequiredValue(CodeqlVariantAnalysisId);
            var repoOwner = parseResult.GetRequiredValue(RepoOwner);
            var repoName = parseResult.GetRequiredValue(RepoName);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                codeqlVariantAnalysisId: codeqlVariantAnalysisId,
                repoOwner: repoOwner,
                repoName: repoName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningGetVariantAnalysisRepoTaskAsync(
                owner: owner,
                repo: repo,
                codeqlVariantAnalysisId: codeqlVariantAnalysisId,
                repoOwner: repoOwner,
                repoName: repoName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}