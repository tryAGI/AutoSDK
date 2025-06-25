//HintName: G.Commands.CopilotListCopilotSeatsForEnterpriseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CopilotListCopilotSeatsForEnterpriseCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string enterprise,
            int? page,
            int? perPage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CopilotListCopilotSeatsForEnterpriseResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Enterprise { get; } = new(
            name: "enterprise")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };
        public CopilotListCopilotSeatsForEnterpriseCommand(G.IApi client) : base(
            name: "copilot",
            description: @"> [!NOTE]
> This endpoint is in beta and is subject to change.

Lists all active Copilot seats across organizations or enterprise teams for an enterprise with a Copilot Business or Copilot Enterprise subscription.

Users with access through multiple organizations or enterprise teams will only be counted toward `total_seats` once.

For each organization or enterprise team which grants Copilot access to a user, a seat detail object will appear in the `seats` array.

Only enterprise owners and billing managers can view assigned Copilot seats across their child organizations or enterprise teams.

Personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Enterprise);
            Options.Add(Page);
            Options.Add(PerPage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var enterprise = parseResult.GetRequiredValue(Enterprise);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);

            Validate(
                parseResult: parseResult,
                enterprise: enterprise,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Copilot.CopilotListCopilotSeatsForEnterpriseAsync(
                enterprise: enterprise,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}