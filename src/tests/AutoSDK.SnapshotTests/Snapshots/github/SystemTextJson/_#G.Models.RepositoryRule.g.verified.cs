//HintName: G.Models.RepositoryRule.g.cs
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
        public bool TryPickCreation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleCreation? value)
        {
            value = Creation;
            return IsCreation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleCreation PickCreation() => Creation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Creation' but the value was {ToString()}.");

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
        public bool TryPickUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleUpdate? value)
        {
            value = Update;
            return IsUpdate;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleUpdate PickUpdate() => Update is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Update' but the value was {ToString()}.");

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
        public bool TryPickDeletion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleDeletion? value)
        {
            value = Deletion;
            return IsDeletion;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleDeletion PickDeletion() => Deletion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deletion' but the value was {ToString()}.");

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
        public bool TryPickRequiredLinearHistory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleRequiredLinearHistory? value)
        {
            value = RequiredLinearHistory;
            return IsRequiredLinearHistory;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleRequiredLinearHistory PickRequiredLinearHistory() => RequiredLinearHistory is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredLinearHistory' but the value was {ToString()}.");

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
        public bool TryPickMergeQueue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleMergeQueue? value)
        {
            value = MergeQueue;
            return IsMergeQueue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleMergeQueue PickMergeQueue() => MergeQueue is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MergeQueue' but the value was {ToString()}.");

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
        public bool TryPickRequiredDeployments(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleRequiredDeployments? value)
        {
            value = RequiredDeployments;
            return IsRequiredDeployments;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleRequiredDeployments PickRequiredDeployments() => RequiredDeployments is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredDeployments' but the value was {ToString()}.");

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
        public bool TryPickRequiredSignatures(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleRequiredSignatures? value)
        {
            value = RequiredSignatures;
            return IsRequiredSignatures;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleRequiredSignatures PickRequiredSignatures() => RequiredSignatures is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredSignatures' but the value was {ToString()}.");

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
        public bool TryPickPullRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRulePullRequest? value)
        {
            value = PullRequest;
            return IsPullRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRulePullRequest PickPullRequest() => PullRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PullRequest' but the value was {ToString()}.");

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
        public bool TryPickRequiredStatusChecks(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleRequiredStatusChecks? value)
        {
            value = RequiredStatusChecks;
            return IsRequiredStatusChecks;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleRequiredStatusChecks PickRequiredStatusChecks() => RequiredStatusChecks is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequiredStatusChecks' but the value was {ToString()}.");

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
        public bool TryPickNonFastForward(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleNonFastForward? value)
        {
            value = NonFastForward;
            return IsNonFastForward;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleNonFastForward PickNonFastForward() => NonFastForward is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NonFastForward' but the value was {ToString()}.");

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
        public bool TryPickCommitMessagePattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleCommitMessagePattern? value)
        {
            value = CommitMessagePattern;
            return IsCommitMessagePattern;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleCommitMessagePattern PickCommitMessagePattern() => CommitMessagePattern is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommitMessagePattern' but the value was {ToString()}.");

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
        public bool TryPickCommitAuthorEmailPattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            value = CommitAuthorEmailPattern;
            return IsCommitAuthorEmailPattern;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleCommitAuthorEmailPattern PickCommitAuthorEmailPattern() => CommitAuthorEmailPattern is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommitAuthorEmailPattern' but the value was {ToString()}.");

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
        public bool TryPickCommitterEmailPattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleCommitterEmailPattern? value)
        {
            value = CommitterEmailPattern;
            return IsCommitterEmailPattern;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleCommitterEmailPattern PickCommitterEmailPattern() => CommitterEmailPattern is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommitterEmailPattern' but the value was {ToString()}.");

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
        public bool TryPickBranchNamePattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleBranchNamePattern? value)
        {
            value = BranchNamePattern;
            return IsBranchNamePattern;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleBranchNamePattern PickBranchNamePattern() => BranchNamePattern is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BranchNamePattern' but the value was {ToString()}.");

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
        public bool TryPickTagNamePattern(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleTagNamePattern? value)
        {
            value = TagNamePattern;
            return IsTagNamePattern;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleTagNamePattern PickTagNamePattern() => TagNamePattern is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TagNamePattern' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that include changes in specified file paths from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleFilePathRestriction? FilePathRestriction { get; init; }
#else
        public global::G.RepositoryRuleFilePathRestriction? FilePathRestriction { get; }
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
        public bool TryPickFilePathRestriction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleFilePathRestriction? value)
        {
            value = FilePathRestriction;
            return IsFilePathRestriction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleFilePathRestriction PickFilePathRestriction() => FilePathRestriction is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilePathRestriction' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that include file paths that exceed a specified character limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleMaxFilePathLength? MaxFilePathLength { get; init; }
#else
        public global::G.RepositoryRuleMaxFilePathLength? MaxFilePathLength { get; }
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
        public bool TryPickMaxFilePathLength(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleMaxFilePathLength? value)
        {
            value = MaxFilePathLength;
            return IsMaxFilePathLength;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleMaxFilePathLength PickMaxFilePathLength() => MaxFilePathLength is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxFilePathLength' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleFileExtensionRestriction? FileExtensionRestriction { get; init; }
#else
        public global::G.RepositoryRuleFileExtensionRestriction? FileExtensionRestriction { get; }
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
        public bool TryPickFileExtensionRestriction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleFileExtensionRestriction? value)
        {
            value = FileExtensionRestriction;
            return IsFileExtensionRestriction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleFileExtensionRestriction PickFileExtensionRestriction() => FileExtensionRestriction is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileExtensionRestriction' but the value was {ToString()}.");

        /// <summary>
        /// Prevent commits that exceed a specified file size limit from being pushed to the commit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleMaxFileSize? MaxFileSize { get; init; }
#else
        public global::G.RepositoryRuleMaxFileSize? MaxFileSize { get; }
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
        public bool TryPickMaxFileSize(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleMaxFileSize? value)
        {
            value = MaxFileSize;
            return IsMaxFileSize;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleMaxFileSize PickMaxFileSize() => MaxFileSize is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxFileSize' but the value was {ToString()}.");

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
        public bool TryPickWorkflows(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleWorkflows? value)
        {
            value = Workflows;
            return IsWorkflows;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleWorkflows PickWorkflows() => Workflows is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Workflows' but the value was {ToString()}.");

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
        public bool TryPickCodeScanning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::G.RepositoryRuleCodeScanning? value)
        {
            value = CodeScanning;
            return IsCodeScanning;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::G.RepositoryRuleCodeScanning PickCodeScanning() => CodeScanning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeScanning' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCreation value) => new RepositoryRule((global::G.RepositoryRuleCreation?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromCreation(global::G.RepositoryRuleCreation? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleUpdate value) => new RepositoryRule((global::G.RepositoryRuleUpdate?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromUpdate(global::G.RepositoryRuleUpdate? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleDeletion value) => new RepositoryRule((global::G.RepositoryRuleDeletion?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromDeletion(global::G.RepositoryRuleDeletion? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredLinearHistory value) => new RepositoryRule((global::G.RepositoryRuleRequiredLinearHistory?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromRequiredLinearHistory(global::G.RepositoryRuleRequiredLinearHistory? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleMergeQueue value) => new RepositoryRule((global::G.RepositoryRuleMergeQueue?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromMergeQueue(global::G.RepositoryRuleMergeQueue? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredDeployments value) => new RepositoryRule((global::G.RepositoryRuleRequiredDeployments?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromRequiredDeployments(global::G.RepositoryRuleRequiredDeployments? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredSignatures value) => new RepositoryRule((global::G.RepositoryRuleRequiredSignatures?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromRequiredSignatures(global::G.RepositoryRuleRequiredSignatures? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRulePullRequest value) => new RepositoryRule((global::G.RepositoryRulePullRequest?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromPullRequest(global::G.RepositoryRulePullRequest? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks value) => new RepositoryRule((global::G.RepositoryRuleRequiredStatusChecks?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromRequiredStatusChecks(global::G.RepositoryRuleRequiredStatusChecks? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleNonFastForward value) => new RepositoryRule((global::G.RepositoryRuleNonFastForward?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromNonFastForward(global::G.RepositoryRuleNonFastForward? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitMessagePattern value) => new RepositoryRule((global::G.RepositoryRuleCommitMessagePattern?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromCommitMessagePattern(global::G.RepositoryRuleCommitMessagePattern? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern value) => new RepositoryRule((global::G.RepositoryRuleCommitAuthorEmailPattern?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromCommitAuthorEmailPattern(global::G.RepositoryRuleCommitAuthorEmailPattern? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern value) => new RepositoryRule((global::G.RepositoryRuleCommitterEmailPattern?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromCommitterEmailPattern(global::G.RepositoryRuleCommitterEmailPattern? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleBranchNamePattern value) => new RepositoryRule((global::G.RepositoryRuleBranchNamePattern?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromBranchNamePattern(global::G.RepositoryRuleBranchNamePattern? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleTagNamePattern value) => new RepositoryRule((global::G.RepositoryRuleTagNamePattern?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromTagNamePattern(global::G.RepositoryRuleTagNamePattern? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleFilePathRestriction value) => new RepositoryRule((global::G.RepositoryRuleFilePathRestriction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleFilePathRestriction?(RepositoryRule @this) => @this.FilePathRestriction;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleFilePathRestriction? value)
        {
            FilePathRestriction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RepositoryRule FromFilePathRestriction(global::G.RepositoryRuleFilePathRestriction? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleMaxFilePathLength value) => new RepositoryRule((global::G.RepositoryRuleMaxFilePathLength?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleMaxFilePathLength?(RepositoryRule @this) => @this.MaxFilePathLength;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleMaxFilePathLength? value)
        {
            MaxFilePathLength = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RepositoryRule FromMaxFilePathLength(global::G.RepositoryRuleMaxFilePathLength? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleFileExtensionRestriction value) => new RepositoryRule((global::G.RepositoryRuleFileExtensionRestriction?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleFileExtensionRestriction?(RepositoryRule @this) => @this.FileExtensionRestriction;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleFileExtensionRestriction? value)
        {
            FileExtensionRestriction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RepositoryRule FromFileExtensionRestriction(global::G.RepositoryRuleFileExtensionRestriction? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleMaxFileSize value) => new RepositoryRule((global::G.RepositoryRuleMaxFileSize?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleMaxFileSize?(RepositoryRule @this) => @this.MaxFileSize;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleMaxFileSize? value)
        {
            MaxFileSize = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RepositoryRule FromMaxFileSize(global::G.RepositoryRuleMaxFileSize? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleWorkflows value) => new RepositoryRule((global::G.RepositoryRuleWorkflows?)value);

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
        /// 
        /// </summary>
        public static RepositoryRule FromWorkflows(global::G.RepositoryRuleWorkflows? value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCodeScanning value) => new RepositoryRule((global::G.RepositoryRuleCodeScanning?)value);

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
        public static RepositoryRule FromCodeScanning(global::G.RepositoryRuleCodeScanning? value) => new RepositoryRule(value);

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
            global::G.RepositoryRuleFilePathRestriction? filePathRestriction,
            global::G.RepositoryRuleMaxFilePathLength? maxFilePathLength,
            global::G.RepositoryRuleFileExtensionRestriction? fileExtensionRestriction,
            global::G.RepositoryRuleMaxFileSize? maxFileSize,
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
        public override string? ToString() =>
            Creation?.ToString() ??
            Update?.ToString() ??
            Deletion?.ToString() ??
            RequiredLinearHistory?.ToString() ??
            MergeQueue?.ToString() ??
            RequiredDeployments?.ToString() ??
            RequiredSignatures?.ToString() ??
            PullRequest?.ToString() ??
            RequiredStatusChecks?.ToString() ??
            NonFastForward?.ToString() ??
            CommitMessagePattern?.ToString() ??
            CommitAuthorEmailPattern?.ToString() ??
            CommitterEmailPattern?.ToString() ??
            BranchNamePattern?.ToString() ??
            TagNamePattern?.ToString() ??
            FilePathRestriction?.ToString() ??
            MaxFilePathLength?.ToString() ??
            FileExtensionRestriction?.ToString() ??
            MaxFileSize?.ToString() ??
            Workflows?.ToString() ??
            CodeScanning?.ToString() 
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
            global::System.Func<global::G.RepositoryRuleCreation, TResult>? creation = null,
            global::System.Func<global::G.RepositoryRuleUpdate, TResult>? update = null,
            global::System.Func<global::G.RepositoryRuleDeletion, TResult>? deletion = null,
            global::System.Func<global::G.RepositoryRuleRequiredLinearHistory, TResult>? requiredLinearHistory = null,
            global::System.Func<global::G.RepositoryRuleMergeQueue, TResult>? mergeQueue = null,
            global::System.Func<global::G.RepositoryRuleRequiredDeployments, TResult>? requiredDeployments = null,
            global::System.Func<global::G.RepositoryRuleRequiredSignatures, TResult>? requiredSignatures = null,
            global::System.Func<global::G.RepositoryRulePullRequest, TResult>? pullRequest = null,
            global::System.Func<global::G.RepositoryRuleRequiredStatusChecks, TResult>? requiredStatusChecks = null,
            global::System.Func<global::G.RepositoryRuleNonFastForward, TResult>? nonFastForward = null,
            global::System.Func<global::G.RepositoryRuleCommitMessagePattern, TResult>? commitMessagePattern = null,
            global::System.Func<global::G.RepositoryRuleCommitAuthorEmailPattern, TResult>? commitAuthorEmailPattern = null,
            global::System.Func<global::G.RepositoryRuleCommitterEmailPattern, TResult>? committerEmailPattern = null,
            global::System.Func<global::G.RepositoryRuleBranchNamePattern, TResult>? branchNamePattern = null,
            global::System.Func<global::G.RepositoryRuleTagNamePattern, TResult>? tagNamePattern = null,
            global::System.Func<global::G.RepositoryRuleFilePathRestriction, TResult>? filePathRestriction = null,
            global::System.Func<global::G.RepositoryRuleMaxFilePathLength, TResult>? maxFilePathLength = null,
            global::System.Func<global::G.RepositoryRuleFileExtensionRestriction, TResult>? fileExtensionRestriction = null,
            global::System.Func<global::G.RepositoryRuleMaxFileSize, TResult>? maxFileSize = null,
            global::System.Func<global::G.RepositoryRuleWorkflows, TResult>? workflows = null,
            global::System.Func<global::G.RepositoryRuleCodeScanning, TResult>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Creation is { } __value0 && creation != null)
            {
                return creation(__value0);
            }
            else if (Update is { } __value1 && update != null)
            {
                return update(__value1);
            }
            else if (Deletion is { } __value2 && deletion != null)
            {
                return deletion(__value2);
            }
            else if (RequiredLinearHistory is { } __value3 && requiredLinearHistory != null)
            {
                return requiredLinearHistory(__value3);
            }
            else if (MergeQueue is { } __value4 && mergeQueue != null)
            {
                return mergeQueue(__value4);
            }
            else if (RequiredDeployments is { } __value5 && requiredDeployments != null)
            {
                return requiredDeployments(__value5);
            }
            else if (RequiredSignatures is { } __value6 && requiredSignatures != null)
            {
                return requiredSignatures(__value6);
            }
            else if (PullRequest is { } __value7 && pullRequest != null)
            {
                return pullRequest(__value7);
            }
            else if (RequiredStatusChecks is { } __value8 && requiredStatusChecks != null)
            {
                return requiredStatusChecks(__value8);
            }
            else if (NonFastForward is { } __value9 && nonFastForward != null)
            {
                return nonFastForward(__value9);
            }
            else if (CommitMessagePattern is { } __value10 && commitMessagePattern != null)
            {
                return commitMessagePattern(__value10);
            }
            else if (CommitAuthorEmailPattern is { } __value11 && commitAuthorEmailPattern != null)
            {
                return commitAuthorEmailPattern(__value11);
            }
            else if (CommitterEmailPattern is { } __value12 && committerEmailPattern != null)
            {
                return committerEmailPattern(__value12);
            }
            else if (BranchNamePattern is { } __value13 && branchNamePattern != null)
            {
                return branchNamePattern(__value13);
            }
            else if (TagNamePattern is { } __value14 && tagNamePattern != null)
            {
                return tagNamePattern(__value14);
            }
            else if (FilePathRestriction is { } __value15 && filePathRestriction != null)
            {
                return filePathRestriction(__value15);
            }
            else if (MaxFilePathLength is { } __value16 && maxFilePathLength != null)
            {
                return maxFilePathLength(__value16);
            }
            else if (FileExtensionRestriction is { } __value17 && fileExtensionRestriction != null)
            {
                return fileExtensionRestriction(__value17);
            }
            else if (MaxFileSize is { } __value18 && maxFileSize != null)
            {
                return maxFileSize(__value18);
            }
            else if (Workflows is { } __value19 && workflows != null)
            {
                return workflows(__value19);
            }
            else if (CodeScanning is { } __value20 && codeScanning != null)
            {
                return codeScanning(__value20);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RepositoryRuleCreation>? creation = null,

            global::System.Action<global::G.RepositoryRuleUpdate>? update = null,

            global::System.Action<global::G.RepositoryRuleDeletion>? deletion = null,

            global::System.Action<global::G.RepositoryRuleRequiredLinearHistory>? requiredLinearHistory = null,

            global::System.Action<global::G.RepositoryRuleMergeQueue>? mergeQueue = null,

            global::System.Action<global::G.RepositoryRuleRequiredDeployments>? requiredDeployments = null,

            global::System.Action<global::G.RepositoryRuleRequiredSignatures>? requiredSignatures = null,

            global::System.Action<global::G.RepositoryRulePullRequest>? pullRequest = null,

            global::System.Action<global::G.RepositoryRuleRequiredStatusChecks>? requiredStatusChecks = null,

            global::System.Action<global::G.RepositoryRuleNonFastForward>? nonFastForward = null,

            global::System.Action<global::G.RepositoryRuleCommitMessagePattern>? commitMessagePattern = null,

            global::System.Action<global::G.RepositoryRuleCommitAuthorEmailPattern>? commitAuthorEmailPattern = null,

            global::System.Action<global::G.RepositoryRuleCommitterEmailPattern>? committerEmailPattern = null,

            global::System.Action<global::G.RepositoryRuleBranchNamePattern>? branchNamePattern = null,

            global::System.Action<global::G.RepositoryRuleTagNamePattern>? tagNamePattern = null,

            global::System.Action<global::G.RepositoryRuleFilePathRestriction>? filePathRestriction = null,

            global::System.Action<global::G.RepositoryRuleMaxFilePathLength>? maxFilePathLength = null,

            global::System.Action<global::G.RepositoryRuleFileExtensionRestriction>? fileExtensionRestriction = null,

            global::System.Action<global::G.RepositoryRuleMaxFileSize>? maxFileSize = null,

            global::System.Action<global::G.RepositoryRuleWorkflows>? workflows = null,

            global::System.Action<global::G.RepositoryRuleCodeScanning>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Creation is { } __value0)
            {
                creation?.Invoke(__value0);
            }
            else if (Update is { } __value1)
            {
                update?.Invoke(__value1);
            }
            else if (Deletion is { } __value2)
            {
                deletion?.Invoke(__value2);
            }
            else if (RequiredLinearHistory is { } __value3)
            {
                requiredLinearHistory?.Invoke(__value3);
            }
            else if (MergeQueue is { } __value4)
            {
                mergeQueue?.Invoke(__value4);
            }
            else if (RequiredDeployments is { } __value5)
            {
                requiredDeployments?.Invoke(__value5);
            }
            else if (RequiredSignatures is { } __value6)
            {
                requiredSignatures?.Invoke(__value6);
            }
            else if (PullRequest is { } __value7)
            {
                pullRequest?.Invoke(__value7);
            }
            else if (RequiredStatusChecks is { } __value8)
            {
                requiredStatusChecks?.Invoke(__value8);
            }
            else if (NonFastForward is { } __value9)
            {
                nonFastForward?.Invoke(__value9);
            }
            else if (CommitMessagePattern is { } __value10)
            {
                commitMessagePattern?.Invoke(__value10);
            }
            else if (CommitAuthorEmailPattern is { } __value11)
            {
                commitAuthorEmailPattern?.Invoke(__value11);
            }
            else if (CommitterEmailPattern is { } __value12)
            {
                committerEmailPattern?.Invoke(__value12);
            }
            else if (BranchNamePattern is { } __value13)
            {
                branchNamePattern?.Invoke(__value13);
            }
            else if (TagNamePattern is { } __value14)
            {
                tagNamePattern?.Invoke(__value14);
            }
            else if (FilePathRestriction is { } __value15)
            {
                filePathRestriction?.Invoke(__value15);
            }
            else if (MaxFilePathLength is { } __value16)
            {
                maxFilePathLength?.Invoke(__value16);
            }
            else if (FileExtensionRestriction is { } __value17)
            {
                fileExtensionRestriction?.Invoke(__value17);
            }
            else if (MaxFileSize is { } __value18)
            {
                maxFileSize?.Invoke(__value18);
            }
            else if (Workflows is { } __value19)
            {
                workflows?.Invoke(__value19);
            }
            else if (CodeScanning is { } __value20)
            {
                codeScanning?.Invoke(__value20);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::G.RepositoryRuleCreation>? creation = null,
            global::System.Action<global::G.RepositoryRuleUpdate>? update = null,
            global::System.Action<global::G.RepositoryRuleDeletion>? deletion = null,
            global::System.Action<global::G.RepositoryRuleRequiredLinearHistory>? requiredLinearHistory = null,
            global::System.Action<global::G.RepositoryRuleMergeQueue>? mergeQueue = null,
            global::System.Action<global::G.RepositoryRuleRequiredDeployments>? requiredDeployments = null,
            global::System.Action<global::G.RepositoryRuleRequiredSignatures>? requiredSignatures = null,
            global::System.Action<global::G.RepositoryRulePullRequest>? pullRequest = null,
            global::System.Action<global::G.RepositoryRuleRequiredStatusChecks>? requiredStatusChecks = null,
            global::System.Action<global::G.RepositoryRuleNonFastForward>? nonFastForward = null,
            global::System.Action<global::G.RepositoryRuleCommitMessagePattern>? commitMessagePattern = null,
            global::System.Action<global::G.RepositoryRuleCommitAuthorEmailPattern>? commitAuthorEmailPattern = null,
            global::System.Action<global::G.RepositoryRuleCommitterEmailPattern>? committerEmailPattern = null,
            global::System.Action<global::G.RepositoryRuleBranchNamePattern>? branchNamePattern = null,
            global::System.Action<global::G.RepositoryRuleTagNamePattern>? tagNamePattern = null,
            global::System.Action<global::G.RepositoryRuleFilePathRestriction>? filePathRestriction = null,
            global::System.Action<global::G.RepositoryRuleMaxFilePathLength>? maxFilePathLength = null,
            global::System.Action<global::G.RepositoryRuleFileExtensionRestriction>? fileExtensionRestriction = null,
            global::System.Action<global::G.RepositoryRuleMaxFileSize>? maxFileSize = null,
            global::System.Action<global::G.RepositoryRuleWorkflows>? workflows = null,
            global::System.Action<global::G.RepositoryRuleCodeScanning>? codeScanning = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Creation is { } __value0)
            {
                creation?.Invoke(__value0);
            }
            else if (Update is { } __value1)
            {
                update?.Invoke(__value1);
            }
            else if (Deletion is { } __value2)
            {
                deletion?.Invoke(__value2);
            }
            else if (RequiredLinearHistory is { } __value3)
            {
                requiredLinearHistory?.Invoke(__value3);
            }
            else if (MergeQueue is { } __value4)
            {
                mergeQueue?.Invoke(__value4);
            }
            else if (RequiredDeployments is { } __value5)
            {
                requiredDeployments?.Invoke(__value5);
            }
            else if (RequiredSignatures is { } __value6)
            {
                requiredSignatures?.Invoke(__value6);
            }
            else if (PullRequest is { } __value7)
            {
                pullRequest?.Invoke(__value7);
            }
            else if (RequiredStatusChecks is { } __value8)
            {
                requiredStatusChecks?.Invoke(__value8);
            }
            else if (NonFastForward is { } __value9)
            {
                nonFastForward?.Invoke(__value9);
            }
            else if (CommitMessagePattern is { } __value10)
            {
                commitMessagePattern?.Invoke(__value10);
            }
            else if (CommitAuthorEmailPattern is { } __value11)
            {
                commitAuthorEmailPattern?.Invoke(__value11);
            }
            else if (CommitterEmailPattern is { } __value12)
            {
                committerEmailPattern?.Invoke(__value12);
            }
            else if (BranchNamePattern is { } __value13)
            {
                branchNamePattern?.Invoke(__value13);
            }
            else if (TagNamePattern is { } __value14)
            {
                tagNamePattern?.Invoke(__value14);
            }
            else if (FilePathRestriction is { } __value15)
            {
                filePathRestriction?.Invoke(__value15);
            }
            else if (MaxFilePathLength is { } __value16)
            {
                maxFilePathLength?.Invoke(__value16);
            }
            else if (FileExtensionRestriction is { } __value17)
            {
                fileExtensionRestriction?.Invoke(__value17);
            }
            else if (MaxFileSize is { } __value18)
            {
                maxFileSize?.Invoke(__value18);
            }
            else if (Workflows is { } __value19)
            {
                workflows?.Invoke(__value19);
            }
            else if (CodeScanning is { } __value20)
            {
                codeScanning?.Invoke(__value20);
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
                typeof(global::G.RepositoryRuleFilePathRestriction),
                MaxFilePathLength,
                typeof(global::G.RepositoryRuleMaxFilePathLength),
                FileExtensionRestriction,
                typeof(global::G.RepositoryRuleFileExtensionRestriction),
                MaxFileSize,
                typeof(global::G.RepositoryRuleMaxFileSize),
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

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
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
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleFilePathRestriction?>.Default.Equals(FilePathRestriction, other.FilePathRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleMaxFilePathLength?>.Default.Equals(MaxFilePathLength, other.MaxFilePathLength) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleFileExtensionRestriction?>.Default.Equals(FileExtensionRestriction, other.FileExtensionRestriction) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleMaxFileSize?>.Default.Equals(MaxFileSize, other.MaxFileSize) &&
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
    }
}
