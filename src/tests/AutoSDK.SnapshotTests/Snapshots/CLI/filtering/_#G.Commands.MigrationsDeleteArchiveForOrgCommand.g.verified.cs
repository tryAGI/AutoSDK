//HintName: G.Commands.MigrationsDeleteArchiveForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsDeleteArchiveForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The organization name. The name is not case sensitive.",
        };

        private global::System.CommandLine.Argument<int> MigrationId { get; } = new(
            name: "migrationId")
        {
            Description = @"The unique identifier of the migration.",
        };

        public MigrationsDeleteArchiveForOrgCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Deletes a previous migration archive. Migration archives are automatically deleted after seven days.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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
            await _client.Migrations.MigrationsDeleteArchiveForOrgAsync(
                org: org,
                migrationId: migrationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}