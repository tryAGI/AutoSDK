//HintName: G.Commands.MigrationsUnlockRepoForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsUnlockRepoForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int migrationId,
            string repoName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> MigrationId { get; } = new(
            name: "migrationId")
        {
            Description = @"The unique identifier of the migration.",
        };

        private global::System.CommandLine.Argument<string> RepoName { get; } = new(
            name: "repoName")
        {
            Description = @"repo_name parameter",
        };

        public MigrationsUnlockRepoForAuthenticatedUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Unlocks a repository. You can lock repositories when you [start a user migration](https://docs.github.com/rest/migrations/users#start-a-user-migration). Once the migration is complete you can unlock each repository to begin using it again or [delete the repository](https://docs.github.com/rest/repos/repos#delete-a-repository) if you no longer need the source data. Returns a status of `404 Not Found` if the repository is not locked.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(MigrationId);
            Arguments.Add(RepoName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var migrationId = parseResult.GetRequiredValue(MigrationId);
            var repoName = parseResult.GetRequiredValue(RepoName);

            Validate(
                parseResult: parseResult,
                migrationId: migrationId,
                repoName: repoName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Migrations.MigrationsUnlockRepoForAuthenticatedUserAsync(
                migrationId: migrationId,
                repoName: repoName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}