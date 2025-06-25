//HintName: G.Commands.AppsCreateInstallationAccessTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsCreateInstallationAccessTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int installationId,
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<int>? repositoryIds,
            global::G.AppPermissions? permissions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.InstallationToken response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> InstallationId { get; } = new(
            name: "installationId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Repositories { get; } = new(
            name: "repositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<int>?> RepositoryIds { get; } = new(
            name: "repositoryIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AppPermissions?> Permissions { get; } = new(
            name: "permissions")
        {
            Description = "",
        };
        public AppsCreateInstallationAccessTokenCommand(G.IApi client) : base(
            name: "apps",
            description: @"Creates an installation access token that enables a GitHub App to make authenticated API requests for the app's installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of `401 - Unauthorized`, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access.

Optionally, you can use the `repositories` or `repository_ids` body parameters to specify individual repositories that the installation access token can access. If you don't use `repositories` or `repository_ids` to grant access to specific repositories, the installation access token will have access to all repositories that the installation was granted access to. The installation access token cannot be granted access to repositories that the installation was not granted access to. Up to 500 repositories can be listed in this manner.

Optionally, use the `permissions` body parameter to specify the permissions that the installation access token should have. If `permissions` is not specified, the installation access token will have all of the permissions that were granted to the app. The installation access token cannot be granted permissions that the app was not granted.

When using the repository or permission parameters to reduce the access of the token, the complexity of the token is increased due to both the number of permissions in the request and the number of repositories the token will have access to. If the complexity is too large, the token will fail to be issued. If this occurs, the error message will indicate the maximum number of repositories that should be requested. For the average application requesting 8 permissions, this limit is around 5000 repositories. With fewer permissions requested, more repositories are supported.

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;

            Arguments.Add(InstallationId);
            Options.Add(Repositories);
            Options.Add(RepositoryIds);
            Options.Add(Permissions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var installationId = parseResult.GetRequiredValue(InstallationId);
            var repositories = parseResult.GetRequiredValue(Repositories);
            var repositoryIds = parseResult.GetRequiredValue(RepositoryIds);
            var permissions = parseResult.GetRequiredValue(Permissions);

            Validate(
                parseResult: parseResult,
                installationId: installationId,
                repositories: repositories,
                repositoryIds: repositoryIds,
                permissions: permissions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsCreateInstallationAccessTokenAsync(
                installationId: installationId,
                repositories: repositories,
                repositoryIds: repositoryIds,
                permissions: permissions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}