//HintName: G.Commands.SecretScanningCreatePushProtectionBypassCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SecretScanningCreatePushProtectionBypassCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.SecretScanningPushProtectionBypassReason reason,
            string placeholderId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SecretScanningPushProtectionBypass response,
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

        private global::System.CommandLine.Argument<global::G.SecretScanningPushProtectionBypassReason> Reason { get; } = new(
            name: "reason")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PlaceholderId { get; } = new(
            name: "placeholderId")
        {
            Description = "",
        };

        public SecretScanningCreatePushProtectionBypassCommand(G.IApi client) : base(
            name: "secret",
            description: @"Creates a bypass for a previously push protected secret.

The authenticated user must be the original author of the committed secret.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Reason);
            Arguments.Add(PlaceholderId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var reason = parseResult.GetRequiredValue(Reason);
            var placeholderId = parseResult.GetRequiredValue(PlaceholderId);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                reason: reason,
                placeholderId: placeholderId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.SecretScanning.SecretScanningCreatePushProtectionBypassAsync(
                owner: owner,
                repo: repo,
                reason: reason,
                placeholderId: placeholderId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}