//HintName: G.Commands.AppsScopeTokenCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsScopeTokenCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string clientId,
            string accessToken,
            string? target,
            int? targetId,
            global::System.Collections.Generic.IList<string>? repositories,
            global::System.Collections.Generic.IList<int>? repositoryIds,
            global::G.AppPermissions? permissions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Authorization response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ClientId { get; } = new(
            name: "clientId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AccessToken { get; } = new(
            name: "accessToken")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Target { get; } = new(
            name: "target")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TargetId { get; } = new(
            name: "targetId")
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
        public AppsScopeTokenCommand(G.IApi client) : base(
            name: "apps",
            description: @"Use a non-scoped user access token to create a repository-scoped and/or permission-scoped user access token. You can specify
which repositories the token can access and which permissions are granted to the
token.

Invalid tokens will return `404 NOT FOUND`.")
        {
            _client = client;

            Arguments.Add(ClientId);
            Arguments.Add(AccessToken);
            Options.Add(Target);
            Options.Add(TargetId);
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
            var clientId = parseResult.GetRequiredValue(ClientId);
            var accessToken = parseResult.GetRequiredValue(AccessToken);
            var target = parseResult.GetRequiredValue(Target);
            var targetId = parseResult.GetRequiredValue(TargetId);
            var repositories = parseResult.GetRequiredValue(Repositories);
            var repositoryIds = parseResult.GetRequiredValue(RepositoryIds);
            var permissions = parseResult.GetRequiredValue(Permissions);

            Validate(
                parseResult: parseResult,
                clientId: clientId,
                accessToken: accessToken,
                target: target,
                targetId: targetId,
                repositories: repositories,
                repositoryIds: repositoryIds,
                permissions: permissions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsScopeTokenAsync(
                clientId: clientId,
                accessToken: accessToken,
                target: target,
                targetId: targetId,
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