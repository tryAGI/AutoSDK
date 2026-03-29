//HintName: G.Models.ToolRulesVariant1Item4.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolRulesVariant1Item4 : global::System.IEquatable<ToolRulesVariant1Item4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UpdateAgentToolRulesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A ToolRule represents a tool that can be invoked by the agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChildToolRule? ConstrainChildTools { get; init; }
#else
        public global::G.ChildToolRule? ConstrainChildTools { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConstrainChildTools))]
#endif
        public bool IsConstrainChildTools => ConstrainChildTools != null;

        /// <summary>
        /// Represents the initial tool rule configuration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.InitToolRule? RunFirst { get; init; }
#else
        public global::G.InitToolRule? RunFirst { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunFirst))]
#endif
        public bool IsRunFirst => RunFirst != null;

        /// <summary>
        /// Represents a terminal tool rule configuration where if this tool gets called, it must end the agent loop.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TerminalToolRule? ExitLoop { get; init; }
#else
        public global::G.TerminalToolRule? ExitLoop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExitLoop))]
#endif
        public bool IsExitLoop => ExitLoop != null;

        /// <summary>
        /// A ToolRule that conditionally maps to different child tools based on the output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConditionalToolRule? Conditional { get; init; }
#else
        public global::G.ConditionalToolRule? Conditional { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Conditional))]
#endif
        public bool IsConditional => Conditional != null;

        /// <summary>
        /// Represents a tool rule configuration where if this tool gets called, it must continue the agent loop.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ContinueToolRule? ContinueLoop { get; init; }
#else
        public global::G.ContinueToolRule? ContinueLoop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContinueLoop))]
#endif
        public bool IsContinueLoop => ContinueLoop != null;

        /// <summary>
        /// Represents a tool rule configuration where this tool must be called before the agent loop can exit.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequiredBeforeExitToolRule? RequiredBeforeExit { get; init; }
#else
        public global::G.RequiredBeforeExitToolRule? RequiredBeforeExit { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiredBeforeExit))]
#endif
        public bool IsRequiredBeforeExit => RequiredBeforeExit != null;

        /// <summary>
        /// Represents a tool rule configuration which constrains the total number of times this tool can be invoked in a single step.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MaxCountPerStepToolRule? MaxCountPerStep { get; init; }
#else
        public global::G.MaxCountPerStepToolRule? MaxCountPerStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxCountPerStep))]
#endif
        public bool IsMaxCountPerStep => MaxCountPerStep != null;

        /// <summary>
        /// A ToolRule that only allows a child tool to be called if the parent has been called.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ParentToolRule? ParentLastTool { get; init; }
#else
        public global::G.ParentToolRule? ParentLastTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ParentLastTool))]
#endif
        public bool IsParentLastTool => ParentLastTool != null;

        /// <summary>
        /// Represents a tool rule configuration which requires approval before the tool can be invoked.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RequiresApprovalToolRule? RequiresApproval { get; init; }
#else
        public global::G.RequiresApprovalToolRule? RequiresApproval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequiresApproval))]
#endif
        public bool IsRequiresApproval => RequiresApproval != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.ChildToolRule value) => new ToolRulesVariant1Item4((global::G.ChildToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChildToolRule?(ToolRulesVariant1Item4 @this) => @this.ConstrainChildTools;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.ChildToolRule? value)
        {
            ConstrainChildTools = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.InitToolRule value) => new ToolRulesVariant1Item4((global::G.InitToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InitToolRule?(ToolRulesVariant1Item4 @this) => @this.RunFirst;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.InitToolRule? value)
        {
            RunFirst = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.TerminalToolRule value) => new ToolRulesVariant1Item4((global::G.TerminalToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TerminalToolRule?(ToolRulesVariant1Item4 @this) => @this.ExitLoop;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.TerminalToolRule? value)
        {
            ExitLoop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.ConditionalToolRule value) => new ToolRulesVariant1Item4((global::G.ConditionalToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConditionalToolRule?(ToolRulesVariant1Item4 @this) => @this.Conditional;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.ConditionalToolRule? value)
        {
            Conditional = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.ContinueToolRule value) => new ToolRulesVariant1Item4((global::G.ContinueToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContinueToolRule?(ToolRulesVariant1Item4 @this) => @this.ContinueLoop;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.ContinueToolRule? value)
        {
            ContinueLoop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.RequiredBeforeExitToolRule value) => new ToolRulesVariant1Item4((global::G.RequiredBeforeExitToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequiredBeforeExitToolRule?(ToolRulesVariant1Item4 @this) => @this.RequiredBeforeExit;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.RequiredBeforeExitToolRule? value)
        {
            RequiredBeforeExit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.MaxCountPerStepToolRule value) => new ToolRulesVariant1Item4((global::G.MaxCountPerStepToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MaxCountPerStepToolRule?(ToolRulesVariant1Item4 @this) => @this.MaxCountPerStep;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.MaxCountPerStepToolRule? value)
        {
            MaxCountPerStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.ParentToolRule value) => new ToolRulesVariant1Item4((global::G.ParentToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ParentToolRule?(ToolRulesVariant1Item4 @this) => @this.ParentLastTool;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.ParentToolRule? value)
        {
            ParentLastTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolRulesVariant1Item4(global::G.RequiresApprovalToolRule value) => new ToolRulesVariant1Item4((global::G.RequiresApprovalToolRule?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RequiresApprovalToolRule?(ToolRulesVariant1Item4 @this) => @this.RequiresApproval;

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(global::G.RequiresApprovalToolRule? value)
        {
            RequiresApproval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolRulesVariant1Item4(
            global::G.UpdateAgentToolRulesVariant1ItemDiscriminatorType? type,
            global::G.ChildToolRule? constrainChildTools,
            global::G.InitToolRule? runFirst,
            global::G.TerminalToolRule? exitLoop,
            global::G.ConditionalToolRule? conditional,
            global::G.ContinueToolRule? continueLoop,
            global::G.RequiredBeforeExitToolRule? requiredBeforeExit,
            global::G.MaxCountPerStepToolRule? maxCountPerStep,
            global::G.ParentToolRule? parentLastTool,
            global::G.RequiresApprovalToolRule? requiresApproval
            )
        {
            Type = type;

            ConstrainChildTools = constrainChildTools;
            RunFirst = runFirst;
            ExitLoop = exitLoop;
            Conditional = conditional;
            ContinueLoop = continueLoop;
            RequiredBeforeExit = requiredBeforeExit;
            MaxCountPerStep = maxCountPerStep;
            ParentLastTool = parentLastTool;
            RequiresApproval = requiresApproval;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RequiresApproval as object ??
            ParentLastTool as object ??
            MaxCountPerStep as object ??
            RequiredBeforeExit as object ??
            ContinueLoop as object ??
            Conditional as object ??
            ExitLoop as object ??
            RunFirst as object ??
            ConstrainChildTools as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConstrainChildTools?.ToString() ??
            RunFirst?.ToString() ??
            ExitLoop?.ToString() ??
            Conditional?.ToString() ??
            ContinueLoop?.ToString() ??
            RequiredBeforeExit?.ToString() ??
            MaxCountPerStep?.ToString() ??
            ParentLastTool?.ToString() ??
            RequiresApproval?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && IsMaxCountPerStep && !IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && IsParentLastTool && !IsRequiresApproval || !IsConstrainChildTools && !IsRunFirst && !IsExitLoop && !IsConditional && !IsContinueLoop && !IsRequiredBeforeExit && !IsMaxCountPerStep && !IsParentLastTool && IsRequiresApproval;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChildToolRule?, TResult>? constrainChildTools = null,
            global::System.Func<global::G.InitToolRule?, TResult>? runFirst = null,
            global::System.Func<global::G.TerminalToolRule?, TResult>? exitLoop = null,
            global::System.Func<global::G.ConditionalToolRule?, TResult>? conditional = null,
            global::System.Func<global::G.ContinueToolRule?, TResult>? continueLoop = null,
            global::System.Func<global::G.RequiredBeforeExitToolRule?, TResult>? requiredBeforeExit = null,
            global::System.Func<global::G.MaxCountPerStepToolRule?, TResult>? maxCountPerStep = null,
            global::System.Func<global::G.ParentToolRule?, TResult>? parentLastTool = null,
            global::System.Func<global::G.RequiresApprovalToolRule?, TResult>? requiresApproval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstrainChildTools && constrainChildTools != null)
            {
                return constrainChildTools(ConstrainChildTools!);
            }
            else if (IsRunFirst && runFirst != null)
            {
                return runFirst(RunFirst!);
            }
            else if (IsExitLoop && exitLoop != null)
            {
                return exitLoop(ExitLoop!);
            }
            else if (IsConditional && conditional != null)
            {
                return conditional(Conditional!);
            }
            else if (IsContinueLoop && continueLoop != null)
            {
                return continueLoop(ContinueLoop!);
            }
            else if (IsRequiredBeforeExit && requiredBeforeExit != null)
            {
                return requiredBeforeExit(RequiredBeforeExit!);
            }
            else if (IsMaxCountPerStep && maxCountPerStep != null)
            {
                return maxCountPerStep(MaxCountPerStep!);
            }
            else if (IsParentLastTool && parentLastTool != null)
            {
                return parentLastTool(ParentLastTool!);
            }
            else if (IsRequiresApproval && requiresApproval != null)
            {
                return requiresApproval(RequiresApproval!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChildToolRule?>? constrainChildTools = null,
            global::System.Action<global::G.InitToolRule?>? runFirst = null,
            global::System.Action<global::G.TerminalToolRule?>? exitLoop = null,
            global::System.Action<global::G.ConditionalToolRule?>? conditional = null,
            global::System.Action<global::G.ContinueToolRule?>? continueLoop = null,
            global::System.Action<global::G.RequiredBeforeExitToolRule?>? requiredBeforeExit = null,
            global::System.Action<global::G.MaxCountPerStepToolRule?>? maxCountPerStep = null,
            global::System.Action<global::G.ParentToolRule?>? parentLastTool = null,
            global::System.Action<global::G.RequiresApprovalToolRule?>? requiresApproval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstrainChildTools)
            {
                constrainChildTools?.Invoke(ConstrainChildTools!);
            }
            else if (IsRunFirst)
            {
                runFirst?.Invoke(RunFirst!);
            }
            else if (IsExitLoop)
            {
                exitLoop?.Invoke(ExitLoop!);
            }
            else if (IsConditional)
            {
                conditional?.Invoke(Conditional!);
            }
            else if (IsContinueLoop)
            {
                continueLoop?.Invoke(ContinueLoop!);
            }
            else if (IsRequiredBeforeExit)
            {
                requiredBeforeExit?.Invoke(RequiredBeforeExit!);
            }
            else if (IsMaxCountPerStep)
            {
                maxCountPerStep?.Invoke(MaxCountPerStep!);
            }
            else if (IsParentLastTool)
            {
                parentLastTool?.Invoke(ParentLastTool!);
            }
            else if (IsRequiresApproval)
            {
                requiresApproval?.Invoke(RequiresApproval!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConstrainChildTools,
                typeof(global::G.ChildToolRule),
                RunFirst,
                typeof(global::G.InitToolRule),
                ExitLoop,
                typeof(global::G.TerminalToolRule),
                Conditional,
                typeof(global::G.ConditionalToolRule),
                ContinueLoop,
                typeof(global::G.ContinueToolRule),
                RequiredBeforeExit,
                typeof(global::G.RequiredBeforeExitToolRule),
                MaxCountPerStep,
                typeof(global::G.MaxCountPerStepToolRule),
                ParentLastTool,
                typeof(global::G.ParentToolRule),
                RequiresApproval,
                typeof(global::G.RequiresApprovalToolRule),
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
        public bool Equals(ToolRulesVariant1Item4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChildToolRule?>.Default.Equals(ConstrainChildTools, other.ConstrainChildTools) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InitToolRule?>.Default.Equals(RunFirst, other.RunFirst) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TerminalToolRule?>.Default.Equals(ExitLoop, other.ExitLoop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConditionalToolRule?>.Default.Equals(Conditional, other.Conditional) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContinueToolRule?>.Default.Equals(ContinueLoop, other.ContinueLoop) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequiredBeforeExitToolRule?>.Default.Equals(RequiredBeforeExit, other.RequiredBeforeExit) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MaxCountPerStepToolRule?>.Default.Equals(MaxCountPerStep, other.MaxCountPerStep) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ParentToolRule?>.Default.Equals(ParentLastTool, other.ParentLastTool) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RequiresApprovalToolRule?>.Default.Equals(RequiresApproval, other.RequiresApproval) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolRulesVariant1Item4 obj1, ToolRulesVariant1Item4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolRulesVariant1Item4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolRulesVariant1Item4 obj1, ToolRulesVariant1Item4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolRulesVariant1Item4 o && Equals(o);
        }
    }
}
