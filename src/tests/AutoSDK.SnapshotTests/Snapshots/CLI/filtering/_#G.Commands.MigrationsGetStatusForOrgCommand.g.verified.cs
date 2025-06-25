//HintName: G.Commands.MigrationsGetStatusForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsGetStatusForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int migrationId,
            global::System.Collections.Generic.IList<global::G.MigrationsGetStatusForOrgExcludeItem>? exclude,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Migration response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<int> MigrationId { get; } = new(
            name: "migrationId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.MigrationsGetStatusForOrgExcludeItem>?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = @"",
        };
        public MigrationsGetStatusForOrgCommand(G.IApi client) : base(
            name: "migrations",
            description: @"Fetches the status of a migration.

The `state` of a migration can be one of the following values:

*   `pending`, which means the migration hasn't started yet.
*   `exporting`, which means the migration is in progress.
*   `exported`, which means the migration finished successfully.
*   `failed`, which means the migration failed.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(MigrationId);
            Options.Add(Exclude);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var migrationId = parseResult.GetRequiredValue(MigrationId);
            var exclude = parseResult.GetRequiredValue(Exclude);

            Validate(
                parseResult: parseResult,
                org: org,
                migrationId: migrationId,
                exclude: exclude,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsGetStatusForOrgAsync(
                org: org,
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