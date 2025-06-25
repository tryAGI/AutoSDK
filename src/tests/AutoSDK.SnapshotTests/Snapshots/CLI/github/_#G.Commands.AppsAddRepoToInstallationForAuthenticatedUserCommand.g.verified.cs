//HintName: G.Commands.AppsAddRepoToInstallationForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsAddRepoToInstallationForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int installationId,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> InstallationId { get; } = new(
            name: "installationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> RepositoryId { get; } = new(
            name: "repositoryId")
        {
            Description = "",
        };

        public AppsAddRepoToInstallationForAuthenticatedUserCommand(G.IApi client) : base(
            name: "apps",
            description: @"Add a single repository to an installation. The authenticated user must have admin access to the repository.    

This endpoint only works for PATs (classic) with the `repo` scope.")
        {
            _client = client;

            Arguments.Add(InstallationId);
            Arguments.Add(RepositoryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var installationId = parseResult.GetRequiredValue(InstallationId);
            var repositoryId = parseResult.GetRequiredValue(RepositoryId);

            Validate(
                parseResult: parseResult,
                installationId: installationId,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Apps.AppsAddRepoToInstallationForAuthenticatedUserAsync(
                installationId: installationId,
                repositoryId: repositoryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}