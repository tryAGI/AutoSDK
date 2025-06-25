//HintName: G.Commands.MigrationsGetStatusForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsGetStatusForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int migrationId,
            global::System.Collections.Generic.IList<string>? exclude,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Migration response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> MigrationId { get; } = new(
            name: "migrationId")
        {
            Description = @"The unique identifier of the migration.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = @"",
        };
        public MigrationsGetStatusForAuthenticatedUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Fetches a single user migration. The response includes the `state` of the migration, which can be one of the following values:

*   `pending` - the migration hasn't started yet.
*   `exporting` - the migration is in progress.
*   `exported` - the migration finished successfully.
*   `failed` - the migration failed.

Once the migration has been `exported` you can [download the migration archive](https://docs.github.com/rest/migrations/users#download-a-user-migration-archive).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(MigrationId);
            Options.Add(Exclude);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var migrationId = parseResult.GetRequiredValue(MigrationId);
            var exclude = parseResult.GetRequiredValue(Exclude);

            Validate(
                parseResult: parseResult,
                migrationId: migrationId,
                exclude: exclude,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsGetStatusForAuthenticatedUserAsync(
                migrationId: migrationId,
                exclude: exclude,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}