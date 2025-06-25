//HintName: G.Commands.ActionsListSelfHostedRunnerGroupsForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsListSelfHostedRunnerGroupsForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? perPage,
            int? page,
            string? visibleToRepository,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsListSelfHostedRunnerGroupsForOrgResponse response,
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

        private global::System.CommandLine.Option<string?> VisibleToRepository { get; } = new(
            name: "visibleToRepository")
        {
            Description = "",
        };
        public ActionsListSelfHostedRunnerGroupsForOrgCommand(G.IApi client) : base(
            name: "actions",
            description: @"Lists all self-hosted runner groups configured in an organization and inherited from an enterprise.

OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(VisibleToRepository);

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
            var visibleToRepository = parseResult.GetRequiredValue(VisibleToRepository);

            Validate(
                parseResult: parseResult,
                org: org,
                perPage: perPage,
                page: page,
                visibleToRepository: visibleToRepository,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsListSelfHostedRunnerGroupsForOrgAsync(
                org: org,
                perPage: perPage,
                page: page,
                visibleToRepository: visibleToRepository,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}