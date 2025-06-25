//HintName: G.Commands.ReposCreateForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposCreateForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            string? description,
            string? homepage,
            bool? @private,
            bool? hasIssues,
            bool? hasProjects,
            bool? hasWiki,
            bool? hasDiscussions,
            int? teamId,
            bool? autoInit,
            string? gitignoreTemplate,
            string? licenseTemplate,
            bool? allowSquashMerge,
            bool? allowMergeCommit,
            bool? allowRebaseMerge,
            bool? allowAutoMerge,
            bool? deleteBranchOnMerge,
            global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle? squashMergeCommitTitle,
            global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.ReposCreateForAuthenticatedUserRequestMergeCommitTitle? mergeCommitTitle,
            global::G.ReposCreateForAuthenticatedUserRequestMergeCommitMessage? mergeCommitMessage,
            bool? hasDownloads,
            bool? isTemplate,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FullRepository response,
            global::System.Threading.CancellationToken cancellationToken);

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

        private global::System.CommandLine.Option<bool?> HasDiscussions { get; } = new(
            name: "hasDiscussions")
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

        private global::System.CommandLine.Option<global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitTitle?> SquashMergeCommitTitle { get; } = new(
            name: "squashMergeCommitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateForAuthenticatedUserRequestSquashMergeCommitMessage?> SquashMergeCommitMessage { get; } = new(
            name: "squashMergeCommitMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateForAuthenticatedUserRequestMergeCommitTitle?> MergeCommitTitle { get; } = new(
            name: "mergeCommitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposCreateForAuthenticatedUserRequestMergeCommitMessage?> MergeCommitMessage { get; } = new(
            name: "mergeCommitMessage")
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
        public ReposCreateForAuthenticatedUserCommand(G.IApi client) : base(
            name: "repos",
            description: @"Creates a new repository for the authenticated user.

OAuth app tokens and personal access tokens (classic) need the `public_repo` or `repo` scope to create a public repository, and `repo` scope to create a private repository.")
        {
            _client = client;

            Arguments.Add(Name);
            Options.Add(Description);
            Options.Add(Homepage);
            Options.Add(Private);
            Options.Add(HasIssues);
            Options.Add(HasProjects);
            Options.Add(HasWiki);
            Options.Add(HasDiscussions);
            Options.Add(TeamId);
            Options.Add(AutoInit);
            Options.Add(GitignoreTemplate);
            Options.Add(LicenseTemplate);
            Options.Add(AllowSquashMerge);
            Options.Add(AllowMergeCommit);
            Options.Add(AllowRebaseMerge);
            Options.Add(AllowAutoMerge);
            Options.Add(DeleteBranchOnMerge);
            Options.Add(SquashMergeCommitTitle);
            Options.Add(SquashMergeCommitMessage);
            Options.Add(MergeCommitTitle);
            Options.Add(MergeCommitMessage);
            Options.Add(HasDownloads);
            Options.Add(IsTemplate);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var homepage = parseResult.GetRequiredValue(Homepage);
            var @private = parseResult.GetRequiredValue(Private);
            var hasIssues = parseResult.GetRequiredValue(HasIssues);
            var hasProjects = parseResult.GetRequiredValue(HasProjects);
            var hasWiki = parseResult.GetRequiredValue(HasWiki);
            var hasDiscussions = parseResult.GetRequiredValue(HasDiscussions);
            var teamId = parseResult.GetRequiredValue(TeamId);
            var autoInit = parseResult.GetRequiredValue(AutoInit);
            var gitignoreTemplate = parseResult.GetRequiredValue(GitignoreTemplate);
            var licenseTemplate = parseResult.GetRequiredValue(LicenseTemplate);
            var allowSquashMerge = parseResult.GetRequiredValue(AllowSquashMerge);
            var allowMergeCommit = parseResult.GetRequiredValue(AllowMergeCommit);
            var allowRebaseMerge = parseResult.GetRequiredValue(AllowRebaseMerge);
            var allowAutoMerge = parseResult.GetRequiredValue(AllowAutoMerge);
            var deleteBranchOnMerge = parseResult.GetRequiredValue(DeleteBranchOnMerge);
            var squashMergeCommitTitle = parseResult.GetRequiredValue(SquashMergeCommitTitle);
            var squashMergeCommitMessage = parseResult.GetRequiredValue(SquashMergeCommitMessage);
            var mergeCommitTitle = parseResult.GetRequiredValue(MergeCommitTitle);
            var mergeCommitMessage = parseResult.GetRequiredValue(MergeCommitMessage);
            var hasDownloads = parseResult.GetRequiredValue(HasDownloads);
            var isTemplate = parseResult.GetRequiredValue(IsTemplate);

            Validate(
                parseResult: parseResult,
                name: name,
                description: description,
                homepage: homepage,
                @private: @private,
                hasIssues: hasIssues,
                hasProjects: hasProjects,
                hasWiki: hasWiki,
                hasDiscussions: hasDiscussions,
                teamId: teamId,
                autoInit: autoInit,
                gitignoreTemplate: gitignoreTemplate,
                licenseTemplate: licenseTemplate,
                allowSquashMerge: allowSquashMerge,
                allowMergeCommit: allowMergeCommit,
                allowRebaseMerge: allowRebaseMerge,
                allowAutoMerge: allowAutoMerge,
                deleteBranchOnMerge: deleteBranchOnMerge,
                squashMergeCommitTitle: squashMergeCommitTitle,
                squashMergeCommitMessage: squashMergeCommitMessage,
                mergeCommitTitle: mergeCommitTitle,
                mergeCommitMessage: mergeCommitMessage,
                hasDownloads: hasDownloads,
                isTemplate: isTemplate,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposCreateForAuthenticatedUserAsync(
                name: name,
                description: description,
                homepage: homepage,
                @private: @private,
                hasIssues: hasIssues,
                hasProjects: hasProjects,
                hasWiki: hasWiki,
                hasDiscussions: hasDiscussions,
                teamId: teamId,
                autoInit: autoInit,
                gitignoreTemplate: gitignoreTemplate,
                licenseTemplate: licenseTemplate,
                allowSquashMerge: allowSquashMerge,
                allowMergeCommit: allowMergeCommit,
                allowRebaseMerge: allowRebaseMerge,
                allowAutoMerge: allowAutoMerge,
                deleteBranchOnMerge: deleteBranchOnMerge,
                squashMergeCommitTitle: squashMergeCommitTitle,
                squashMergeCommitMessage: squashMergeCommitMessage,
                mergeCommitTitle: mergeCommitTitle,
                mergeCommitMessage: mergeCommitMessage,
                hasDownloads: hasDownloads,
                isTemplate: isTemplate,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}