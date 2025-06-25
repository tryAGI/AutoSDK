//HintName: G.Commands.ReposCreateInOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateInOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            string name,
            string? description,
            string? homepage,
            bool? @private,
            global::G.ReposCreateInOrgRequestVisibility? visibility,
            bool? hasIssues,
            bool? hasProjects,
            bool? hasWiki,
            bool? hasDownloads,
            bool? isTemplate,
            int? teamId,
            bool? autoInit,
            string? gitignoreTemplate,
            string? licenseTemplate,
            bool? allowSquashMerge,
            bool? allowMergeCommit,
            bool? allowRebaseMerge,
            bool? allowAutoMerge,
            bool? deleteBranchOnMerge,
            bool? useSquashPrTitleAsDefault,
            global::G.ReposCreateInOrgRequestSquashMergeCommitTitle? squashMergeCommitTitle,
            global::G.ReposCreateInOrgRequestSquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.ReposCreateInOrgRequestMergeCommitTitle? mergeCommitTitle,
            global::G.ReposCreateInOrgRequestMergeCommitMessage? mergeCommitMessage,
            object? customProperties,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FullRepository response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Homepage { get; } = new(
            name: "homepage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Private { get; } = new(
            name: "@private")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateInOrgRequestVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasIssues { get; } = new(
            name: "hasIssues")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasProjects { get; } = new(
            name: "hasProjects")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasWiki { get; } = new(
            name: "hasWiki")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> HasDownloads { get; } = new(
            name: "hasDownloads")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> IsTemplate { get; } = new(
            name: "isTemplate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TeamId { get; } = new(
            name: "teamId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoInit { get; } = new(
            name: "autoInit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> GitignoreTemplate { get; } = new(
            name: "gitignoreTemplate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> LicenseTemplate { get; } = new(
            name: "licenseTemplate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowSquashMerge { get; } = new(
            name: "allowSquashMerge")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowMergeCommit { get; } = new(
            name: "allowMergeCommit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowRebaseMerge { get; } = new(
            name: "allowRebaseMerge")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowAutoMerge { get; } = new(
            name: "allowAutoMerge")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> DeleteBranchOnMerge { get; } = new(
            name: "deleteBranchOnMerge")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> UseSquashPrTitleAsDefault { get; } = new(
            name: "useSquashPrTitleAsDefault")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateInOrgRequestSquashMergeCommitTitle?> SquashMergeCommitTitle { get; } = new(
            name: "squashMergeCommitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateInOrgRequestSquashMergeCommitMessage?> SquashMergeCommitMessage { get; } = new(
            name: "squashMergeCommitMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateInOrgRequestMergeCommitTitle?> MergeCommitTitle { get; } = new(
            name: "mergeCommitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateInOrgRequestMergeCommitMessage?> MergeCommitMessage { get; } = new(
            name: "mergeCommitMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<object?> CustomProperties { get; } = new(
            name: "customProperties")
        {
            Description = "",
        };
        public ReposCreateInOrgCommand(G.IApi client) : base(
            name: "repos",
            description: @"Creates a new repository in the specified organization. The authenticated user must be a member of the organization.

OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.")
        {
            _client = client;

            Arguments.Add(Org);
            Arguments.Add(Name);
            Options.Add(Description);
            Options.Add(Homepage);
            Options.Add(Private);
            Options.Add(Visibility);
            Options.Add(HasIssues);
            Options.Add(HasProjects);
            Options.Add(HasWiki);
            Options.Add(HasDownloads);
            Options.Add(IsTemplate);
            Options.Add(TeamId);
            Options.Add(AutoInit);
            Options.Add(GitignoreTemplate);
            Options.Add(LicenseTemplate);
            Options.Add(AllowSquashMerge);
            Options.Add(AllowMergeCommit);
            Options.Add(AllowRebaseMerge);
            Options.Add(AllowAutoMerge);
            Options.Add(DeleteBranchOnMerge);
            Options.Add(UseSquashPrTitleAsDefault);
            Options.Add(SquashMergeCommitTitle);
            Options.Add(SquashMergeCommitMessage);
            Options.Add(MergeCommitTitle);
            Options.Add(MergeCommitMessage);
            Options.Add(CustomProperties);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var homepage = parseResult.GetRequiredValue(Homepage);
            var @private = parseResult.GetRequiredValue(Private);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var hasIssues = parseResult.GetRequiredValue(HasIssues);
            var hasProjects = parseResult.GetRequiredValue(HasProjects);
            var hasWiki = parseResult.GetRequiredValue(HasWiki);
            var hasDownloads = parseResult.GetRequiredValue(HasDownloads);
            var isTemplate = parseResult.GetRequiredValue(IsTemplate);
            var teamId = parseResult.GetRequiredValue(TeamId);
            var autoInit = parseResult.GetRequiredValue(AutoInit);
            var gitignoreTemplate = parseResult.GetRequiredValue(GitignoreTemplate);
            var licenseTemplate = parseResult.GetRequiredValue(LicenseTemplate);
            var allowSquashMerge = parseResult.GetRequiredValue(AllowSquashMerge);
            var allowMergeCommit = parseResult.GetRequiredValue(AllowMergeCommit);
            var allowRebaseMerge = parseResult.GetRequiredValue(AllowRebaseMerge);
            var allowAutoMerge = parseResult.GetRequiredValue(AllowAutoMerge);
            var deleteBranchOnMerge = parseResult.GetRequiredValue(DeleteBranchOnMerge);
            var useSquashPrTitleAsDefault = parseResult.GetRequiredValue(UseSquashPrTitleAsDefault);
            var squashMergeCommitTitle = parseResult.GetRequiredValue(SquashMergeCommitTitle);
            var squashMergeCommitMessage = parseResult.GetRequiredValue(SquashMergeCommitMessage);
            var mergeCommitTitle = parseResult.GetRequiredValue(MergeCommitTitle);
            var mergeCommitMessage = parseResult.GetRequiredValue(MergeCommitMessage);
            var customProperties = parseResult.GetRequiredValue(CustomProperties);

            Validate(
                parseResult: parseResult,
                org: org,
                name: name,
                description: description,
                homepage: homepage,
                @private: @private,
                visibility: visibility,
                hasIssues: hasIssues,
                hasProjects: hasProjects,
                hasWiki: hasWiki,
                hasDownloads: hasDownloads,
                isTemplate: isTemplate,
                teamId: teamId,
                autoInit: autoInit,
                gitignoreTemplate: gitignoreTemplate,
                licenseTemplate: licenseTemplate,
                allowSquashMerge: allowSquashMerge,
                allowMergeCommit: allowMergeCommit,
                allowRebaseMerge: allowRebaseMerge,
                allowAutoMerge: allowAutoMerge,
                deleteBranchOnMerge: deleteBranchOnMerge,
                useSquashPrTitleAsDefault: useSquashPrTitleAsDefault,
                squashMergeCommitTitle: squashMergeCommitTitle,
                squashMergeCommitMessage: squashMergeCommitMessage,
                mergeCommitTitle: mergeCommitTitle,
                mergeCommitMessage: mergeCommitMessage,
                customProperties: customProperties,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateInOrgAsync(
                org: org,
                name: name,
                description: description,
                homepage: homepage,
                @private: @private,
                visibility: visibility,
                hasIssues: hasIssues,
                hasProjects: hasProjects,
                hasWiki: hasWiki,
                hasDownloads: hasDownloads,
                isTemplate: isTemplate,
                teamId: teamId,
                autoInit: autoInit,
                gitignoreTemplate: gitignoreTemplate,
                licenseTemplate: licenseTemplate,
                allowSquashMerge: allowSquashMerge,
                allowMergeCommit: allowMergeCommit,
                allowRebaseMerge: allowRebaseMerge,
                allowAutoMerge: allowAutoMerge,
                deleteBranchOnMerge: deleteBranchOnMerge,
                useSquashPrTitleAsDefault: useSquashPrTitleAsDefault,
                squashMergeCommitTitle: squashMergeCommitTitle,
                squashMergeCommitMessage: squashMergeCommitMessage,
                mergeCommitTitle: mergeCommitTitle,
                mergeCommitMessage: mergeCommitMessage,
                customProperties: customProperties,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}