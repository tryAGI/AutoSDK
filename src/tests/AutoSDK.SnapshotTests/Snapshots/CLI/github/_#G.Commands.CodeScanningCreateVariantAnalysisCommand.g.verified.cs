//HintName: G.Commands.CodeScanningCreateVariantAnalysisCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodeScanningCreateVariantAnalysisCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.CodeScanningVariantAnalysisLanguage language,
            string queryPack,
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<string>? repositoryLists,
            global::System.Collections.Generic.IList<string>? repositoryOwners,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeScanningVariantAnalysis response,
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

        private global::System.CommandLine.Argument<global::G.CodeScanningVariantAnalysisLanguage> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> QueryPack { get; } = new(
            name: "queryPack")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Repositories { get; } = new(
            name: "repositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RepositoryLists { get; } = new(
            name: "repositoryLists")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> RepositoryOwners { get; } = new(
            name: "repositoryOwners")
        {
            Description = "",
        };
        public CodeScanningCreateVariantAnalysisCommand(G.IApi client) : base(
            name: "code",
            description: @"Creates a new CodeQL variant analysis, which will run a CodeQL query against one or more repositories.

Get started by learning more about [running CodeQL queries at scale with Multi-Repository Variant Analysis](https://docs.github.com/code-security/codeql-for-vs-code/getting-started-with-codeql-for-vs-code/running-codeql-queries-at-scale-with-multi-repository-variant-analysis).

Use the `owner` and `repo` parameters in the URL to specify the controller repository that
will be used for running GitHub Actions workflows and storing the results of the CodeQL variant analysis.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Language);
            Arguments.Add(QueryPack);
            Options.Add(Repositories);
            Options.Add(RepositoryLists);
            Options.Add(RepositoryOwners);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var language = parseResult.GetRequiredValue(Language);
            var queryPack = parseResult.GetRequiredValue(QueryPack);
            var repositories = parseResult.GetRequiredValue(Repositories);
            var repositoryLists = parseResult.GetRequiredValue(RepositoryLists);
            var repositoryOwners = parseResult.GetRequiredValue(RepositoryOwners);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                language: language,
                queryPack: queryPack,
                repositories: repositories,
                repositoryLists: repositoryLists,
                repositoryOwners: repositoryOwners,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodeScanning.CodeScanningCreateVariantAnalysisAsync(
                owner: owner,
                repo: repo,
                language: language,
                queryPack: queryPack,
                repositories: repositories,
                repositoryLists: repositoryLists,
                repositoryOwners: repositoryOwners,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}