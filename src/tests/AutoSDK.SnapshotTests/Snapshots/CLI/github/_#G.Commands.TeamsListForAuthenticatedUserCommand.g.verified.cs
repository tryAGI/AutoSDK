//HintName: G.Commands.TeamsListForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TeamsListForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? perPage,
            int? page,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.TeamFull> response,
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
        public TeamsListForAuthenticatedUserCommand(G.IApi client) : base(
            name: "teams",
            description: @"List all of the teams across all of the organizations to which the authenticated
user belongs.

OAuth app tokens and personal access tokens (classic) need the `user`, `repo`, or `read:org` scope to use this endpoint.

When using a fine-grained personal access token, the resource owner of the token must be a single organization, and the response will only include the teams from that organization.")
        {
            _client = client;

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
            var response = await _client.Teams.TeamsListForAuthenticatedUserAsync(
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