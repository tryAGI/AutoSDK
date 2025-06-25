//HintName: G.Commands.OrgsListCustomPropertiesValuesForReposCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsListCustomPropertiesValuesForReposCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? perPage,
            int? page,
            string? repositoryQuery,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.OrgRepoCustomPropertyValues> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> RepositoryQuery { get; } = new(
            name: "repositoryQuery")
        {
            Description = "",
        };
        public OrgsListCustomPropertiesValuesForReposCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Lists organization repositories with all of their custom property values.
Organization members can read these properties.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(RepositoryQuery);

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
            var repositoryQuery = parseResult.GetRequiredValue(RepositoryQuery);

            Validate(
                parseResult: parseResult,
                org: org,
                perPage: perPage,
                page: page,
                repositoryQuery: repositoryQuery,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsListCustomPropertiesValuesForReposAsync(
                org: org,
                perPage: perPage,
                page: page,
                repositoryQuery: repositoryQuery,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}