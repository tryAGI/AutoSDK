//HintName: G.Commands.SecretScanningUpdateAlertCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecretScanningUpdateAlertCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int alertNumber,
            global::G.SecretScanningAlertState state,
            global::G.SecretScanningAlertResolution? resolution,
            string? resolutionComment,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SecretScanningAlert response,
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

        private global::System.CommandLine.Argument<global::G.SecretScanningAlertState> State { get; } = new(
            name: "state")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.SecretScanningAlertResolution?> Resolution { get; } = new(
            name: "resolution")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ResolutionComment { get; } = new(
            name: "resolutionComment")
        {
            Description = "",
        };
        public SecretScanningUpdateAlertCommand(G.IApi client) : base(
            name: "secret",
            description: @"Updates the status of a secret scanning alert in an eligible repository.

The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(AlertNumber);
            Arguments.Add(State);
            Options.Add(Resolution);
            Options.Add(ResolutionComment);

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
            var resolution = parseResult.GetRequiredValue(Resolution);
            var resolutionComment = parseResult.GetRequiredValue(ResolutionComment);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                state: state,
                resolution: resolution,
                resolutionComment: resolutionComment,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecretScanning.SecretScanningUpdateAlertAsync(
                owner: owner,
                repo: repo,
                alertNumber: alertNumber,
                state: state,
                resolution: resolution,
                resolutionComment: resolutionComment,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}