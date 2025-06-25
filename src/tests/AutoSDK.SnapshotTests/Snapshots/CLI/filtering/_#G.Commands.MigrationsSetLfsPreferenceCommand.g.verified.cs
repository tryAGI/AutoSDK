//HintName: G.Commands.MigrationsSetLfsPreferenceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsSetLfsPreferenceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            global::G.MigrationsSetLfsPreferenceRequestUseLfs useLfs,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Import response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::G.MigrationsSetLfsPreferenceRequestUseLfs> UseLfs { get; } = new(
            name: "useLfs")
        {
            Description = @"",
        };

        public MigrationsSetLfsPreferenceCommand(G.IApi client) : base(
            name: "migrations",
            description: @"You can import repositories from Subversion, Mercurial, and TFS that include files larger than 100MB. This ability
is powered by [Git LFS](https://git-lfs.com).

You can learn more about our LFS feature and working with large files [on our help
site](https://docs.github.com/repositories/working-with-files/managing-large-files).

> [!WARNING]
> **Deprecation notice:** Due to very low levels of usage and available alternatives, this endpoint is deprecated and will no longer be available from 00:00 UTC on April 12, 2024. For more details and alternatives, see the [changelog](https://gh.io/source-imports-api-deprecation).")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(UseLfs);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var useLfs = parseResult.GetRequiredValue(UseLfs);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                useLfs: useLfs,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsSetLfsPreferenceAsync(
                owner: owner,
                repo: repo,
                useLfs: useLfs,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}