//HintName: G.Commands.MigrationsListForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsListForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Migration> response,
            global::System.Threading.CancellationToken cancellationToken);


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
        public MigrationsListForAuthenticatedUserCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Lists all migrations a user has started.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(PerPage);
            Options.Add(Page);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);

            Validate(
                parseResult: parseResult,
                perPage: perPage,
                page: page,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsListForAuthenticatedUserAsync(
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