//HintName: G.Models.ToolOutputEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An event representing output from a tool call.
    /// </summary>
    public readonly partial struct ToolOutputEvent : global::System.IEquatable<ToolOutputEvent>
    {
        /// <summary>
        /// Base properties shared by all agent event types.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentEventBase? AgentBase { get; init; }
#else
        public global::G.AgentEventBase? AgentBase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentBase))]
#endif
        public bool IsAgentBase => AgentBase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ToolOutputEventVariant2? ToolOutputEventVariant2 { get; init; }
#else
        public global::G.ToolOutputEventVariant2? ToolOutputEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolOutputEventVariant2))]
#endif
        public bool IsToolOutputEventVariant2 => ToolOutputEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolOutputEvent(global::G.AgentEventBase value) => new ToolOutputEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(ToolOutputEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ToolOutputEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolOutputEvent(global::G.ToolOutputEventVariant2 value) => new ToolOutputEvent((global::G.ToolOutputEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolOutputEventVariant2?(ToolOutputEvent @this) => @this.ToolOutputEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ToolOutputEvent(global::G.ToolOutputEventVariant2? value)
        {
            ToolOutputEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolOutputEvent(
            global::G.AgentEventBase? agentBase,
            global::G.ToolOutputEventVariant2? toolOutputEventVariant2
            )
        {
            AgentBase = agentBase;
            ToolOutputEventVariant2 = toolOutputEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolOutputEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ToolOutputEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsToolOutputEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.ToolOutputEventVariant2?, TResult>? toolOutputEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase && agentBase != null)
            {
                return agentBase(AgentBase!);
            }
            else if (IsToolOutputEventVariant2 && toolOutputEventVariant2 != null)
            {
                return toolOutputEventVariant2(ToolOutputEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.ToolOutputEventVariant2?>? toolOutputEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentBase)
            {
                agentBase?.Invoke(AgentBase!);
            }
            else if (IsToolOutputEventVariant2)
            {
                toolOutputEventVariant2?.Invoke(ToolOutputEventVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentBase,
                typeof(global::G.AgentEventBase),
                ToolOutputEventVariant2,
                typeof(global::G.ToolOutputEventVariant2),
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
        public bool Equals(ToolOutputEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolOutputEventVariant2?>.Default.Equals(ToolOutputEventVariant2, other.ToolOutputEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolOutputEvent obj1, ToolOutputEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolOutputEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolOutputEvent obj1, ToolOutputEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolOutputEvent o && Equals(o);
        }
    }
}
