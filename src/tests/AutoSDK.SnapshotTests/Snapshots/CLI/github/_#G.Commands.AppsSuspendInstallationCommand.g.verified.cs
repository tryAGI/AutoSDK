//HintName: G.Commands.AppsSuspendInstallationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsSuspendInstallationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int installationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> InstallationId { get; } = new(
            name: "installationId")
        {
            Description = "",
        };

        public AppsSuspendInstallationCommand(G.IApi client) : base(
            name: "apps",
            description: @"Suspends a GitHub App on a user, organization, or business account, which blocks the app from accessing the account's resources. When a GitHub App is suspended, the app's access to the GitHub API or webhook events is blocked for that account.

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;

            Arguments.Add(InstallationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var installationId = parseResult.GetRequiredValue(InstallationId);

            Validate(
                parseResult: parseResult,
                installationId: installationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Apps.AppsSuspendInstallationAsync(
                installationId: installationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}