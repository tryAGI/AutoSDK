//HintName: G.Commands.CodespacesCreateWithRepoForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodespacesCreateWithRepoForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? @ref,
            string? location,
            global::G.CodespacesCreateWithRepoForAuthenticatedUserRequestGeo? geo,
            string? clientIp,
            string? machine,
            string? devcontainerPath,
            bool? multiRepoPermissionsOptOut,
            string? workingDirectory,
            int? idleTimeoutMinutes,
            string? displayName,
            int? retentionPeriodMinutes,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Codespace response,
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

        private global::System.CommandLine.Option<string?> Ref { get; } = new(
            name: "@ref")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Location { get; } = new(
            name: "location")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CodespacesCreateWithRepoForAuthenticatedUserRequestGeo?> Geo { get; } = new(
            name: "geo")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ClientIp { get; } = new(
            name: "clientIp")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Machine { get; } = new(
            name: "machine")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DevcontainerPath { get; } = new(
            name: "devcontainerPath")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> MultiRepoPermissionsOptOut { get; } = new(
            name: "multiRepoPermissionsOptOut")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> WorkingDirectory { get; } = new(
            name: "workingDirectory")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> IdleTimeoutMinutes { get; } = new(
            name: "idleTimeoutMinutes")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DisplayName { get; } = new(
            name: "displayName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> RetentionPeriodMinutes { get; } = new(
            name: "retentionPeriodMinutes")
        {
            Description = "",
        };
        public CodespacesCreateWithRepoForAuthenticatedUserCommand(G.IApi client) : base(
            name: "codespaces",
            description: @"Creates a codespace owned by the authenticated user in the specified repository.

OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Ref);
            Options.Add(Location);
            Options.Add(Geo);
            Options.Add(ClientIp);
            Options.Add(Machine);
            Options.Add(DevcontainerPath);
            Options.Add(MultiRepoPermissionsOptOut);
            Options.Add(WorkingDirectory);
            Options.Add(IdleTimeoutMinutes);
            Options.Add(DisplayName);
            Options.Add(RetentionPeriodMinutes);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var @ref = parseResult.GetRequiredValue(Ref);
            var location = parseResult.GetRequiredValue(Location);
            var geo = parseResult.GetRequiredValue(Geo);
            var clientIp = parseResult.GetRequiredValue(ClientIp);
            var machine = parseResult.GetRequiredValue(Machine);
            var devcontainerPath = parseResult.GetRequiredValue(DevcontainerPath);
            var multiRepoPermissionsOptOut = parseResult.GetRequiredValue(MultiRepoPermissionsOptOut);
            var workingDirectory = parseResult.GetRequiredValue(WorkingDirectory);
            var idleTimeoutMinutes = parseResult.GetRequiredValue(IdleTimeoutMinutes);
            var displayName = parseResult.GetRequiredValue(DisplayName);
            var retentionPeriodMinutes = parseResult.GetRequiredValue(RetentionPeriodMinutes);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                @ref: @ref,
                location: location,
                geo: geo,
                clientIp: clientIp,
                machine: machine,
                devcontainerPath: devcontainerPath,
                multiRepoPermissionsOptOut: multiRepoPermissionsOptOut,
                workingDirectory: workingDirectory,
                idleTimeoutMinutes: idleTimeoutMinutes,
                displayName: displayName,
                retentionPeriodMinutes: retentionPeriodMinutes,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Codespaces.CodespacesCreateWithRepoForAuthenticatedUserAsync(
                owner: owner,
                repo: repo,
                @ref: @ref,
                location: location,
                geo: geo,
                clientIp: clientIp,
                machine: machine,
                devcontainerPath: devcontainerPath,
                multiRepoPermissionsOptOut: multiRepoPermissionsOptOut,
                workingDirectory: workingDirectory,
                idleTimeoutMinutes: idleTimeoutMinutes,
                displayName: displayName,
                retentionPeriodMinutes: retentionPeriodMinutes,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}