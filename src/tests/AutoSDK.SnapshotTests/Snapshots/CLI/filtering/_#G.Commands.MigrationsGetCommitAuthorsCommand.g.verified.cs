//HintName: G.Commands.MigrationsGetCommitAuthorsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsGetCommitAuthorsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int? since,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.PorterAuthor> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"The account owner of the repository. The name is not case sensitive.",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = @"The name of the repository without the `.git` extension. The name is not case sensitive.",
        };

        private global::System.CommandLine.Option<int?> Since { get; } = new(
            name: "since")
        {
            Description = @"A user ID. Only return users with an ID greater than this ID.",
        };
        public MigrationsGetCommitAuthorsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Each type of source control system represents authors in a different way. For example, a Git commit author has a display name and an email address, but a Subversion commit author just has a username. The GitHub Importer will make the author information valid, but the author might not be correct. For example, it will change the bare Subversion username `hubot` into something like `hubot <hubot@12341234-abab-fefe-8787-fedcba987654>`.

This endpoint and the [Map a commit author](https://docs.github.com/rest/migrations/source-imports#map-a-commit-author) endpoint allow you to provide correct Git author information.

> [!WARNING]
> **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Since);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var since = parseResult.GetRequiredValue(Since);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                since: since,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsGetCommitAuthorsAsync(
                owner: owner,
                repo: repo,
                since: since,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}