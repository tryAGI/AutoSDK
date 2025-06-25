//HintName: G.Commands.ReposListForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposListForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ReposListForAuthenticatedUserVisibility? visibility,
            string? affiliation,
            global::G.ReposListForAuthenticatedUserType? type,
            global::G.ReposListForAuthenticatedUserSort? sort,
            global::G.ReposListForAuthenticatedUserDirection? direction,
            int? perPage,
            int? page,
            global::System.DateTime? since,
            global::System.DateTime? before,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Repository> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.ReposListForAuthenticatedUserVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Affiliation { get; } = new(
            name: "affiliation")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposListForAuthenticatedUserType?> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposListForAuthenticatedUserSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposListForAuthenticatedUserDirection?> Direction { get; } = new(
            name: "direction")
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

        private global::System.CommandLine.Option<global::System.DateTime?> Since { get; } = new(
            name: "since")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };
        public ReposListForAuthenticatedUserCommand(G.IApi client) : base(
            name: "repos",
            description: @"Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.

The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.")
        {
            _client = client;

            Options.Add(Visibility);
            Options.Add(Affiliation);
            Options.Add(Type);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Since);
            Options.Add(Before);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var visibility = parseResult.GetRequiredValue(Visibility);
            var affiliation = parseResult.GetRequiredValue(Affiliation);
            var type = parseResult.GetRequiredValue(Type);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var since = parseResult.GetRequiredValue(Since);
            var before = parseResult.GetRequiredValue(Before);

            Validate(
                parseResult: parseResult,
                visibility: visibility,
                affiliation: affiliation,
                type: type,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page,
                since: since,
                before: before,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposListForAuthenticatedUserAsync(
                visibility: visibility,
                affiliation: affiliation,
                type: type,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page,
                since: since,
                before: before,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}