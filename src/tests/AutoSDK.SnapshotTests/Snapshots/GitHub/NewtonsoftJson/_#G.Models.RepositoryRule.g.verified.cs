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
        public global::G.RepositoryRuleCreation? Value1 { get; init; }
#else
        public global::G.RepositoryRuleCreation? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCreation value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCreation?(RepositoryRule @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCreation? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// Only allow users with bypass permission to update matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleUpdate? Value2 { get; init; }
#else
        public global::G.RepositoryRuleUpdate? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleUpdate value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleUpdate?(RepositoryRule @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleUpdate? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Only allow users with bypass permissions to delete matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleDeletion? Value3 { get; init; }
#else
        public global::G.RepositoryRuleDeletion? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleDeletion value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleDeletion?(RepositoryRule @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleDeletion? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Prevent merge commits from being pushed to matching refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredLinearHistory? Value4 { get; init; }
#else
        public global::G.RepositoryRuleRequiredLinearHistory? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredLinearHistory value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredLinearHistory?(RepositoryRule @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredLinearHistory? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// Merges must be performed via a merge queue.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleMergeQueue? Value5 { get; init; }
#else
        public global::G.RepositoryRuleMergeQueue? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleMergeQueue value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleMergeQueue?(RepositoryRule @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleMergeQueue? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// Choose which environments must be successfully deployed to before refs can be pushed into a ref that matches this rule.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredDeployments? Value6 { get; init; }
#else
        public global::G.RepositoryRuleRequiredDeployments? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredDeployments value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredDeployments?(RepositoryRule @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredDeployments? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// Commits pushed to matching refs must have verified signatures.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredSignatures? Value7 { get; init; }
#else
        public global::G.RepositoryRuleRequiredSignatures? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredSignatures value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredSignatures?(RepositoryRule @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredSignatures? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// Require all commits be made to a non-target branch and submitted via a pull request before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRulePullRequest? Value8 { get; init; }
#else
        public global::G.RepositoryRulePullRequest? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRulePullRequest value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRulePullRequest?(RepositoryRule @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRulePullRequest? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// Choose which status checks must pass before the ref is updated. When enabled, commits must first be pushed to another ref where the checks pass.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredStatusChecks? Value9 { get; init; }
#else
        public global::G.RepositoryRuleRequiredStatusChecks? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredStatusChecks?(RepositoryRule @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// Prevent users with push access from force pushing to refs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleNonFastForward? Value10 { get; init; }
#else
        public global::G.RepositoryRuleNonFastForward? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleNonFastForward value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleNonFastForward?(RepositoryRule @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleNonFastForward? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_message_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitMessagePattern? Value11 { get; init; }
#else
        public global::G.RepositoryRuleCommitMessagePattern? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitMessagePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitMessagePattern?(RepositoryRule @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitMessagePattern? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// Parameters to be used for the commit_author_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitAuthorEmailPattern? Value12 { get; init; }
#else
        public global::G.RepositoryRuleCommitAuthorEmailPattern? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitAuthorEmailPattern?(RepositoryRule @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// Parameters to be used for the committer_email_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitterEmailPattern? Value13 { get; init; }
#else
        public global::G.RepositoryRuleCommitterEmailPattern? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitterEmailPattern?(RepositoryRule @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// Parameters to be used for the branch_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleBranchNamePattern? Value14 { get; init; }
#else
        public global::G.RepositoryRuleBranchNamePattern? Value14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value14))]
#endif
        public bool IsValue14 => Value14 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleBranchNamePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleBranchNamePattern?(RepositoryRule @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleBranchNamePattern? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// Parameters to be used for the tag_name_pattern rule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleTagNamePattern? Value15 { get; init; }
#else
        public global::G.RepositoryRuleTagNamePattern? Value15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value15))]
#endif
        public bool IsValue15 => Value15 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleTagNamePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleTagNamePattern?(RepositoryRule @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleTagNamePattern? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// Prevent commits that include changes in specified file paths from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant16? Value16 { get; init; }
#else
        public global::G.RepositoryRuleVariant16? Value16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value16))]
#endif
        public bool IsValue16 => Value16 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant16 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant16?(RepositoryRule @this) => @this.Value16;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant16? value)
        {
            Value16 = value;
        }

        /// <summary>
        /// Prevent commits that include file paths that exceed a specified character limit from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant17? Value17 { get; init; }
#else
        public global::G.RepositoryRuleVariant17? Value17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value17))]
#endif
        public bool IsValue17 => Value17 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant17 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant17?(RepositoryRule @this) => @this.Value17;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant17? value)
        {
            Value17 = value;
        }

        /// <summary>
        /// Prevent commits that include files with specified file extensions from being pushed to the commit graph.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant18? Value18 { get; init; }
#else
        public global::G.RepositoryRuleVariant18? Value18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value18))]
#endif
        public bool IsValue18 => Value18 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant18 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant18?(RepositoryRule @this) => @this.Value18;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant18? value)
        {
            Value18 = value;
        }

        /// <summary>
        /// Prevent commits that exceed a specified file size limit from being pushed to the commit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant19? Value19 { get; init; }
#else
        public global::G.RepositoryRuleVariant19? Value19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value19))]
#endif
        public bool IsValue19 => Value19 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant19 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant19?(RepositoryRule @this) => @this.Value19;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant19? value)
        {
            Value19 = value;
        }

        /// <summary>
        /// Require all changes made to a targeted branch to pass the specified workflows before they can be merged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleWorkflows? Value20 { get; init; }
#else
        public global::G.RepositoryRuleWorkflows? Value20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value20))]
#endif
        public bool IsValue20 => Value20 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleWorkflows value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleWorkflows?(RepositoryRule @this) => @this.Value20;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleWorkflows? value)
        {
            Value20 = value;
        }

        /// <summary>
        /// Choose which tools must provide code scanning results before the reference is updated. When configured, code scanning must be enabled and have results for both the commit and the reference being updated.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCodeScanning? Value21 { get; init; }
#else
        public global::G.RepositoryRuleCodeScanning? Value21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value21))]
#endif
        public bool IsValue21 => Value21 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCodeScanning value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCodeScanning?(RepositoryRule @this) => @this.Value21;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCodeScanning? value)
        {
            Value21 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(
            global::G.RepositoryRuleDiscriminatorType? type,
            global::G.RepositoryRuleCreation? value1,
            global::G.RepositoryRuleUpdate? value2,
            global::G.RepositoryRuleDeletion? value3,
            global::G.RepositoryRuleRequiredLinearHistory? value4,
            global::G.RepositoryRuleMergeQueue? value5,
            global::G.RepositoryRuleRequiredDeployments? value6,
            global::G.RepositoryRuleRequiredSignatures? value7,
            global::G.RepositoryRulePullRequest? value8,
            global::G.RepositoryRuleRequiredStatusChecks? value9,
            global::G.RepositoryRuleNonFastForward? value10,
            global::G.RepositoryRuleCommitMessagePattern? value11,
            global::G.RepositoryRuleCommitAuthorEmailPattern? value12,
            global::G.RepositoryRuleCommitterEmailPattern? value13,
            global::G.RepositoryRuleBranchNamePattern? value14,
            global::G.RepositoryRuleTagNamePattern? value15,
            global::G.RepositoryRuleVariant16? value16,
            global::G.RepositoryRuleVariant17? value17,
            global::G.RepositoryRuleVariant18? value18,
            global::G.RepositoryRuleVariant19? value19,
            global::G.RepositoryRuleWorkflows? value20,
            global::G.RepositoryRuleCodeScanning? value21
            )
        {
            Type = type;

            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
            Value14 = value14;
            Value15 = value15;
            Value16 = value16;
            Value17 = value17;
            Value18 = value18;
            Value19 = value19;
            Value20 = value20;
            Value21 = value21;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value21 as object ??
            Value20 as object ??
            Value19 as object ??
            Value18 as object ??
            Value17 as object ??
            Value16 as object ??
            Value15 as object ??
            Value14 as object ??
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && IsValue18 && !IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && IsValue19 && !IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && IsValue20 && !IsValue21 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 && IsValue21;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RepositoryRuleCreation?, TResult>? value1 = null,
            global::System.Func<global::G.RepositoryRuleUpdate?, TResult>? value2 = null,
            global::System.Func<global::G.RepositoryRuleDeletion?, TResult>? value3 = null,
            global::System.Func<global::G.RepositoryRuleRequiredLinearHistory?, TResult>? value4 = null,
            global::System.Func<global::G.RepositoryRuleMergeQueue?, TResult>? value5 = null,
            global::System.Func<global::G.RepositoryRuleRequiredDeployments?, TResult>? value6 = null,
            global::System.Func<global::G.RepositoryRuleRequiredSignatures?, TResult>? value7 = null,
            global::System.Func<global::G.RepositoryRulePullRequest?, TResult>? value8 = null,
            global::System.Func<global::G.RepositoryRuleRequiredStatusChecks?, TResult>? value9 = null,
            global::System.Func<global::G.RepositoryRuleNonFastForward?, TResult>? value10 = null,
            global::System.Func<global::G.RepositoryRuleCommitMessagePattern?, TResult>? value11 = null,
            global::System.Func<global::G.RepositoryRuleCommitAuthorEmailPattern?, TResult>? value12 = null,
            global::System.Func<global::G.RepositoryRuleCommitterEmailPattern?, TResult>? value13 = null,
            global::System.Func<global::G.RepositoryRuleBranchNamePattern?, TResult>? value14 = null,
            global::System.Func<global::G.RepositoryRuleTagNamePattern?, TResult>? value15 = null,
            global::System.Func<global::G.RepositoryRuleVariant16?, TResult>? value16 = null,
            global::System.Func<global::G.RepositoryRuleVariant17?, TResult>? value17 = null,
            global::System.Func<global::G.RepositoryRuleVariant18?, TResult>? value18 = null,
            global::System.Func<global::G.RepositoryRuleVariant19?, TResult>? value19 = null,
            global::System.Func<global::G.RepositoryRuleWorkflows?, TResult>? value20 = null,
            global::System.Func<global::G.RepositoryRuleCodeScanning?, TResult>? value21 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }
            else if (IsValue14 && value14 != null)
            {
                return value14(Value14!);
            }
            else if (IsValue15 && value15 != null)
            {
                return value15(Value15!);
            }
            else if (IsValue16 && value16 != null)
            {
                return value16(Value16!);
            }
            else if (IsValue17 && value17 != null)
            {
                return value17(Value17!);
            }
            else if (IsValue18 && value18 != null)
            {
                return value18(Value18!);
            }
            else if (IsValue19 && value19 != null)
            {
                return value19(Value19!);
            }
            else if (IsValue20 && value20 != null)
            {
                return value20(Value20!);
            }
            else if (IsValue21 && value21 != null)
            {
                return value21(Value21!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RepositoryRuleCreation?>? value1 = null,
            global::System.Action<global::G.RepositoryRuleUpdate?>? value2 = null,
            global::System.Action<global::G.RepositoryRuleDeletion?>? value3 = null,
            global::System.Action<global::G.RepositoryRuleRequiredLinearHistory?>? value4 = null,
            global::System.Action<global::G.RepositoryRuleMergeQueue?>? value5 = null,
            global::System.Action<global::G.RepositoryRuleRequiredDeployments?>? value6 = null,
            global::System.Action<global::G.RepositoryRuleRequiredSignatures?>? value7 = null,
            global::System.Action<global::G.RepositoryRulePullRequest?>? value8 = null,
            global::System.Action<global::G.RepositoryRuleRequiredStatusChecks?>? value9 = null,
            global::System.Action<global::G.RepositoryRuleNonFastForward?>? value10 = null,
            global::System.Action<global::G.RepositoryRuleCommitMessagePattern?>? value11 = null,
            global::System.Action<global::G.RepositoryRuleCommitAuthorEmailPattern?>? value12 = null,
            global::System.Action<global::G.RepositoryRuleCommitterEmailPattern?>? value13 = null,
            global::System.Action<global::G.RepositoryRuleBranchNamePattern?>? value14 = null,
            global::System.Action<global::G.RepositoryRuleTagNamePattern?>? value15 = null,
            global::System.Action<global::G.RepositoryRuleVariant16?>? value16 = null,
            global::System.Action<global::G.RepositoryRuleVariant17?>? value17 = null,
            global::System.Action<global::G.RepositoryRuleVariant18?>? value18 = null,
            global::System.Action<global::G.RepositoryRuleVariant19?>? value19 = null,
            global::System.Action<global::G.RepositoryRuleWorkflows?>? value20 = null,
            global::System.Action<global::G.RepositoryRuleCodeScanning?>? value21 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
            else if (IsValue14)
            {
                value14?.Invoke(Value14!);
            }
            else if (IsValue15)
            {
                value15?.Invoke(Value15!);
            }
            else if (IsValue16)
            {
                value16?.Invoke(Value16!);
            }
            else if (IsValue17)
            {
                value17?.Invoke(Value17!);
            }
            else if (IsValue18)
            {
                value18?.Invoke(Value18!);
            }
            else if (IsValue19)
            {
                value19?.Invoke(Value19!);
            }
            else if (IsValue20)
            {
                value20?.Invoke(Value20!);
            }
            else if (IsValue21)
            {
                value21?.Invoke(Value21!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.RepositoryRuleCreation),
                Value2,
                typeof(global::G.RepositoryRuleUpdate),
                Value3,
                typeof(global::G.RepositoryRuleDeletion),
                Value4,
                typeof(global::G.RepositoryRuleRequiredLinearHistory),
                Value5,
                typeof(global::G.RepositoryRuleMergeQueue),
                Value6,
                typeof(global::G.RepositoryRuleRequiredDeployments),
                Value7,
                typeof(global::G.RepositoryRuleRequiredSignatures),
                Value8,
                typeof(global::G.RepositoryRulePullRequest),
                Value9,
                typeof(global::G.RepositoryRuleRequiredStatusChecks),
                Value10,
                typeof(global::G.RepositoryRuleNonFastForward),
                Value11,
                typeof(global::G.RepositoryRuleCommitMessagePattern),
                Value12,
                typeof(global::G.RepositoryRuleCommitAuthorEmailPattern),
                Value13,
                typeof(global::G.RepositoryRuleCommitterEmailPattern),
                Value14,
                typeof(global::G.RepositoryRuleBranchNamePattern),
                Value15,
                typeof(global::G.RepositoryRuleTagNamePattern),
                Value16,
                typeof(global::G.RepositoryRuleVariant16),
                Value17,
                typeof(global::G.RepositoryRuleVariant17),
                Value18,
                typeof(global::G.RepositoryRuleVariant18),
                Value19,
                typeof(global::G.RepositoryRuleVariant19),
                Value20,
                typeof(global::G.RepositoryRuleWorkflows),
                Value21,
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
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCreation?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleUpdate?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleDeletion?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredLinearHistory?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleMergeQueue?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredDeployments?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredSignatures?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRulePullRequest?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredStatusChecks?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleNonFastForward?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitMessagePattern?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitAuthorEmailPattern?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitterEmailPattern?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleBranchNamePattern?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleTagNamePattern?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant16?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant17?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant18?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant19?>.Default.Equals(Value19, other.Value19) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleWorkflows?>.Default.Equals(Value20, other.Value20) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCodeScanning?>.Default.Equals(Value21, other.Value21) 
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

    }
}
