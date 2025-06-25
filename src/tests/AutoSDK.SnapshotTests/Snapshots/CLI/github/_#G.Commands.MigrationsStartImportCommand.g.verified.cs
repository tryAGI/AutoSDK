//HintName: G.Commands.MigrationsStartImportCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsStartImportCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string vcsUrl,
            global::G.MigrationsStartImportRequestVcs? vcs,
            string? vcsUsername,
            string? vcsPassword,
            string? tfvcProject,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Import response,
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

        private global::System.CommandLine.Argument<string> VcsUrl { get; } = new(
            name: "vcsUrl")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.MigrationsStartImportRequestVcs?> Vcs { get; } = new(
            name: "vcs")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VcsUsername { get; } = new(
            name: "vcsUsername")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VcsPassword { get; } = new(
            name: "vcsPassword")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TfvcProject { get; } = new(
            name: "tfvcProject")
        {
            Description = "",
        };
        public MigrationsStartImportCommand(G.IApi client) : base(
            name: "migrations",
            description: @"Start a source import to a GitHub repository using GitHub Importer.
Importing into a GitHub repository with GitHub Actions enabled is not supported and will
return a status `422 Unprocessable Entity` response.

> [!WARNING]
> **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(VcsUrl);
            Options.Add(Vcs);
            Options.Add(VcsUsername);
            Options.Add(VcsPassword);
            Options.Add(TfvcProject);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var vcsUrl = parseResult.GetRequiredValue(VcsUrl);
            var vcs = parseResult.GetRequiredValue(Vcs);
            var vcsUsername = parseResult.GetRequiredValue(VcsUsername);
            var vcsPassword = parseResult.GetRequiredValue(VcsPassword);
            var tfvcProject = parseResult.GetRequiredValue(TfvcProject);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                vcsUrl: vcsUrl,
                vcs: vcs,
                vcsUsername: vcsUsername,
                vcsPassword: vcsPassword,
                tfvcProject: tfvcProject,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsStartImportAsync(
                owner: owner,
                repo: repo,
                vcsUrl: vcsUrl,
                vcs: vcs,
                vcsUsername: vcsUsername,
                vcsPassword: vcsPassword,
                tfvcProject: tfvcProject,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}