//HintName: G.Commands.MigrationsListForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsListForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? perPage,
            int? page,
            global::System.Collections.Generic.IList<global::G.MigrationsListForOrgExcludeItem>? exclude,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Migration> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = @"The organization name. The name is not case sensitive.",
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

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.MigrationsListForOrgExcludeItem>?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = @"Exclude attributes from the API response to improve performance",
        };
        public MigrationsListForOrgCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Lists the most recent migrations, including both exports (which can be started through the REST API) and imports (which cannot be started using the REST API).

A list of `repositories` is only returned for export migrations.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Org);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Exclude);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var exclude = parseResult.GetRequiredValue(Exclude);

            Validate(
                parseResult: parseResult,
                org: org,
                perPage: perPage,
                page: page,
                exclude: exclude,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsListForOrgAsync(
                org: org,
                perPage: perPage,
                page: page,
                exclude: exclude,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}