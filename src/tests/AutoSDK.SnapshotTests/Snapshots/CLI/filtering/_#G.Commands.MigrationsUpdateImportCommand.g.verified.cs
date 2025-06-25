//HintName: G.Commands.MigrationsUpdateImportCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsUpdateImportCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? vcsUsername,
            string? vcsPassword,
            global::G.MigrationsUpdateImportRequestVcs? vcs,
            string? tfvcProject,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Import response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> VcsUsername { get; } = new(
            name: "vcsUsername")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> VcsPassword { get; } = new(
            name: "vcsPassword")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.MigrationsUpdateImportRequestVcs?> Vcs { get; } = new(
            name: "vcs")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> TfvcProject { get; } = new(
            name: "tfvcProject")
        {
            Description = @"",
        };
        public MigrationsUpdateImportCommand(G.IApi client) : base(
            name: "migrations",
            description: @"An import can be updated with credentials or a project choice by passing in the appropriate parameters in this API
request. If no parameters are provided, the import will be restarted.

Some servers (e.g. TFS servers) can have several projects at a single URL. In those cases the import progress will
have the status `detection_found_multiple` and the Import Progress response will include a `project_choices` array.
You can select the project to import by providing one of the objects in the `project_choices` array in the update request.

> [!WARNING]
> **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(VcsUsername);
            Options.Add(VcsPassword);
            Options.Add(Vcs);
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
            var vcsUsername = parseResult.GetRequiredValue(VcsUsername);
            var vcsPassword = parseResult.GetRequiredValue(VcsPassword);
            var vcs = parseResult.GetRequiredValue(Vcs);
            var tfvcProject = parseResult.GetRequiredValue(TfvcProject);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                vcsUsername: vcsUsername,
                vcsPassword: vcsPassword,
                vcs: vcs,
                tfvcProject: tfvcProject,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsUpdateImportAsync(
                owner: owner,
                repo: repo,
                vcsUsername: vcsUsername,
                vcsPassword: vcsPassword,
                vcs: vcs,
                tfvcProject: tfvcProject,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}