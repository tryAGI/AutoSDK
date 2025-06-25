//HintName: G.Commands.CodespacesListForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesListForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? perPage,
            int? page,
            int? repositoryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodespacesListForAuthenticatedUserResponse response,
            global::System.Threading.CancellationToken cancellationToken);


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

        private global::System.CommandLine.Option<int?> RepositoryId { get; } = new(
            name: "repositoryId")
        {
            Description = "",
        };
        public CodespacesListForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Lists the authenticated user's codespaces.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;

            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(RepositoryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var repositoryId = parseResult.GetRequiredValue(RepositoryId);

            Validate(
                parseResult: parseResult,
                perPage: perPage,
                page: page,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesListForAuthenticatedUserAsync(
                perPage: perPage,
                page: page,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}