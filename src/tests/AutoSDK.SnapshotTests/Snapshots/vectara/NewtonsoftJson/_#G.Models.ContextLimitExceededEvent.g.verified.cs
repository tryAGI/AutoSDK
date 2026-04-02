//HintName: G.Models.ContextLimitExceededEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A transient event indicating the current request exceeded the LLM's context limit.<br/>
    /// This event is not persisted to the session history.
    /// </summary>
    public readonly partial struct ContextLimitExceededEvent : global::System.IEquatable<ContextLimitExceededEvent>
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
        public global::G.ContextLimitExceededEventVariant2? ContextLimitExceededEventVariant2 { get; init; }
#else
        public global::G.ContextLimitExceededEventVariant2? ContextLimitExceededEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextLimitExceededEventVariant2))]
#endif
        public bool IsContextLimitExceededEventVariant2 => ContextLimitExceededEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextLimitExceededEvent(global::G.AgentEventBase value) => new ContextLimitExceededEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(ContextLimitExceededEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ContextLimitExceededEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ContextLimitExceededEvent(global::G.ContextLimitExceededEventVariant2 value) => new ContextLimitExceededEvent((global::G.ContextLimitExceededEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ContextLimitExceededEventVariant2?(ContextLimitExceededEvent @this) => @this.ContextLimitExceededEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ContextLimitExceededEvent(global::G.ContextLimitExceededEventVariant2? value)
        {
            ContextLimitExceededEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ContextLimitExceededEvent(
            global::G.AgentEventBase? agentBase,
            global::G.ContextLimitExceededEventVariant2? contextLimitExceededEventVariant2
            )
        {
            AgentBase = agentBase;
            ContextLimitExceededEventVariant2 = contextLimitExceededEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContextLimitExceededEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ContextLimitExceededEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsContextLimitExceededEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.ContextLimitExceededEventVariant2?, TResult>? contextLimitExceededEventVariant2 = null,
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
            else if (IsContextLimitExceededEventVariant2 && contextLimitExceededEventVariant2 != null)
            {
                return contextLimitExceededEventVariant2(ContextLimitExceededEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.ContextLimitExceededEventVariant2?>? contextLimitExceededEventVariant2 = null,
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
            else if (IsContextLimitExceededEventVariant2)
            {
                contextLimitExceededEventVariant2?.Invoke(ContextLimitExceededEventVariant2!);
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
                ContextLimitExceededEventVariant2,
                typeof(global::G.ContextLimitExceededEventVariant2),
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
        public bool Equals(ContextLimitExceededEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ContextLimitExceededEventVariant2?>.Default.Equals(ContextLimitExceededEventVariant2, other.ContextLimitExceededEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ContextLimitExceededEvent obj1, ContextLimitExceededEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContextLimitExceededEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ContextLimitExceededEvent obj1, ContextLimitExceededEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContextLimitExceededEvent o && Equals(o);
        }
    }
}
