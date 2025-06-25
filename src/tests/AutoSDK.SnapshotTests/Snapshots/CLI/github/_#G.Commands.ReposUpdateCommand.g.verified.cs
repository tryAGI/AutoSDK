//HintName: G.Commands.ReposUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string? name,
            string? description,
            string? homepage,
            bool? @private,
            global::G.ReposUpdateRequestVisibility? visibility,
            global::G.ReposUpdateRequestSecurityAndAnalysis? securityAndAnalysis,
            bool? hasIssues,
            bool? hasProjects,
            bool? hasWiki,
            bool? isTemplate,
            string? defaultBranch,
            bool? allowSquashMerge,
            bool? allowMergeCommit,
            bool? allowRebaseMerge,
            bool? allowAutoMerge,
            bool? deleteBranchOnMerge,
            bool? allowUpdateBranch,
            bool? useSquashPrTitleAsDefault,
            global::G.ReposUpdateRequestSquashMergeCommitTitle? squashMergeCommitTitle,
            global::G.ReposUpdateRequestSquashMergeCommitMessage? squashMergeCommitMessage,
            global::G.ReposUpdateRequestMergeCommitTitle? mergeCommitTitle,
            global::G.ReposUpdateRequestMergeCommitMessage? mergeCommitMessage,
            bool? archived,
            bool? allowForking,
            bool? webCommitSignoffRequired,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FullRepository response,
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
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

        private global::System.CommandLine.Option<global::G.ReposUpdateRequestVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateRequestSecurityAndAnalysis?> SecurityAndAnalysis { get; } = new(
            name: "securityAndAnalysis")
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

        private global::System.CommandLine.Option<bool?> IsTemplate { get; } = new(
            name: "isTemplate")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> DefaultBranch { get; } = new(
            name: "defaultBranch")
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

        private global::System.CommandLine.Option<bool?> AllowUpdateBranch { get; } = new(
            name: "allowUpdateBranch")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> UseSquashPrTitleAsDefault { get; } = new(
            name: "useSquashPrTitleAsDefault")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateRequestSquashMergeCommitTitle?> SquashMergeCommitTitle { get; } = new(
            name: "squashMergeCommitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateRequestSquashMergeCommitMessage?> SquashMergeCommitMessage { get; } = new(
            name: "squashMergeCommitMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateRequestMergeCommitTitle?> MergeCommitTitle { get; } = new(
            name: "mergeCommitTitle")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ReposUpdateRequestMergeCommitMessage?> MergeCommitMessage { get; } = new(
            name: "mergeCommitMessage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Archived { get; } = new(
            name: "archived")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowForking { get; } = new(
            name: "allowForking")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> WebCommitSignoffRequired { get; } = new(
            name: "webCommitSignoffRequired")
        {
            Description = "",
        };
        public ReposUpdateCommand(G.IApi client) : base(
            name: "repos",
            description: @"**Note**: To edit a repository's topics, use the [Replace all repository topics](https://docs.github.com/rest/repos/repos#replace-all-repository-topics) endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(Name);
            Options.Add(Description);
            Options.Add(Homepage);
            Options.Add(Private);
            Options.Add(Visibility);
            Options.Add(SecurityAndAnalysis);
            Options.Add(HasIssues);
            Options.Add(HasProjects);
            Options.Add(HasWiki);
            Options.Add(IsTemplate);
            Options.Add(DefaultBranch);
            Options.Add(AllowSquashMerge);
            Options.Add(AllowMergeCommit);
            Options.Add(AllowRebaseMerge);
            Options.Add(AllowAutoMerge);
            Options.Add(DeleteBranchOnMerge);
            Options.Add(AllowUpdateBranch);
            Options.Add(UseSquashPrTitleAsDefault);
            Options.Add(SquashMergeCommitTitle);
            Options.Add(SquashMergeCommitMessage);
            Options.Add(MergeCommitTitle);
            Options.Add(MergeCommitMessage);
            Options.Add(Archived);
            Options.Add(AllowForking);
            Options.Add(WebCommitSignoffRequired);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var homepage = parseResult.GetRequiredValue(Homepage);
            var @private = parseResult.GetRequiredValue(Private);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var securityAndAnalysis = parseResult.GetRequiredValue(SecurityAndAnalysis);
            var hasIssues = parseResult.GetRequiredValue(HasIssues);
            var hasProjects = parseResult.GetRequiredValue(HasProjects);
            var hasWiki = parseResult.GetRequiredValue(HasWiki);
            var isTemplate = parseResult.GetRequiredValue(IsTemplate);
            var defaultBranch = parseResult.GetRequiredValue(DefaultBranch);
            var allowSquashMerge = parseResult.GetRequiredValue(AllowSquashMerge);
            var allowMergeCommit = parseResult.GetRequiredValue(AllowMergeCommit);
            var allowRebaseMerge = parseResult.GetRequiredValue(AllowRebaseMerge);
            var allowAutoMerge = parseResult.GetRequiredValue(AllowAutoMerge);
            var deleteBranchOnMerge = parseResult.GetRequiredValue(DeleteBranchOnMerge);
            var allowUpdateBranch = parseResult.GetRequiredValue(AllowUpdateBranch);
            var useSquashPrTitleAsDefault = parseResult.GetRequiredValue(UseSquashPrTitleAsDefault);
            var squashMergeCommitTitle = parseResult.GetRequiredValue(SquashMergeCommitTitle);
            var squashMergeCommitMessage = parseResult.GetRequiredValue(SquashMergeCommitMessage);
            var mergeCommitTitle = parseResult.GetRequiredValue(MergeCommitTitle);
            var mergeCommitMessage = parseResult.GetRequiredValue(MergeCommitMessage);
            var archived = parseResult.GetRequiredValue(Archived);
            var allowForking = parseResult.GetRequiredValue(AllowForking);
            var webCommitSignoffRequired = parseResult.GetRequiredValue(WebCommitSignoffRequired);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                name: name,
                description: description,
                homepage: homepage,
                @private: @private,
                visibility: visibility,
                securityAndAnalysis: securityAndAnalysis,
                hasIssues: hasIssues,
                hasProjects: hasProjects,
                hasWiki: hasWiki,
                isTemplate: isTemplate,
                defaultBranch: defaultBranch,
                allowSquashMerge: allowSquashMerge,
                allowMergeCommit: allowMergeCommit,
                allowRebaseMerge: allowRebaseMerge,
                allowAutoMerge: allowAutoMerge,
                deleteBranchOnMerge: deleteBranchOnMerge,
                allowUpdateBranch: allowUpdateBranch,
                useSquashPrTitleAsDefault: useSquashPrTitleAsDefault,
                squashMergeCommitTitle: squashMergeCommitTitle,
                squashMergeCommitMessage: squashMergeCommitMessage,
                mergeCommitTitle: mergeCommitTitle,
                mergeCommitMessage: mergeCommitMessage,
                archived: archived,
                allowForking: allowForking,
                webCommitSignoffRequired: webCommitSignoffRequired,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateAsync(
                owner: owner,
                repo: repo,
                name: name,
                description: description,
                homepage: homepage,
                @private: @private,
                visibility: visibility,
                securityAndAnalysis: securityAndAnalysis,
                hasIssues: hasIssues,
                hasProjects: hasProjects,
                hasWiki: hasWiki,
                isTemplate: isTemplate,
                defaultBranch: defaultBranch,
                allowSquashMerge: allowSquashMerge,
                allowMergeCommit: allowMergeCommit,
                allowRebaseMerge: allowRebaseMerge,
                allowAutoMerge: allowAutoMerge,
                deleteBranchOnMerge: deleteBranchOnMerge,
                allowUpdateBranch: allowUpdateBranch,
                useSquashPrTitleAsDefault: useSquashPrTitleAsDefault,
                squashMergeCommitTitle: squashMergeCommitTitle,
                squashMergeCommitMessage: squashMergeCommitMessage,
                mergeCommitTitle: mergeCommitTitle,
                mergeCommitMessage: mergeCommitMessage,
                archived: archived,
                allowForking: allowForking,
                webCommitSignoffRequired: webCommitSignoffRequired,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}