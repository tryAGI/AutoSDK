//HintName: G.Commands.MigrationsListReposForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsListReposForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int migrationId,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.MinimalRepository> response,
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

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = @"The number of results per page (max 100). For more information, see ""[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).""",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = @"The page number of the results to fetch. For more information, see ""[Using pagination in the REST API](https://docs.github.com/rest/using-the-rest-api/using-pagination-in-the-rest-api).""",
        };
        public MigrationsListReposForOrgCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"List all the repositories for this organization migration.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Org);
            Arguments.Add(MigrationId);
            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var migrationId = parseResult.GetRequiredValue(MigrationId);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                org: org,
                migrationId: migrationId,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsListReposForOrgAsync(
                org: org,
                migrationId: migrationId,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}