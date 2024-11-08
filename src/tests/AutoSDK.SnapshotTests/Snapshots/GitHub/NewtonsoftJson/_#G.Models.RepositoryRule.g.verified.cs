//HintName: G.Models.RepositoryRule.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A repository rule.
    /// </summary>
    public readonly partial struct RepositoryRule : global::System.IEquatable<RepositoryRule>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleDiscriminatorType? Type { get; }

        /// <summary>
        /// Only allow users with bypass permission to create matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCreation? Creation { get; init; }
#else
        public global::G.RepositoryRuleCreation? Creation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Creation))]
#endif
        public bool IsCreation => Creation != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCreation value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCreation?(RepositoryRule @this) => @this.Creation;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCreation? value)
        {
            Creation = value;
        }

        /// <summary>
        /// Only allow users with bypass permission to update matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleUpdate? Update { get; init; }
#else
        public global::G.RepositoryRuleUpdate? Update { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Update))]
#endif
        public bool IsUpdate => Update != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleUpdate value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleUpdate?(RepositoryRule @this) => @this.Update;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleUpdate? value)
        {
            Update = value;
        }

        /// <summary>
        /// Only allow users with bypass permissions to delete matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleDeletion? Deletion { get; init; }
#else
        public global::G.RepositoryRuleDeletion? Deletion { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deletion))]
#endif
        public bool IsDeletion => Deletion != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleDeletion value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleDeletion?(RepositoryRule @this) => @this.Deletion;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleDeletion? value)
        {
            Deletion = value;
        }

        /// <summary>
        /// Prevent merge commits from being pushed to matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredLinearHistory? RequiredLinearHistory { get; init; }
#else
        public global::G.RepositoryRuleRequiredLinearHistory? RequiredLinearHistory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredLinearHistory))]
#endif
        public bool IsRequiredLinearHistory => RequiredLinearHistory != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredLinearHistory value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredLinearHistory?(RepositoryRule @this) => @this.RequiredLinearHistory;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredLinearHistory? value)
        {
            RequiredLinearHistory = value;
        }

        /// <summary>
        /// Merges must be performed via a merge queue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleMergeQueue? MergeQueue { get; init; }
#else
        public global::G.RepositoryRuleMergeQueue? MergeQueue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MergeQueue))]
#endif
        public bool IsMergeQueue => MergeQueue != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleMergeQueue value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleMergeQueue?(RepositoryRule @this) => @this.MergeQueue;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleMergeQueue? value)
        {
            MergeQueue = value;
        }

        /// <summary>
        /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredDeployments? RequiredDeployments { get; init; }
#else
        public global::G.RepositoryRuleRequiredDeployments? RequiredDeployments { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredDeployments))]
#endif
        public bool IsRequiredDeployments => RequiredDeployments != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredDeployments value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredDeployments?(RepositoryRule @this) => @this.RequiredDeployments;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredDeployments? value)
        {
            RequiredDeployments = value;
        }

        /// <summary>
        /// Commits pushed to matching refs must have verified signatures.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredSignatures? RequiredSignatures { get; init; }
#else
        public global::G.RepositoryRuleRequiredSignatures? RequiredSignatures { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredSignatures))]
#endif
        public bool IsRequiredSignatures => RequiredSignatures != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredSignatures value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredSignatures?(RepositoryRule @this) => @this.RequiredSignatures;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredSignatures? value)
        {
            RequiredSignatures = value;
        }

        /// <summary>
        /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRulePullRequest? PullRequest { get; init; }
#else
        public global::G.RepositoryRulePullRequest? PullRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PullRequest))]
#endif
        public bool IsPullRequest => PullRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRulePullRequest value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRulePullRequest?(RepositoryRule @this) => @this.PullRequest;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRulePullRequest? value)
        {
            PullRequest = value;
        }

        /// <summary>
        /// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredStatusChecks? RequiredStatusChecks { get; init; }
#else
        public global::G.RepositoryRuleRequiredStatusChecks? RequiredStatusChecks { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredStatusChecks))]
#endif
        public bool IsRequiredStatusChecks => RequiredStatusChecks != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredStatusChecks?(RepositoryRule @this) => @this.RequiredStatusChecks;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks? value)
        {
            RequiredStatusChecks = value;
        }

        /// <summary>
        /// Prevent users with push access from force pushing to refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleNonFastForward? NonFastForward { get; init; }
#else
        public global::G.RepositoryRuleNonFastForward? NonFastForward { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NonFastForward))]
#endif
        public bool IsNonFastForward => NonFastForward != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleNonFastForward value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleNonFastForward?(RepositoryRule @this) => @this.NonFastForward;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleNonFastForward? value)
        {
            NonFastForward = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_message_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitMessagePattern? CommitMessagePattern { get; init; }
#else
        public global::G.RepositoryRuleCommitMessagePattern? CommitMessagePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitMessagePattern))]
#endif
        public bool IsCommitMessagePattern => CommitMessagePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitMessagePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitMessagePattern?(RepositoryRule @this) => @this.CommitMessagePattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitMessagePattern? value)
        {
            CommitMessagePattern = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_author_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitAuthorEmailPattern? CommitAuthorEmailPattern { get; init; }
#else
        public global::G.RepositoryRuleCommitAuthorEmailPattern? CommitAuthorEmailPattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitAuthorEmailPattern))]
#endif
        public bool IsCommitAuthorEmailPattern => CommitAuthorEmailPattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitAuthorEmailPattern?(RepositoryRule @this) => @this.CommitAuthorEmailPattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            CommitAuthorEmailPattern = value;
        }

        /// <summary>
        /// Parameters to be used for the committer_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitterEmailPattern? CommitterEmailPattern { get; init; }
#else
        public global::G.RepositoryRuleCommitterEmailPattern? CommitterEmailPattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommitterEmailPattern))]
#endif
        public bool IsCommitterEmailPattern => CommitterEmailPattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitterEmailPattern?(RepositoryRule @this) => @this.CommitterEmailPattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern? value)
        {
            CommitterEmailPattern = value;
        }

        /// <summary>
        /// Parameters to be used for the branch_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleBranchNamePattern? BranchNamePattern { get; init; }
#else
        public global::G.RepositoryRuleBranchNamePattern? BranchNamePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchNamePattern))]
#endif
        public bool IsBranchNamePattern => BranchNamePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleBranchNamePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleBranchNamePattern?(RepositoryRule @this) => @this.BranchNamePattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleBranchNamePattern? value)
        {
            BranchNamePattern = value;
        }

        /// <summary>
        /// Parameters to be used for the tag_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleTagNamePattern? TagNamePattern { get; init; }
#else
        public global::G.RepositoryRuleTagNamePattern? TagNamePattern { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TagNamePattern))]
#endif
        public bool IsTagNamePattern => TagNamePattern != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleTagNamePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleTagNamePattern?(RepositoryRule @this) => @this.TagNamePattern;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleTagNamePattern? value)
        {
            TagNamePattern = value;
        }

        /// <summary>
        /// Prevent commits that include changes in specified file paths from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant16? FilePathRestriction { get; init; }
#else
        public global::G.RepositoryRuleVariant16? FilePathRestriction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilePathRestriction))]
#endif
        public bool IsFilePathRestriction => FilePathRestriction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant16 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant16?(RepositoryRule @this) => @this.FilePathRestriction;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant16? value)
        {
            FilePathRestriction = value;
        }

        /// <summary>
        /// Prevent commits that include file paths that exceed a specified character limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant17? MaxFilePathLength { get; init; }
#else
        public global::G.RepositoryRuleVariant17? MaxFilePathLength { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxFilePathLength))]
#endif
        public bool IsMaxFilePathLength => MaxFilePathLength != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant17 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant17?(RepositoryRule @this) => @this.MaxFilePathLength;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant17? value)
        {
            MaxFilePathLength = value;
        }

        /// <summary>
        /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant18? FileExtensionRestriction { get; init; }
#else
        public global::G.RepositoryRuleVariant18? FileExtensionRestriction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileExtensionRestriction))]
#endif
        public bool IsFileExtensionRestriction => FileExtensionRestriction != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant18 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant18?(RepositoryRule @this) => @this.FileExtensionRestriction;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant18? value)
        {
            FileExtensionRestriction = value;
        }

        /// <summary>
        /// Prevent commits that exceed a specified file size limit from being pushed to the commit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant19? MaxFileSize { get; init; }
#else
        public global::G.RepositoryRuleVariant19? MaxFileSize { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxFileSize))]
#endif
        public bool IsMaxFileSize => MaxFileSize != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant19 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant19?(RepositoryRule @this) => @this.MaxFileSize;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant19? value)
        {
            MaxFileSize = value;
        }

        /// <summary>
        /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleWorkflows? Workflows { get; init; }
#else
        public global::G.RepositoryRuleWorkflows? Workflows { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Workflows))]
#endif
        public bool IsWorkflows => Workflows != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleWorkflows value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleWorkflows?(RepositoryRule @this) => @this.Workflows;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleWorkflows? value)
        {
            Workflows = value;
        }

        /// <summary>
        /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCodeScanning? CodeScanning { get; init; }
#else
        public global::G.RepositoryRuleCodeScanning? CodeScanning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeScanning))]
#endif
        public bool IsCodeScanning => CodeScanning != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCodeScanning value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCodeScanning?(RepositoryRule @this) => @this.CodeScanning;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCodeScanning? value)
        {
            CodeScanning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(
            global::G.RepositoryRuleDiscriminatorType? type,
            global::G.RepositoryRuleCreation? creation,
            global::G.RepositoryRuleUpdate? update,
            global::G.RepositoryRuleDeletion? deletion,
            global::G.RepositoryRuleRequiredLinearHistory? requiredLinearHistory,
            global::G.RepositoryRuleMergeQueue? mergeQueue,
            global::G.RepositoryRuleRequiredDeployments? requiredDeployments,
            global::G.RepositoryRuleRequiredSignatures? requiredSignatures,
            global::G.RepositoryRulePullRequest? pullRequest,
            global::G.RepositoryRuleRequiredStatusChecks? requiredStatusChecks,
            global::G.RepositoryRuleNonFastForward? nonFastForward,
            global::G.RepositoryRuleCommitMessagePattern? commitMessagePattern,
            global::G.RepositoryRuleCommitAuthorEmailPattern? commitAuthorEmailPattern,
            global::G.RepositoryRuleCommitterEmailPattern? committerEmailPattern,
            global::G.RepositoryRuleBranchNamePattern? branchNamePattern,
            global::G.RepositoryRuleTagNamePattern? tagNamePattern,
            global::G.RepositoryRuleVariant16? filePathRestriction,
            global::G.RepositoryRuleVariant17? maxFilePathLength,
            global::G.RepositoryRuleVariant18? fileExtensionRestriction,
            global::G.RepositoryRuleVariant19? maxFileSize,
            global::G.RepositoryRuleWorkflows? workflows,
            global::G.RepositoryRuleCodeScanning? codeScanning
            )
        {
            Type = type;

            Creation = creation;
            Update = update;
            Deletion = deletion;
            RequiredLinearHistory = requiredLinearHistory;
            MergeQueue = mergeQueue;
            RequiredDeployments = requiredDeployments;
            RequiredSignatures = requiredSignatures;
            PullRequest = pullRequest;
            RequiredStatusChecks = requiredStatusChecks;
            NonFastForward = nonFastForward;
            CommitMessagePattern = commitMessagePattern;
            CommitAuthorEmailPattern = commitAuthorEmailPattern;
            CommitterEmailPattern = committerEmailPattern;
            BranchNamePattern = branchNamePattern;
            TagNamePattern = tagNamePattern;
            FilePathRestriction = filePathRestriction;
            MaxFilePathLength = maxFilePathLength;
            FileExtensionRestriction = fileExtensionRestriction;
            MaxFileSize = maxFileSize;
            Workflows = workflows;
            CodeScanning = codeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeScanning as object ??
            Workflows as object ??
            MaxFileSize as object ??
            FileExtensionRestriction as object ??
            MaxFilePathLength as object ??
            FilePathRestriction as object ??
            TagNamePattern as object ??
            BranchNamePattern as object ??
            CommitterEmailPattern as object ??
            CommitAuthorEmailPattern as object ??
            CommitMessagePattern as object ??
            NonFastForward as object ??
            RequiredStatusChecks as object ??
            PullRequest as object ??
            RequiredSignatures as object ??
            RequiredDeployments as object ??
            MergeQueue as object ??
            RequiredLinearHistory as object ??
            Deletion as object ??
            Update as object ??
            Creation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && IsMaxFileSize && !IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && IsWorkflows && !IsCodeScanning || !IsCreation && !IsUpdate && !IsDeletion && !IsRequiredLinearHistory && !IsMergeQueue && !IsRequiredDeployments && !IsRequiredSignatures && !IsPullRequest && !IsRequiredStatusChecks && !IsNonFastForward && !IsCommitMessagePattern && !IsCommitAuthorEmailPattern && !IsCommitterEmailPattern && !IsBranchNamePattern && !IsTagNamePattern && !IsFilePathRestriction && !IsMaxFilePathLength && !IsFileExtensionRestriction && !IsMaxFileSize && !IsWorkflows && IsCodeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RepositoryRuleCreation?, TResult>? creation = null,
            global::System.Func<global::G.RepositoryRuleUpdate?, TResult>? update = null,
            global::System.Func<global::G.RepositoryRuleDeletion?, TResult>? deletion = null,
            global::System.Func<global::G.RepositoryRuleRequiredLinearHistory?, TResult>? requiredLinearHistory = null,
            global::System.Func<global::G.RepositoryRuleMergeQueue?, TResult>? mergeQueue = null,
            global::System.Func<global::G.RepositoryRuleRequiredDeployments?, TResult>? requiredDeployments = null,
            global::System.Func<global::G.RepositoryRuleRequiredSignatures?, TResult>? requiredSignatures = null,
            global::System.Func<global::G.RepositoryRulePullRequest?, TResult>? pullRequest = null,
            global::System.Func<global::G.RepositoryRuleRequiredStatusChecks?, TResult>? requiredStatusChecks = null,
            global::System.Func<global::G.RepositoryRuleNonFastForward?, TResult>? nonFastForward = null,
            global::System.Func<global::G.RepositoryRuleCommitMessagePattern?, TResult>? commitMessagePattern = null,
            global::System.Func<global::G.RepositoryRuleCommitAuthorEmailPattern?, TResult>? commitAuthorEmailPattern = null,
            global::System.Func<global::G.RepositoryRuleCommitterEmailPattern?, TResult>? committerEmailPattern = null,
            global::System.Func<global::G.RepositoryRuleBranchNamePattern?, TResult>? branchNamePattern = null,
            global::System.Func<global::G.RepositoryRuleTagNamePattern?, TResult>? tagNamePattern = null,
            global::System.Func<global::G.RepositoryRuleVariant16?, TResult>? filePathRestriction = null,
            global::System.Func<global::G.RepositoryRuleVariant17?, TResult>? maxFilePathLength = null,
            global::System.Func<global::G.RepositoryRuleVariant18?, TResult>? fileExtensionRestriction = null,
            global::System.Func<global::G.RepositoryRuleVariant19?, TResult>? maxFileSize = null,
            global::System.Func<global::G.RepositoryRuleWorkflows?, TResult>? workflows = null,
            global::System.Func<global::G.RepositoryRuleCodeScanning?, TResult>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation && creation != null)
            {
                return creation(Creation!);
            }
            else if (IsUpdate && update != null)
            {
                return update(Update!);
            }
            else if (IsDeletion && deletion != null)
            {
                return deletion(Deletion!);
            }
            else if (IsRequiredLinearHistory && requiredLinearHistory != null)
            {
                return requiredLinearHistory(RequiredLinearHistory!);
            }
            else if (IsMergeQueue && mergeQueue != null)
            {
                return mergeQueue(MergeQueue!);
            }
            else if (IsRequiredDeployments && requiredDeployments != null)
            {
                return requiredDeployments(RequiredDeployments!);
            }
            else if (IsRequiredSignatures && requiredSignatures != null)
            {
                return requiredSignatures(RequiredSignatures!);
            }
            else if (IsPullRequest && pullRequest != null)
            {
                return pullRequest(PullRequest!);
            }
            else if (IsRequiredStatusChecks && requiredStatusChecks != null)
            {
                return requiredStatusChecks(RequiredStatusChecks!);
            }
            else if (IsNonFastForward && nonFastForward != null)
            {
                return nonFastForward(NonFastForward!);
            }
            else if (IsCommitMessagePattern && commitMessagePattern != null)
            {
                return commitMessagePattern(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern && commitAuthorEmailPattern != null)
            {
                return commitAuthorEmailPattern(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern && committerEmailPattern != null)
            {
                return committerEmailPattern(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern && branchNamePattern != null)
            {
                return branchNamePattern(BranchNamePattern!);
            }
            else if (IsTagNamePattern && tagNamePattern != null)
            {
                return tagNamePattern(TagNamePattern!);
            }
            else if (IsFilePathRestriction && filePathRestriction != null)
            {
                return filePathRestriction(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength && maxFilePathLength != null)
            {
                return maxFilePathLength(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction && fileExtensionRestriction != null)
            {
                return fileExtensionRestriction(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize && maxFileSize != null)
            {
                return maxFileSize(MaxFileSize!);
            }
            else if (IsWorkflows && workflows != null)
            {
                return workflows(Workflows!);
            }
            else if (IsCodeScanning && codeScanning != null)
            {
                return codeScanning(CodeScanning!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RepositoryRuleCreation?>? creation = null,
            global::System.Action<global::G.RepositoryRuleUpdate?>? update = null,
            global::System.Action<global::G.RepositoryRuleDeletion?>? deletion = null,
            global::System.Action<global::G.RepositoryRuleRequiredLinearHistory?>? requiredLinearHistory = null,
            global::System.Action<global::G.RepositoryRuleMergeQueue?>? mergeQueue = null,
            global::System.Action<global::G.RepositoryRuleRequiredDeployments?>? requiredDeployments = null,
            global::System.Action<global::G.RepositoryRuleRequiredSignatures?>? requiredSignatures = null,
            global::System.Action<global::G.RepositoryRulePullRequest?>? pullRequest = null,
            global::System.Action<global::G.RepositoryRuleRequiredStatusChecks?>? requiredStatusChecks = null,
            global::System.Action<global::G.RepositoryRuleNonFastForward?>? nonFastForward = null,
            global::System.Action<global::G.RepositoryRuleCommitMessagePattern?>? commitMessagePattern = null,
            global::System.Action<global::G.RepositoryRuleCommitAuthorEmailPattern?>? commitAuthorEmailPattern = null,
            global::System.Action<global::G.RepositoryRuleCommitterEmailPattern?>? committerEmailPattern = null,
            global::System.Action<global::G.RepositoryRuleBranchNamePattern?>? branchNamePattern = null,
            global::System.Action<global::G.RepositoryRuleTagNamePattern?>? tagNamePattern = null,
            global::System.Action<global::G.RepositoryRuleVariant16?>? filePathRestriction = null,
            global::System.Action<global::G.RepositoryRuleVariant17?>? maxFilePathLength = null,
            global::System.Action<global::G.RepositoryRuleVariant18?>? fileExtensionRestriction = null,
            global::System.Action<global::G.RepositoryRuleVariant19?>? maxFileSize = null,
            global::System.Action<global::G.RepositoryRuleWorkflows?>? workflows = null,
            global::System.Action<global::G.RepositoryRuleCodeScanning?>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreation)
            {
                creation?.Invoke(Creation!);
            }
            else if (IsUpdate)
            {
                update?.Invoke(Update!);
            }
            else if (IsDeletion)
            {
                deletion?.Invoke(Deletion!);
            }
            else if (IsRequiredLinearHistory)
            {
                requiredLinearHistory?.Invoke(RequiredLinearHistory!);
            }
            else if (IsMergeQueue)
            {
                mergeQueue?.Invoke(MergeQueue!);
            }
            else if (IsRequiredDeployments)
            {
                requiredDeployments?.Invoke(RequiredDeployments!);
            }
            else if (IsRequiredSignatures)
            {
                requiredSignatures?.Invoke(RequiredSignatures!);
            }
            else if (IsPullRequest)
            {
                pullRequest?.Invoke(PullRequest!);
            }
            else if (IsRequiredStatusChecks)
            {
                requiredStatusChecks?.Invoke(RequiredStatusChecks!);
            }
            else if (IsNonFastForward)
            {
                nonFastForward?.Invoke(NonFastForward!);
            }
            else if (IsCommitMessagePattern)
            {
                commitMessagePattern?.Invoke(CommitMessagePattern!);
            }
            else if (IsCommitAuthorEmailPattern)
            {
                commitAuthorEmailPattern?.Invoke(CommitAuthorEmailPattern!);
            }
            else if (IsCommitterEmailPattern)
            {
                committerEmailPattern?.Invoke(CommitterEmailPattern!);
            }
            else if (IsBranchNamePattern)
            {
                branchNamePattern?.Invoke(BranchNamePattern!);
            }
            else if (IsTagNamePattern)
            {
                tagNamePattern?.Invoke(TagNamePattern!);
            }
            else if (IsFilePathRestriction)
            {
                filePathRestriction?.Invoke(FilePathRestriction!);
            }
            else if (IsMaxFilePathLength)
            {
                maxFilePathLength?.Invoke(MaxFilePathLength!);
            }
            else if (IsFileExtensionRestriction)
            {
                fileExtensionRestriction?.Invoke(FileExtensionRestriction!);
            }
            else if (IsMaxFileSize)
            {
                maxFileSize?.Invoke(MaxFileSize!);
            }
            else if (IsWorkflows)
            {
                workflows?.Invoke(Workflows!);
            }
            else if (IsCodeScanning)
            {
                codeScanning?.Invoke(CodeScanning!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Creation,
                typeof(global::G.RepositoryRuleCreation),
                Update,
                typeof(global::G.RepositoryRuleUpdate),
                Deletion,
                typeof(global::G.RepositoryRuleDeletion),
                RequiredLinearHistory,
                typeof(global::G.RepositoryRuleRequiredLinearHistory),
                MergeQueue,
                typeof(global::G.RepositoryRuleMergeQueue),
                RequiredDeployments,
                typeof(global::G.RepositoryRuleRequiredDeployments),
                RequiredSignatures,
                typeof(global::G.RepositoryRuleRequiredSignatures),
                PullRequest,
                typeof(global::G.RepositoryRulePullRequest),
                RequiredStatusChecks,
                typeof(global::G.RepositoryRuleRequiredStatusChecks),
                NonFastForward,
                typeof(global::G.RepositoryRuleNonFastForward),
                CommitMessagePattern,
                typeof(global::G.RepositoryRuleCommitMessagePattern),
                CommitAuthorEmailPattern,
                typeof(global::G.RepositoryRuleCommitAuthorEmailPattern),
                CommitterEmailPattern,
                typeof(global::G.RepositoryRuleCommitterEmailPattern),
                BranchNamePattern,
                typeof(global::G.RepositoryRuleBranchNamePattern),
                TagNamePattern,
                typeof(global::G.RepositoryRuleTagNamePattern),
                FilePathRestriction,
                typeof(global::G.RepositoryRuleVariant16),
                MaxFilePathLength,
                typeof(global::G.RepositoryRuleVariant17),
                FileExtensionRestriction,
                typeof(global::G.RepositoryRuleVariant18),
                MaxFileSize,
                typeof(global::G.RepositoryRuleVariant19),
                Workflows,
                typeof(global::G.RepositoryRuleWorkflows),
                CodeScanning,
                typeof(global::G.RepositoryRuleCodeScanning),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(RepositoryRule other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCreation?>.Default.Equals(Creation, other.Creation) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleUpdate?>.Default.Equals(Update, other.Update) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleDeletion?>.Default.Equals(Deletion, other.Deletion) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredLinearHistory?>.Default.Equals(RequiredLinearHistory, other.RequiredLinearHistory) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleMergeQueue?>.Default.Equals(MergeQueue, other.MergeQueue) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredDeployments?>.Default.Equals(RequiredDeployments, other.RequiredDeployments) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredSignatures?>.Default.Equals(RequiredSignatures, other.RequiredSignatures) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRulePullRequest?>.Default.Equals(PullRequest, other.PullRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredStatusChecks?>.Default.Equals(RequiredStatusChecks, other.RequiredStatusChecks) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleNonFastForward?>.Default.Equals(NonFastForward, other.NonFastForward) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitMessagePattern?>.Default.Equals(CommitMessagePattern, other.CommitMessagePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitAuthorEmailPattern?>.Default.Equals(CommitAuthorEmailPattern, other.CommitAuthorEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitterEmailPattern?>.Default.Equals(CommitterEmailPattern, other.CommitterEmailPattern) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleBranchNamePattern?>.Default.Equals(BranchNamePattern, other.BranchNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleTagNamePattern?>.Default.Equals(TagNamePattern, other.TagNamePattern) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant16?>.Default.Equals(FilePathRestriction, other.FilePathRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant17?>.Default.Equals(MaxFilePathLength, other.MaxFilePathLength) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant18?>.Default.Equals(FileExtensionRestriction, other.FileExtensionRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant19?>.Default.Equals(MaxFileSize, other.MaxFileSize) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleWorkflows?>.Default.Equals(Workflows, other.Workflows) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCodeScanning?>.Default.Equals(CodeScanning, other.CodeScanning) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoryRule obj1, RepositoryRule obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRule>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoryRule obj1, RepositoryRule obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRule o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.RepositoryRule? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryRule>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.RepositoryRule?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.RepositoryRule?>(serializer.Deserialize<global::G.RepositoryRule>(jsonReader));
        }

    }
}
