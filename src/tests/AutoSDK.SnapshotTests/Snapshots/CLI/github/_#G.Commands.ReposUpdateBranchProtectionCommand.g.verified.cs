//HintName: G.Commands.ReposUpdateBranchProtectionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposUpdateBranchProtectionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string branch,
            global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecks? requiredStatusChecks,
            bool? enforceAdmins,
            global::G.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews? requiredPullRequestReviews,
            global::G.ReposUpdateBranchProtectionRequestRestrictions? restrictions,
            bool? requiredLinearHistory,
            bool? allowForcePushes,
            bool? allowDeletions,
            bool? blockCreations,
            bool? requiredConversationResolution,
            bool? lockBranch,
            bool? allowForkSyncing,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProtectedBranch response,
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

        private global::System.CommandLine.Argument<string> Branch { get; } = new(
            name: "branch")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ReposUpdateBranchProtectionRequestRequiredStatusChecks?> RequiredStatusChecks { get; } = new(
            name: "requiredStatusChecks")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<bool?> EnforceAdmins { get; } = new(
            name: "enforceAdmins")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ReposUpdateBranchProtectionRequestRequiredPullRequestReviews?> RequiredPullRequestReviews { get; } = new(
            name: "requiredPullRequestReviews")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.ReposUpdateBranchProtectionRequestRestrictions?> Restrictions { get; } = new(
            name: "restrictions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RequiredLinearHistory { get; } = new(
            name: "requiredLinearHistory")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowForcePushes { get; } = new(
            name: "allowForcePushes")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowDeletions { get; } = new(
            name: "allowDeletions")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> BlockCreations { get; } = new(
            name: "blockCreations")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RequiredConversationResolution { get; } = new(
            name: "requiredConversationResolution")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> LockBranch { get; } = new(
            name: "lockBranch")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AllowForkSyncing { get; } = new(
            name: "allowForkSyncing")
        {
            Description = "",
        };
        public ReposUpdateBranchProtectionCommand(G.IApi client) : base(
            name: "repos",
            description: @"Protected branches are available in public repositories with GitHub Free and GitHub Free for organizations, and in public and private repositories with GitHub Pro, GitHub Team, GitHub Enterprise Cloud, and GitHub Enterprise Server. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products) in the GitHub Help documentation.

Protecting a branch requires admin or owner permissions to the repository.

> [!NOTE]
> Passing new arrays of `users` and `teams` replaces their previous values.

> [!NOTE]
> The list of users, apps, and teams in total is limited to 100 items.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(Branch);
            Arguments.Add(RequiredStatusChecks);
            Arguments.Add(EnforceAdmins);
            Arguments.Add(RequiredPullRequestReviews);
            Arguments.Add(Restrictions);
            Options.Add(RequiredLinearHistory);
            Options.Add(AllowForcePushes);
            Options.Add(AllowDeletions);
            Options.Add(BlockCreations);
            Options.Add(RequiredConversationResolution);
            Options.Add(LockBranch);
            Options.Add(AllowForkSyncing);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var branch = parseResult.GetRequiredValue(Branch);
            var requiredStatusChecks = parseResult.GetRequiredValue(RequiredStatusChecks);
            var enforceAdmins = parseResult.GetRequiredValue(EnforceAdmins);
            var requiredPullRequestReviews = parseResult.GetRequiredValue(RequiredPullRequestReviews);
            var restrictions = parseResult.GetRequiredValue(Restrictions);
            var requiredLinearHistory = parseResult.GetRequiredValue(RequiredLinearHistory);
            var allowForcePushes = parseResult.GetRequiredValue(AllowForcePushes);
            var allowDeletions = parseResult.GetRequiredValue(AllowDeletions);
            var blockCreations = parseResult.GetRequiredValue(BlockCreations);
            var requiredConversationResolution = parseResult.GetRequiredValue(RequiredConversationResolution);
            var lockBranch = parseResult.GetRequiredValue(LockBranch);
            var allowForkSyncing = parseResult.GetRequiredValue(AllowForkSyncing);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                branch: branch,
                requiredStatusChecks: requiredStatusChecks,
                enforceAdmins: enforceAdmins,
                requiredPullRequestReviews: requiredPullRequestReviews,
                restrictions: restrictions,
                requiredLinearHistory: requiredLinearHistory,
                allowForcePushes: allowForcePushes,
                allowDeletions: allowDeletions,
                blockCreations: blockCreations,
                requiredConversationResolution: requiredConversationResolution,
                lockBranch: lockBranch,
                allowForkSyncing: allowForkSyncing,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposUpdateBranchProtectionAsync(
                owner: owner,
                repo: repo,
                branch: branch,
                requiredStatusChecks: requiredStatusChecks,
                enforceAdmins: enforceAdmins,
                requiredPullRequestReviews: requiredPullRequestReviews,
                restrictions: restrictions,
                requiredLinearHistory: requiredLinearHistory,
                allowForcePushes: allowForcePushes,
                allowDeletions: allowDeletions,
                blockCreations: blockCreations,
                requiredConversationResolution: requiredConversationResolution,
                lockBranch: lockBranch,
                allowForkSyncing: allowForkSyncing,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}