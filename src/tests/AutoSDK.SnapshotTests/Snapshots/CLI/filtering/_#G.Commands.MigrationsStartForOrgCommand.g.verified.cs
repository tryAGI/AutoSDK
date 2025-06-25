//HintName: G.Commands.MigrationsStartForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsStartForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories,
            bool? excludeMetadata,
            bool? excludeGitData,
            bool? excludeAttachments,
            bool? excludeReleases,
            bool? excludeOwnerProjects,
            bool? orgMetadataOnly,
            global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>? exclude,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Migration response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Repositories { get; } = new(
            name: "repositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> LockRepositories { get; } = new(
            name: "lockRepositories")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludeMetadata { get; } = new(
            name: "excludeMetadata")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludeGitData { get; } = new(
            name: "excludeGitData")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludeAttachments { get; } = new(
            name: "excludeAttachments")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludeReleases { get; } = new(
            name: "excludeReleases")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> ExcludeOwnerProjects { get; } = new(
            name: "excludeOwnerProjects")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> OrgMetadataOnly { get; } = new(
            name: "orgMetadataOnly")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = "",
        };
        public MigrationsStartForOrgCommand(G.IApi client) : base(
            name: "migrations",
            description: @"Initiates the generation of a migration archive.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Repositories);
            Options.Add(LockRepositories);
            Options.Add(ExcludeMetadata);
            Options.Add(ExcludeGitData);
            Options.Add(ExcludeAttachments);
            Options.Add(ExcludeReleases);
            Options.Add(ExcludeOwnerProjects);
            Options.Add(OrgMetadataOnly);
            Options.Add(Exclude);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var repositories = parseResult.GetRequiredValue(Repositories);
            var lockRepositories = parseResult.GetRequiredValue(LockRepositories);
            var excludeMetadata = parseResult.GetRequiredValue(ExcludeMetadata);
            var excludeGitData = parseResult.GetRequiredValue(ExcludeGitData);
            var excludeAttachments = parseResult.GetRequiredValue(ExcludeAttachments);
            var excludeReleases = parseResult.GetRequiredValue(ExcludeReleases);
            var excludeOwnerProjects = parseResult.GetRequiredValue(ExcludeOwnerProjects);
            var orgMetadataOnly = parseResult.GetRequiredValue(OrgMetadataOnly);
            var exclude = parseResult.GetRequiredValue(Exclude);

            Validate(
                parseResult: parseResult,
                org: org,
                repositories: repositories,
                lockRepositories: lockRepositories,
                excludeMetadata: excludeMetadata,
                excludeGitData: excludeGitData,
                excludeAttachments: excludeAttachments,
                excludeReleases: excludeReleases,
                excludeOwnerProjects: excludeOwnerProjects,
                orgMetadataOnly: orgMetadataOnly,
                exclude: exclude,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Migrations.MigrationsStartForOrgAsync(
                org: org,
                repositories: repositories,
                lockRepositories: lockRepositories,
                excludeMetadata: excludeMetadata,
                excludeGitData: excludeGitData,
                excludeAttachments: excludeAttachments,
                excludeReleases: excludeReleases,
                excludeOwnerProjects: excludeOwnerProjects,
                orgMetadataOnly: orgMetadataOnly,
                exclude: exclude,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}