//HintName: G.Models.RepositoryRule.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A repository rule.
    /// </summary>
    public readonly struct RepositoryRule : global::System.IEquatable<RepositoryRule>
    {
        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredDeployments? Value5 { get; init; }
#else
        public global::G.RepositoryRuleRequiredDeployments? Value5 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredDeployments value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredDeployments?(RepositoryRule @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredDeployments? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredSignatures? Value6 { get; init; }
#else
        public global::G.RepositoryRuleRequiredSignatures? Value6 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredSignatures value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredSignatures?(RepositoryRule @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredSignatures? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRulePullRequest? Value7 { get; init; }
#else
        public global::G.RepositoryRulePullRequest? Value7 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRulePullRequest value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRulePullRequest?(RepositoryRule @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRulePullRequest? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleRequiredStatusChecks? Value8 { get; init; }
#else
        public global::G.RepositoryRuleRequiredStatusChecks? Value8 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleRequiredStatusChecks?(RepositoryRule @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleRequiredStatusChecks? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleNonFastForward? Value9 { get; init; }
#else
        public global::G.RepositoryRuleNonFastForward? Value9 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleNonFastForward value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleNonFastForward?(RepositoryRule @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleNonFastForward? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitMessagePattern? Value10 { get; init; }
#else
        public global::G.RepositoryRuleCommitMessagePattern? Value10 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitMessagePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitMessagePattern?(RepositoryRule @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitMessagePattern? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitAuthorEmailPattern? Value11 { get; init; }
#else
        public global::G.RepositoryRuleCommitAuthorEmailPattern? Value11 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitAuthorEmailPattern?(RepositoryRule @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitAuthorEmailPattern? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCommitterEmailPattern? Value12 { get; init; }
#else
        public global::G.RepositoryRuleCommitterEmailPattern? Value12 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCommitterEmailPattern?(RepositoryRule @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCommitterEmailPattern? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleBranchNamePattern? Value13 { get; init; }
#else
        public global::G.RepositoryRuleBranchNamePattern? Value13 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleBranchNamePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleBranchNamePattern?(RepositoryRule @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleBranchNamePattern? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleTagNamePattern? Value14 { get; init; }
#else
        public global::G.RepositoryRuleTagNamePattern? Value14 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleTagNamePattern value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleTagNamePattern?(RepositoryRule @this) => @this.Value14;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleTagNamePattern? value)
        {
            Value14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleVariant15? Value15 { get; init; }
#else
        public global::G.RepositoryRuleVariant15? Value15 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleVariant15 value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleVariant15?(RepositoryRule @this) => @this.Value15;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleVariant15? value)
        {
            Value15 = value;
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleWorkflows? Value19 { get; init; }
#else
        public global::G.RepositoryRuleWorkflows? Value19 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleWorkflows value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleWorkflows?(RepositoryRule @this) => @this.Value19;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleWorkflows? value)
        {
            Value19 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RepositoryRuleCodeScanning? Value20 { get; init; }
#else
        public global::G.RepositoryRuleCodeScanning? Value20 { get; }
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
        public static implicit operator RepositoryRule(global::G.RepositoryRuleCodeScanning value) => new RepositoryRule(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RepositoryRuleCodeScanning?(RepositoryRule @this) => @this.Value20;

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(global::G.RepositoryRuleCodeScanning? value)
        {
            Value20 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RepositoryRule(
            global::G.RepositoryRuleCreation? value1,
            global::G.RepositoryRuleUpdate? value2,
            global::G.RepositoryRuleDeletion? value3,
            global::G.RepositoryRuleRequiredLinearHistory? value4,
            global::G.RepositoryRuleRequiredDeployments? value5,
            global::G.RepositoryRuleRequiredSignatures? value6,
            global::G.RepositoryRulePullRequest? value7,
            global::G.RepositoryRuleRequiredStatusChecks? value8,
            global::G.RepositoryRuleNonFastForward? value9,
            global::G.RepositoryRuleCommitMessagePattern? value10,
            global::G.RepositoryRuleCommitAuthorEmailPattern? value11,
            global::G.RepositoryRuleCommitterEmailPattern? value12,
            global::G.RepositoryRuleBranchNamePattern? value13,
            global::G.RepositoryRuleTagNamePattern? value14,
            global::G.RepositoryRuleVariant15? value15,
            global::G.RepositoryRuleVariant16? value16,
            global::G.RepositoryRuleVariant17? value17,
            global::G.RepositoryRuleVariant18? value18,
            global::G.RepositoryRuleWorkflows? value19,
            global::G.RepositoryRuleCodeScanning? value20
            )
        {
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && IsValue17 && !IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && IsValue18 && !IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && IsValue19 && !IsValue20 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 && !IsValue14 && !IsValue15 && !IsValue16 && !IsValue17 && !IsValue18 && !IsValue19 && IsValue20;
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
                typeof(global::G.RepositoryRuleRequiredDeployments),
                Value6,
                typeof(global::G.RepositoryRuleRequiredSignatures),
                Value7,
                typeof(global::G.RepositoryRulePullRequest),
                Value8,
                typeof(global::G.RepositoryRuleRequiredStatusChecks),
                Value9,
                typeof(global::G.RepositoryRuleNonFastForward),
                Value10,
                typeof(global::G.RepositoryRuleCommitMessagePattern),
                Value11,
                typeof(global::G.RepositoryRuleCommitAuthorEmailPattern),
                Value12,
                typeof(global::G.RepositoryRuleCommitterEmailPattern),
                Value13,
                typeof(global::G.RepositoryRuleBranchNamePattern),
                Value14,
                typeof(global::G.RepositoryRuleTagNamePattern),
                Value15,
                typeof(global::G.RepositoryRuleVariant15),
                Value16,
                typeof(global::G.RepositoryRuleVariant16),
                Value17,
                typeof(global::G.RepositoryRuleVariant17),
                Value18,
                typeof(global::G.RepositoryRuleVariant18),
                Value19,
                typeof(global::G.RepositoryRuleWorkflows),
                Value20,
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
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredDeployments?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredSignatures?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRulePullRequest?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleRequiredStatusChecks?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleNonFastForward?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitMessagePattern?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitAuthorEmailPattern?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCommitterEmailPattern?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleBranchNamePattern?>.Default.Equals(Value13, other.Value13) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleTagNamePattern?>.Default.Equals(Value14, other.Value14) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant15?>.Default.Equals(Value15, other.Value15) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant16?>.Default.Equals(Value16, other.Value16) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant17?>.Default.Equals(Value17, other.Value17) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleVariant18?>.Default.Equals(Value18, other.Value18) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleWorkflows?>.Default.Equals(Value19, other.Value19) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RepositoryRuleCodeScanning?>.Default.Equals(Value20, other.Value20) 
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
