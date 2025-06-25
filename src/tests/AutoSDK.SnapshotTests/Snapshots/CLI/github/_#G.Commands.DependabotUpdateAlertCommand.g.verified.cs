//HintName: G.Commands.DependabotUpdateAlertCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DependabotUpdateAlertCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int alertNumber,
            global::G.DependabotUpdateAlertRequestState state,
            global::G.DependabotUpdateAlertRequestDismissedReason? dismissedReason,
            string? dismissedComment,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DependabotAlert response,
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

        private global::System.CommandLine.Argument<int> AlertNumber { get; } = new(
            name: "alertNumber")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.DependabotUpdateAlertRequestState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.DependabotUpdateAlertRequestDismissedReason?> DismissedReason { get; } = new(
            name: "dismissedReason")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DismissedComment { get; } = new(
            name: "dismissedComment")
        {
            Description = "",
        };
        public DependabotUpdateAlertCommand(G.IApi client) : base(
            name: "dependabot",
            description: @"The authenticated user must have access to security alerts for the repository to use this endpoint. For more information, see ""[Granting access to security alerts](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-security-and-analysis-settings-for-your-repository#granting-access-to-security-alerts).""

OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AlertNumber);
            Arguments.Add(State);
            Options.Add(DismissedReason);
            Options.Add(DismissedComment);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var alertNumber = parseResult.GetRequiredValue(AlertNumber);
            var state = parseResult.GetRequiredValue(State);
            var dismissedReason = parseResult.GetRequiredValue(DismissedReason);
            var dismissedComment = parseResult.GetRequiredValue(DismissedComment);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                state: state,
                dismissedReason: dismissedReason,
                dismissedComment: dismissedComment,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Dependabot.DependabotUpdateAlertAsync(
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                state: state,
                dismissedReason: dismissedReason,
                dismissedComment: dismissedComment,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}