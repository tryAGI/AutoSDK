//HintName: G.Commands.ActionsGetActionsCacheListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsGetActionsCacheListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int? perPage,
            int? page,
            string? @ref,
            string? key,
            global::G.ActionsGetActionsCacheListSort? sort,
            global::G.ActionsGetActionsCacheListDirection? direction,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsCacheList response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
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

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Key { get; } = new(
            name: "key")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ActionsGetActionsCacheListSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ActionsGetActionsCacheListDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };
        public ActionsGetActionsCacheListCommand(G.IApi client) : base(
            name: "actions",
            description: @"Lists the GitHub Actions caches for a repository.

OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Ref);
            Options.Add(Key);
            Options.Add(Sort);
            Options.Add(Direction);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var @ref = parseResult.GetRequiredValue(Ref);
            var key = parseResult.GetRequiredValue(Key);
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                @ref: @ref,
                key: key,
                sort: sort,
                direction: direction,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsGetActionsCacheListAsync(
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                @ref: @ref,
                key: key,
                sort: sort,
                direction: direction,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}