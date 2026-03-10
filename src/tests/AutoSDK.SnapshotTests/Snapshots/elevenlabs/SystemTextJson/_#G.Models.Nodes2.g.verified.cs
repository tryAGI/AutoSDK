//HintName: G.Models.Nodes2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Nodes2 : global::System.IEquatable<Nodes2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentWorkflowResponseModelNodesDiscriminatorType? Type { get; }

        /// <summary>
        /// Entry point of the workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.WorkflowStartNodeModelOutput? Start { get; init; }
#else
        public global::G.WorkflowStartNodeModelOutput? Start { get; }
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
        public global::G.WorkflowEndNodeModelOutput? End { get; init; }
#else
        public global::G.WorkflowEndNodeModelOutput? End { get; }
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
        public global::G.WorkflowPhoneNumberNodeModelOutput? PhoneNumber { get; init; }
#else
        public global::G.WorkflowPhoneNumberNodeModelOutput? PhoneNumber { get; }
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
        public global::G.WorkflowOverrideAgentNodeModelOutput? OverrideAgent { get; init; }
#else
        public global::G.WorkflowOverrideAgentNodeModelOutput? OverrideAgent { get; }
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
        public global::G.WorkflowStandaloneAgentNodeModelOutput? StandaloneAgent { get; init; }
#else
        public global::G.WorkflowStandaloneAgentNodeModelOutput? StandaloneAgent { get; }
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
        public global::G.WorkflowToolNodeModelOutput? Tool { get; init; }
#else
        public global::G.WorkflowToolNodeModelOutput? Tool { get; }
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
        public static implicit operator Nodes2(global::G.WorkflowStartNodeModelOutput value) => new Nodes2((global::G.WorkflowStartNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowStartNodeModelOutput?(Nodes2 @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::G.WorkflowStartNodeModelOutput? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::G.WorkflowEndNodeModelOutput value) => new Nodes2((global::G.WorkflowEndNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowEndNodeModelOutput?(Nodes2 @this) => @this.End;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::G.WorkflowEndNodeModelOutput? value)
        {
            End = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::G.WorkflowPhoneNumberNodeModelOutput value) => new Nodes2((global::G.WorkflowPhoneNumberNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowPhoneNumberNodeModelOutput?(Nodes2 @this) => @this.PhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::G.WorkflowPhoneNumberNodeModelOutput? value)
        {
            PhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::G.WorkflowOverrideAgentNodeModelOutput value) => new Nodes2((global::G.WorkflowOverrideAgentNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowOverrideAgentNodeModelOutput?(Nodes2 @this) => @this.OverrideAgent;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::G.WorkflowOverrideAgentNodeModelOutput? value)
        {
            OverrideAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::G.WorkflowStandaloneAgentNodeModelOutput value) => new Nodes2((global::G.WorkflowStandaloneAgentNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowStandaloneAgentNodeModelOutput?(Nodes2 @this) => @this.StandaloneAgent;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::G.WorkflowStandaloneAgentNodeModelOutput? value)
        {
            StandaloneAgent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Nodes2(global::G.WorkflowToolNodeModelOutput value) => new Nodes2((global::G.WorkflowToolNodeModelOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.WorkflowToolNodeModelOutput?(Nodes2 @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(global::G.WorkflowToolNodeModelOutput? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Nodes2(
            global::G.AgentWorkflowResponseModelNodesDiscriminatorType? type,
            global::G.WorkflowStartNodeModelOutput? start,
            global::G.WorkflowEndNodeModelOutput? end,
            global::G.WorkflowPhoneNumberNodeModelOutput? phoneNumber,
            global::G.WorkflowOverrideAgentNodeModelOutput? overrideAgent,
            global::G.WorkflowStandaloneAgentNodeModelOutput? standaloneAgent,
            global::G.WorkflowToolNodeModelOutput? tool
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
            global::System.Func<global::G.WorkflowStartNodeModelOutput?, TResult>? start = null,
            global::System.Func<global::G.WorkflowEndNodeModelOutput?, TResult>? end = null,
            global::System.Func<global::G.WorkflowPhoneNumberNodeModelOutput?, TResult>? phoneNumber = null,
            global::System.Func<global::G.WorkflowOverrideAgentNodeModelOutput?, TResult>? overrideAgent = null,
            global::System.Func<global::G.WorkflowStandaloneAgentNodeModelOutput?, TResult>? standaloneAgent = null,
            global::System.Func<global::G.WorkflowToolNodeModelOutput?, TResult>? tool = null,
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
            global::System.Action<global::G.WorkflowStartNodeModelOutput?>? start = null,
            global::System.Action<global::G.WorkflowEndNodeModelOutput?>? end = null,
            global::System.Action<global::G.WorkflowPhoneNumberNodeModelOutput?>? phoneNumber = null,
            global::System.Action<global::G.WorkflowOverrideAgentNodeModelOutput?>? overrideAgent = null,
            global::System.Action<global::G.WorkflowStandaloneAgentNodeModelOutput?>? standaloneAgent = null,
            global::System.Action<global::G.WorkflowToolNodeModelOutput?>? tool = null,
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
                typeof(global::G.WorkflowStartNodeModelOutput),
                End,
                typeof(global::G.WorkflowEndNodeModelOutput),
                PhoneNumber,
                typeof(global::G.WorkflowPhoneNumberNodeModelOutput),
                OverrideAgent,
                typeof(global::G.WorkflowOverrideAgentNodeModelOutput),
                StandaloneAgent,
                typeof(global::G.WorkflowStandaloneAgentNodeModelOutput),
                Tool,
                typeof(global::G.WorkflowToolNodeModelOutput),
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
        public bool Equals(Nodes2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowStartNodeModelOutput?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowEndNodeModelOutput?>.Default.Equals(End, other.End) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowPhoneNumberNodeModelOutput?>.Default.Equals(PhoneNumber, other.PhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowOverrideAgentNodeModelOutput?>.Default.Equals(OverrideAgent, other.OverrideAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowStandaloneAgentNodeModelOutput?>.Default.Equals(StandaloneAgent, other.StandaloneAgent) &&
                global::System.Collections.Generic.EqualityComparer<global::G.WorkflowToolNodeModelOutput?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Nodes2 obj1, Nodes2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Nodes2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Nodes2 obj1, Nodes2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Nodes2 o && Equals(o);
        }
    }
}
