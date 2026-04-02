//HintName: G.Models.CompactionStartedEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An event indicating that context compaction has started.
    /// </summary>
    public readonly partial struct CompactionStartedEvent : global::System.IEquatable<CompactionStartedEvent>
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
        public global::G.CompactionStartedEventVariant2? CompactionStartedEventVariant2 { get; init; }
#else
        public global::G.CompactionStartedEventVariant2? CompactionStartedEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionStartedEventVariant2))]
#endif
        public bool IsCompactionStartedEventVariant2 => CompactionStartedEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompactionStartedEvent(global::G.AgentEventBase value) => new CompactionStartedEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(CompactionStartedEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public CompactionStartedEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CompactionStartedEvent(global::G.CompactionStartedEventVariant2 value) => new CompactionStartedEvent((global::G.CompactionStartedEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompactionStartedEventVariant2?(CompactionStartedEvent @this) => @this.CompactionStartedEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CompactionStartedEvent(global::G.CompactionStartedEventVariant2? value)
        {
            CompactionStartedEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CompactionStartedEvent(
            global::G.AgentEventBase? agentBase,
            global::G.CompactionStartedEventVariant2? compactionStartedEventVariant2
            )
        {
            AgentBase = agentBase;
            CompactionStartedEventVariant2 = compactionStartedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CompactionStartedEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            CompactionStartedEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsCompactionStartedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.CompactionStartedEventVariant2?, TResult>? compactionStartedEventVariant2 = null,
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
            else if (IsCompactionStartedEventVariant2 && compactionStartedEventVariant2 != null)
            {
                return compactionStartedEventVariant2(CompactionStartedEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.CompactionStartedEventVariant2?>? compactionStartedEventVariant2 = null,
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
            else if (IsCompactionStartedEventVariant2)
            {
                compactionStartedEventVariant2?.Invoke(CompactionStartedEventVariant2!);
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
                CompactionStartedEventVariant2,
                typeof(global::G.CompactionStartedEventVariant2),
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
        public bool Equals(CompactionStartedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CompactionStartedEventVariant2?>.Default.Equals(CompactionStartedEventVariant2, other.CompactionStartedEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CompactionStartedEvent obj1, CompactionStartedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CompactionStartedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CompactionStartedEvent obj1, CompactionStartedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompactionStartedEvent o && Equals(o);
        }
    }
}
