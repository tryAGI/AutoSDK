//HintName: G.Models.RepositoryRuleDetailed.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A repository rule with ruleset details.
    /// </summary>
    public readonly partial struct RepositoryRuleDetailed : global::System.IEquatable<RepositoryRuleDetailed>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant1 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant1))]
#endif
        public bool IsRepositoryRuleDetailedVariant1 => RepositoryRuleDetailedVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant2))]
#endif
        public bool IsRepositoryRuleDetailedVariant2 => RepositoryRuleDetailedVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant3 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant3))]
#endif
        public bool IsRepositoryRuleDetailedVariant3 => RepositoryRuleDetailedVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant4 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant4))]
#endif
        public bool IsRepositoryRuleDetailedVariant4 => RepositoryRuleDetailedVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant5 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant5))]
#endif
        public bool IsRepositoryRuleDetailedVariant5 => RepositoryRuleDetailedVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant6 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant6))]
#endif
        public bool IsRepositoryRuleDetailedVariant6 => RepositoryRuleDetailedVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant7 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant7))]
#endif
        public bool IsRepositoryRuleDetailedVariant7 => RepositoryRuleDetailedVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant8 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant8))]
#endif
        public bool IsRepositoryRuleDetailedVariant8 => RepositoryRuleDetailedVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant9 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant9))]
#endif
        public bool IsRepositoryRuleDetailedVariant9 => RepositoryRuleDetailedVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant10 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant10))]
#endif
        public bool IsRepositoryRuleDetailedVariant10 => RepositoryRuleDetailedVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant11 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant11))]
#endif
        public bool IsRepositoryRuleDetailedVariant11 => RepositoryRuleDetailedVariant11 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant12 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant12))]
#endif
        public bool IsRepositoryRuleDetailedVariant12 => RepositoryRuleDetailedVariant12 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant13 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant13))]
#endif
        public bool IsRepositoryRuleDetailedVariant13 => RepositoryRuleDetailedVariant13 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant14 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant14))]
#endif
        public bool IsRepositoryRuleDetailedVariant14 => RepositoryRuleDetailedVariant14 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant15 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant15))]
#endif
        public bool IsRepositoryRuleDetailedVariant15 => RepositoryRuleDetailedVariant15 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant16 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant16))]
#endif
        public bool IsRepositoryRuleDetailedVariant16 => RepositoryRuleDetailedVariant16 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant17 { get; init; }
#else
        public global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? RepositoryRuleDetailedVariant17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepositoryRuleDetailedVariant17))]
#endif
        public bool IsRepositoryRuleDetailedVariant17 => RepositoryRuleDetailedVariant17 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant3;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant4;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant5;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant6;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant7;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant8;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant9;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant10;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant11;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant12;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant13;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant14;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant15;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant16;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo> value) => new RepositoryRuleDetailed((global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>?(RepositoryRuleDetailed @this) => @this.RepositoryRuleDetailedVariant17;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? value)
        {
            RepositoryRuleDetailedVariant17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRuleDetailed(
            global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant1,
            global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant2,
            global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant3,
            global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant4,
            global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant5,
            global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant6,
            global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant7,
            global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant8,
            global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant9,
            global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant10,
            global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant11,
            global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant12,
            global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant13,
            global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant14,
            global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant15,
            global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant16,
            global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>? repositoryRuleDetailedVariant17
            )
        {
            RepositoryRuleDetailedVariant1 = repositoryRuleDetailedVariant1;
            RepositoryRuleDetailedVariant2 = repositoryRuleDetailedVariant2;
            RepositoryRuleDetailedVariant3 = repositoryRuleDetailedVariant3;
            RepositoryRuleDetailedVariant4 = repositoryRuleDetailedVariant4;
            RepositoryRuleDetailedVariant5 = repositoryRuleDetailedVariant5;
            RepositoryRuleDetailedVariant6 = repositoryRuleDetailedVariant6;
            RepositoryRuleDetailedVariant7 = repositoryRuleDetailedVariant7;
            RepositoryRuleDetailedVariant8 = repositoryRuleDetailedVariant8;
            RepositoryRuleDetailedVariant9 = repositoryRuleDetailedVariant9;
            RepositoryRuleDetailedVariant10 = repositoryRuleDetailedVariant10;
            RepositoryRuleDetailedVariant11 = repositoryRuleDetailedVariant11;
            RepositoryRuleDetailedVariant12 = repositoryRuleDetailedVariant12;
            RepositoryRuleDetailedVariant13 = repositoryRuleDetailedVariant13;
            RepositoryRuleDetailedVariant14 = repositoryRuleDetailedVariant14;
            RepositoryRuleDetailedVariant15 = repositoryRuleDetailedVariant15;
            RepositoryRuleDetailedVariant16 = repositoryRuleDetailedVariant16;
            RepositoryRuleDetailedVariant17 = repositoryRuleDetailedVariant17;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RepositoryRuleDetailedVariant17 as object ??
            RepositoryRuleDetailedVariant16 as object ??
            RepositoryRuleDetailedVariant15 as object ??
            RepositoryRuleDetailedVariant14 as object ??
            RepositoryRuleDetailedVariant13 as object ??
            RepositoryRuleDetailedVariant12 as object ??
            RepositoryRuleDetailedVariant11 as object ??
            RepositoryRuleDetailedVariant10 as object ??
            RepositoryRuleDetailedVariant9 as object ??
            RepositoryRuleDetailedVariant8 as object ??
            RepositoryRuleDetailedVariant7 as object ??
            RepositoryRuleDetailedVariant6 as object ??
            RepositoryRuleDetailedVariant5 as object ??
            RepositoryRuleDetailedVariant4 as object ??
            RepositoryRuleDetailedVariant3 as object ??
            RepositoryRuleDetailedVariant2 as object ??
            RepositoryRuleDetailedVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RepositoryRuleDetailedVariant1?.ToString() ??
            RepositoryRuleDetailedVariant2?.ToString() ??
            RepositoryRuleDetailedVariant3?.ToString() ??
            RepositoryRuleDetailedVariant4?.ToString() ??
            RepositoryRuleDetailedVariant5?.ToString() ??
            RepositoryRuleDetailedVariant6?.ToString() ??
            RepositoryRuleDetailedVariant7?.ToString() ??
            RepositoryRuleDetailedVariant8?.ToString() ??
            RepositoryRuleDetailedVariant9?.ToString() ??
            RepositoryRuleDetailedVariant10?.ToString() ??
            RepositoryRuleDetailedVariant11?.ToString() ??
            RepositoryRuleDetailedVariant12?.ToString() ??
            RepositoryRuleDetailedVariant13?.ToString() ??
            RepositoryRuleDetailedVariant14?.ToString() ??
            RepositoryRuleDetailedVariant15?.ToString() ??
            RepositoryRuleDetailedVariant16?.ToString() ??
            RepositoryRuleDetailedVariant17?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && IsRepositoryRuleDetailedVariant16 && !IsRepositoryRuleDetailedVariant17 || !IsRepositoryRuleDetailedVariant1 && !IsRepositoryRuleDetailedVariant2 && !IsRepositoryRuleDetailedVariant3 && !IsRepositoryRuleDetailedVariant4 && !IsRepositoryRuleDetailedVariant5 && !IsRepositoryRuleDetailedVariant6 && !IsRepositoryRuleDetailedVariant7 && !IsRepositoryRuleDetailedVariant8 && !IsRepositoryRuleDetailedVariant9 && !IsRepositoryRuleDetailedVariant10 && !IsRepositoryRuleDetailedVariant11 && !IsRepositoryRuleDetailedVariant12 && !IsRepositoryRuleDetailedVariant13 && !IsRepositoryRuleDetailedVariant14 && !IsRepositoryRuleDetailedVariant15 && !IsRepositoryRuleDetailedVariant16 && IsRepositoryRuleDetailedVariant17;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant2 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant3 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant4 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant5 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant6 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant7 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant8 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant9 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant10 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant11 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant12 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant13 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant14 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant15 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant16 = null,
            global::System.Func<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>?, TResult>? repositoryRuleDetailedVariant17 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleDetailedVariant1 && repositoryRuleDetailedVariant1 != null)
            {
                return repositoryRuleDetailedVariant1(RepositoryRuleDetailedVariant1!);
            }
            else if (IsRepositoryRuleDetailedVariant2 && repositoryRuleDetailedVariant2 != null)
            {
                return repositoryRuleDetailedVariant2(RepositoryRuleDetailedVariant2!);
            }
            else if (IsRepositoryRuleDetailedVariant3 && repositoryRuleDetailedVariant3 != null)
            {
                return repositoryRuleDetailedVariant3(RepositoryRuleDetailedVariant3!);
            }
            else if (IsRepositoryRuleDetailedVariant4 && repositoryRuleDetailedVariant4 != null)
            {
                return repositoryRuleDetailedVariant4(RepositoryRuleDetailedVariant4!);
            }
            else if (IsRepositoryRuleDetailedVariant5 && repositoryRuleDetailedVariant5 != null)
            {
                return repositoryRuleDetailedVariant5(RepositoryRuleDetailedVariant5!);
            }
            else if (IsRepositoryRuleDetailedVariant6 && repositoryRuleDetailedVariant6 != null)
            {
                return repositoryRuleDetailedVariant6(RepositoryRuleDetailedVariant6!);
            }
            else if (IsRepositoryRuleDetailedVariant7 && repositoryRuleDetailedVariant7 != null)
            {
                return repositoryRuleDetailedVariant7(RepositoryRuleDetailedVariant7!);
            }
            else if (IsRepositoryRuleDetailedVariant8 && repositoryRuleDetailedVariant8 != null)
            {
                return repositoryRuleDetailedVariant8(RepositoryRuleDetailedVariant8!);
            }
            else if (IsRepositoryRuleDetailedVariant9 && repositoryRuleDetailedVariant9 != null)
            {
                return repositoryRuleDetailedVariant9(RepositoryRuleDetailedVariant9!);
            }
            else if (IsRepositoryRuleDetailedVariant10 && repositoryRuleDetailedVariant10 != null)
            {
                return repositoryRuleDetailedVariant10(RepositoryRuleDetailedVariant10!);
            }
            else if (IsRepositoryRuleDetailedVariant11 && repositoryRuleDetailedVariant11 != null)
            {
                return repositoryRuleDetailedVariant11(RepositoryRuleDetailedVariant11!);
            }
            else if (IsRepositoryRuleDetailedVariant12 && repositoryRuleDetailedVariant12 != null)
            {
                return repositoryRuleDetailedVariant12(RepositoryRuleDetailedVariant12!);
            }
            else if (IsRepositoryRuleDetailedVariant13 && repositoryRuleDetailedVariant13 != null)
            {
                return repositoryRuleDetailedVariant13(RepositoryRuleDetailedVariant13!);
            }
            else if (IsRepositoryRuleDetailedVariant14 && repositoryRuleDetailedVariant14 != null)
            {
                return repositoryRuleDetailedVariant14(RepositoryRuleDetailedVariant14!);
            }
            else if (IsRepositoryRuleDetailedVariant15 && repositoryRuleDetailedVariant15 != null)
            {
                return repositoryRuleDetailedVariant15(RepositoryRuleDetailedVariant15!);
            }
            else if (IsRepositoryRuleDetailedVariant16 && repositoryRuleDetailedVariant16 != null)
            {
                return repositoryRuleDetailedVariant16(RepositoryRuleDetailedVariant16!);
            }
            else if (IsRepositoryRuleDetailedVariant17 && repositoryRuleDetailedVariant17 != null)
            {
                return repositoryRuleDetailedVariant17(RepositoryRuleDetailedVariant17!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant2 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant3 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant4 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant5 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant6 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant7 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant8 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant9 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant10 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant11 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant12 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant13 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant14 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant15 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant16 = null,
            global::System.Action<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>?>? repositoryRuleDetailedVariant17 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRepositoryRuleDetailedVariant1)
            {
                repositoryRuleDetailedVariant1?.Invoke(RepositoryRuleDetailedVariant1!);
            }
            else if (IsRepositoryRuleDetailedVariant2)
            {
                repositoryRuleDetailedVariant2?.Invoke(RepositoryRuleDetailedVariant2!);
            }
            else if (IsRepositoryRuleDetailedVariant3)
            {
                repositoryRuleDetailedVariant3?.Invoke(RepositoryRuleDetailedVariant3!);
            }
            else if (IsRepositoryRuleDetailedVariant4)
            {
                repositoryRuleDetailedVariant4?.Invoke(RepositoryRuleDetailedVariant4!);
            }
            else if (IsRepositoryRuleDetailedVariant5)
            {
                repositoryRuleDetailedVariant5?.Invoke(RepositoryRuleDetailedVariant5!);
            }
            else if (IsRepositoryRuleDetailedVariant6)
            {
                repositoryRuleDetailedVariant6?.Invoke(RepositoryRuleDetailedVariant6!);
            }
            else if (IsRepositoryRuleDetailedVariant7)
            {
                repositoryRuleDetailedVariant7?.Invoke(RepositoryRuleDetailedVariant7!);
            }
            else if (IsRepositoryRuleDetailedVariant8)
            {
                repositoryRuleDetailedVariant8?.Invoke(RepositoryRuleDetailedVariant8!);
            }
            else if (IsRepositoryRuleDetailedVariant9)
            {
                repositoryRuleDetailedVariant9?.Invoke(RepositoryRuleDetailedVariant9!);
            }
            else if (IsRepositoryRuleDetailedVariant10)
            {
                repositoryRuleDetailedVariant10?.Invoke(RepositoryRuleDetailedVariant10!);
            }
            else if (IsRepositoryRuleDetailedVariant11)
            {
                repositoryRuleDetailedVariant11?.Invoke(RepositoryRuleDetailedVariant11!);
            }
            else if (IsRepositoryRuleDetailedVariant12)
            {
                repositoryRuleDetailedVariant12?.Invoke(RepositoryRuleDetailedVariant12!);
            }
            else if (IsRepositoryRuleDetailedVariant13)
            {
                repositoryRuleDetailedVariant13?.Invoke(RepositoryRuleDetailedVariant13!);
            }
            else if (IsRepositoryRuleDetailedVariant14)
            {
                repositoryRuleDetailedVariant14?.Invoke(RepositoryRuleDetailedVariant14!);
            }
            else if (IsRepositoryRuleDetailedVariant15)
            {
                repositoryRuleDetailedVariant15?.Invoke(RepositoryRuleDetailedVariant15!);
            }
            else if (IsRepositoryRuleDetailedVariant16)
            {
                repositoryRuleDetailedVariant16?.Invoke(RepositoryRuleDetailedVariant16!);
            }
            else if (IsRepositoryRuleDetailedVariant17)
            {
                repositoryRuleDetailedVariant17?.Invoke(RepositoryRuleDetailedVariant17!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RepositoryRuleDetailedVariant1,
                typeof(global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant2,
                typeof(global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant3,
                typeof(global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant4,
                typeof(global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant5,
                typeof(global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant6,
                typeof(global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant7,
                typeof(global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant8,
                typeof(global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant9,
                typeof(global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant10,
                typeof(global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant11,
                typeof(global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant12,
                typeof(global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant13,
                typeof(global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant14,
                typeof(global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant15,
                typeof(global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant16,
                typeof(global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>),
                RepositoryRuleDetailedVariant17,
                typeof(global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>),
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
        public bool Equals(RepositoryRuleDetailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleCreation, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant1, other.RepositoryRuleDetailedVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleUpdate, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant2, other.RepositoryRuleDetailedVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleDeletion, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant3, other.RepositoryRuleDetailedVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleRequiredLinearHistory, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant4, other.RepositoryRuleDetailedVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleMergeQueue, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant5, other.RepositoryRuleDetailedVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleRequiredDeployments, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant6, other.RepositoryRuleDetailedVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleRequiredSignatures, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant7, other.RepositoryRuleDetailedVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRulePullRequest, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant8, other.RepositoryRuleDetailedVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleRequiredStatusChecks, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant9, other.RepositoryRuleDetailedVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleNonFastForward, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant10, other.RepositoryRuleDetailedVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleCommitMessagePattern, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant11, other.RepositoryRuleDetailedVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleCommitAuthorEmailPattern, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant12, other.RepositoryRuleDetailedVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleCommitterEmailPattern, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant13, other.RepositoryRuleDetailedVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleBranchNamePattern, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant14, other.RepositoryRuleDetailedVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleTagNamePattern, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant15, other.RepositoryRuleDetailedVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleWorkflows, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant16, other.RepositoryRuleDetailedVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.RepositoryRuleCodeScanning, global::G.RepositoryRuleRulesetInfo>?>.Default.Equals(RepositoryRuleDetailedVariant17, other.RepositoryRuleDetailedVariant17) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RepositoryRuleDetailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RepositoryRuleDetailed obj1, RepositoryRuleDetailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RepositoryRuleDetailed o && Equals(o);
        }
    }
}
