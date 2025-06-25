//HintName: G.Commands.MigrationsGetLargeFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsGetLargeFilesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.PorterLargeFile> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"The account owner of the repository. The name is not case sensitive.",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = @"The name of the repository without the `.git` extension. The name is not case sensitive.",
        };

        public MigrationsGetLargeFilesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"List files larger than 100MB found during the import

> [!WARNING]
> **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Owner);
            Arguments.Add(Repo);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsGetLargeFilesAsync(
                owner: owner,
                repo: repo,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}