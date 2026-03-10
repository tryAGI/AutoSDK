//HintName: G.Models.Nodes.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Nodes : global::System.IEquatable<Nodes>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentWorkflowRequestModelNodesDiscriminatorType? Type { get; }

        /// <summary>
        /// Entry point of the workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowStartNodeModelInput? Start { get; init; }
#else
        public global::G.WorkflowStartNodeModelInput? Start { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Start))]
#endif
        public bool IsStart => Start != null;

        /// <summary>
        /// Terminates the conversation upon reaching this node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowEndNodeModelInput? End { get; init; }
#else
        public global::G.WorkflowEndNodeModelInput? End { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(End))]
#endif
        public bool IsEnd => End != null;

        /// <summary>
        /// Transfers the conversation to a phone number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowPhoneNumberNodeModelInput? PhoneNumber { get; init; }
#else
        public global::G.WorkflowPhoneNumberNodeModelInput? PhoneNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhoneNumber))]
#endif
        public bool IsPhoneNumber => PhoneNumber != null;

        /// <summary>
        /// A subagent conducting the conversation until one of the exit conditions is met. Each subagent can override the base settings, changing the prompt, knowledge base, and more.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowOverrideAgentNodeModelInput? OverrideAgent { get; init; }
#else
        public global::G.WorkflowOverrideAgentNodeModelInput? OverrideAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OverrideAgent))]
#endif
        public bool IsOverrideAgent => OverrideAgent != null;

        /// <summary>
        /// Transfer the conversation to a standalone agent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowStandaloneAgentNodeModelInput? StandaloneAgent { get; init; }
#else
        public global::G.WorkflowStandaloneAgentNodeModelInput? StandaloneAgent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StandaloneAgent))]
#endif
        public bool IsStandaloneAgent => StandaloneAgent != null;

        /// <summary>
        /// Executes one or more tools in parallel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowToolNodeModelInput? Tool { get; init; }
#else
        public global::G.WorkflowToolNodeModelInput? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes(global::G.WorkflowStartNodeModelInput value) => new Nodes((global::G.WorkflowStartNodeModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowStartNodeModelInput?(Nodes @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public Nodes(global::G.WorkflowStartNodeModelInput? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes(global::G.WorkflowEndNodeModelInput value) => new Nodes((global::G.WorkflowEndNodeModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowEndNodeModelInput?(Nodes @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public Nodes(global::G.WorkflowEndNodeModelInput? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes(global::G.WorkflowPhoneNumberNodeModelInput value) => new Nodes((global::G.WorkflowPhoneNumberNodeModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowPhoneNumberNodeModelInput?(Nodes @this) => @this.PhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public Nodes(global::G.WorkflowPhoneNumberNodeModelInput? value)
        {
            PhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes(global::G.WorkflowOverrideAgentNodeModelInput value) => new Nodes((global::G.WorkflowOverrideAgentNodeModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowOverrideAgentNodeModelInput?(Nodes @this) => @this.OverrideAgent;

        /// <summary>
        /// 
        /// </summary>
        public Nodes(global::G.WorkflowOverrideAgentNodeModelInput? value)
        {
            OverrideAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes(global::G.WorkflowStandaloneAgentNodeModelInput value) => new Nodes((global::G.WorkflowStandaloneAgentNodeModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowStandaloneAgentNodeModelInput?(Nodes @this) => @this.StandaloneAgent;

        /// <summary>
        /// 
        /// </summary>
        public Nodes(global::G.WorkflowStandaloneAgentNodeModelInput? value)
        {
            StandaloneAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes(global::G.WorkflowToolNodeModelInput value) => new Nodes((global::G.WorkflowToolNodeModelInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolNodeModelInput?(Nodes @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Nodes(global::G.WorkflowToolNodeModelInput? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Nodes(
            global::G.AgentWorkflowRequestModelNodesDiscriminatorType? type,
            global::G.WorkflowStartNodeModelInput? start,
            global::G.WorkflowEndNodeModelInput? end,
            global::G.WorkflowPhoneNumberNodeModelInput? phoneNumber,
            global::G.WorkflowOverrideAgentNodeModelInput? overrideAgent,
            global::G.WorkflowStandaloneAgentNodeModelInput? standaloneAgent,
            global::G.WorkflowToolNodeModelInput? tool
            )
        {
            Type = type;

            Start = start;
            End = end;
            PhoneNumber = phoneNumber;
            OverrideAgent = overrideAgent;
            StandaloneAgent = standaloneAgent;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            StandaloneAgent as object ??
            OverrideAgent as object ??
            PhoneNumber as object ??
            End as object ??
            Start as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Start?.ToString() ??
            End?.ToString() ??
            PhoneNumber?.ToString() ??
            OverrideAgent?.ToString() ??
            StandaloneAgent?.ToString() ??
            Tool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && !IsPhoneNumber && IsOverrideAgent && !IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && IsStandaloneAgent && !IsTool || !IsStart && !IsEnd && !IsPhoneNumber && !IsOverrideAgent && !IsStandaloneAgent && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.WorkflowStartNodeModelInput?, TResult>? start = null,
            global::System.Func<global::G.WorkflowEndNodeModelInput?, TResult>? end = null,
            global::System.Func<global::G.WorkflowPhoneNumberNodeModelInput?, TResult>? phoneNumber = null,
            global::System.Func<global::G.WorkflowOverrideAgentNodeModelInput?, TResult>? overrideAgent = null,
            global::System.Func<global::G.WorkflowStandaloneAgentNodeModelInput?, TResult>? standaloneAgent = null,
            global::System.Func<global::G.WorkflowToolNodeModelInput?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart && start != null)
            {
                return start(Start!);
            }
            else if (IsEnd && end != null)
            {
                return end(End!);
            }
            else if (IsPhoneNumber && phoneNumber != null)
            {
                return phoneNumber(PhoneNumber!);
            }
            else if (IsOverrideAgent && overrideAgent != null)
            {
                return overrideAgent(OverrideAgent!);
            }
            else if (IsStandaloneAgent && standaloneAgent != null)
            {
                return standaloneAgent(StandaloneAgent!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.WorkflowStartNodeModelInput?>? start = null,
            global::System.Action<global::G.WorkflowEndNodeModelInput?>? end = null,
            global::System.Action<global::G.WorkflowPhoneNumberNodeModelInput?>? phoneNumber = null,
            global::System.Action<global::G.WorkflowOverrideAgentNodeModelInput?>? overrideAgent = null,
            global::System.Action<global::G.WorkflowStandaloneAgentNodeModelInput?>? standaloneAgent = null,
            global::System.Action<global::G.WorkflowToolNodeModelInput?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsEnd)
            {
                end?.Invoke(End!);
            }
            else if (IsPhoneNumber)
            {
                phoneNumber?.Invoke(PhoneNumber!);
            }
            else if (IsOverrideAgent)
            {
                overrideAgent?.Invoke(OverrideAgent!);
            }
            else if (IsStandaloneAgent)
            {
                standaloneAgent?.Invoke(StandaloneAgent!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Start,
                typeof(global::G.WorkflowStartNodeModelInput),
                End,
                typeof(global::G.WorkflowEndNodeModelInput),
                PhoneNumber,
                typeof(global::G.WorkflowPhoneNumberNodeModelInput),
                OverrideAgent,
                typeof(global::G.WorkflowOverrideAgentNodeModelInput),
                StandaloneAgent,
                typeof(global::G.WorkflowStandaloneAgentNodeModelInput),
                Tool,
                typeof(global::G.WorkflowToolNodeModelInput),
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
        public bool Equals(Nodes other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowStartNodeModelInput?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowEndNodeModelInput?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowPhoneNumberNodeModelInput?>.Default.Equals(PhoneNumber, other.PhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowOverrideAgentNodeModelInput?>.Default.Equals(OverrideAgent, other.OverrideAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowStandaloneAgentNodeModelInput?>.Default.Equals(StandaloneAgent, other.StandaloneAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolNodeModelInput?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Nodes obj1, Nodes obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Nodes>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Nodes obj1, Nodes obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Nodes o && Equals(o);
        }
    }
}
