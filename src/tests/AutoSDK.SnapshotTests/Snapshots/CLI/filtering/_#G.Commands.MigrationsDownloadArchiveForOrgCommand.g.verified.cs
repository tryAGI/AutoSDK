//HintName: G.Commands.MigrationsDownloadArchiveForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsDownloadArchiveForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int migrationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        public MigrationsDownloadArchiveForOrgCommand(G.IApi client) : base(
            name: "migrations",
            description: @"Fetches the URL to a migration archive.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(MigrationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var migrationId = parseResult.GetRequiredValue(MigrationId);

            Validate(
                parseResult: parseResult,
                org: org,
                migrationId: migrationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Migrations.MigrationsDownloadArchiveForOrgAsync(
                org: org,
                migrationId: migrationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}