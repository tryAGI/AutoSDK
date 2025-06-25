//HintName: G.Commands.MigrationsStartForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MigrationsStartForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The organization name. The name is not case sensitive.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<string>> Repositories { get; } = new(
            name: "repositories")
        {
            Description = @"A list of arrays indicating which repositories should be migrated.",
        };

        private global::System.CommandLine.Option<bool?> LockRepositories { get; } = new(
            name: "lockRepositories")
        {
            Description = @"Indicates whether repositories should be locked (to prevent manipulation) while migrating data.",
        };

        private global::System.CommandLine.Option<bool?> ExcludeMetadata { get; } = new(
            name: "excludeMetadata")
        {
            Description = @"Indicates whether metadata should be excluded and only git source should be included for the migration.",
        };

        private global::System.CommandLine.Option<bool?> ExcludeGitData { get; } = new(
            name: "excludeGitData")
        {
            Description = @"Indicates whether the repository git data should be excluded from the migration.",
        };

        private global::System.CommandLine.Option<bool?> ExcludeAttachments { get; } = new(
            name: "excludeAttachments")
        {
            Description = @"Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).",
        };

        private global::System.CommandLine.Option<bool?> ExcludeReleases { get; } = new(
            name: "excludeReleases")
        {
            Description = @"Indicates whether releases should be excluded from the migration (to reduce migration archive file size).",
        };

        private global::System.CommandLine.Option<bool?> ExcludeOwnerProjects { get; } = new(
            name: "excludeOwnerProjects")
        {
            Description = @"Indicates whether projects owned by the organization or users should be excluded. from the migration.",
        };

        private global::System.CommandLine.Option<bool?> OrgMetadataOnly { get; } = new(
            name: "orgMetadataOnly")
        {
            Description = @"Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.MigrationsStartForOrgRequestExcludeItem>?> Exclude { get; } = new(
            name: "exclude")
        {
            Description = @"Exclude related items from being returned in the response in order to improve performance of the request.",
        };
        public MigrationsStartForOrgCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "migrations",
            description: @"Initiates the generation of a migration archive.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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