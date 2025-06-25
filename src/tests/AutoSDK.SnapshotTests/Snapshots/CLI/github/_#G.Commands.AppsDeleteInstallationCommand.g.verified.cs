//HintName: G.Commands.AppsDeleteInstallationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsDeleteInstallationCommand : global::System.CommandLine.Command
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

        public AppsDeleteInstallationCommand(G.IApi client) : base(
            name: "apps",
            description: @"Uninstalls a GitHub App on a user, organization, or business account. If you prefer to temporarily suspend an app's access to your account's resources, then we recommend the ""[Suspend an app installation](https://docs.github.com/rest/apps/apps#suspend-an-app-installation)"" endpoint.

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
            await _client.Apps.AppsDeleteInstallationAsync(
                installationId: installationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}