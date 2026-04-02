//HintName: G.Models.SessionInterruptedEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A transient event indicating the agent session was interrupted by a user request.<br/>
    /// This event is not persisted to the session history.
    /// </summary>
    public readonly partial struct SessionInterruptedEvent : global::System.IEquatable<SessionInterruptedEvent>
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
        public global::G.SessionInterruptedEventVariant2? SessionInterruptedEventVariant2 { get; init; }
#else
        public global::G.SessionInterruptedEventVariant2? SessionInterruptedEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionInterruptedEventVariant2))]
#endif
        public bool IsSessionInterruptedEventVariant2 => SessionInterruptedEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionInterruptedEvent(global::G.AgentEventBase value) => new SessionInterruptedEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(SessionInterruptedEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public SessionInterruptedEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SessionInterruptedEvent(global::G.SessionInterruptedEventVariant2 value) => new SessionInterruptedEvent((global::G.SessionInterruptedEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SessionInterruptedEventVariant2?(SessionInterruptedEvent @this) => @this.SessionInterruptedEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SessionInterruptedEvent(global::G.SessionInterruptedEventVariant2? value)
        {
            SessionInterruptedEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SessionInterruptedEvent(
            global::G.AgentEventBase? agentBase,
            global::G.SessionInterruptedEventVariant2? sessionInterruptedEventVariant2
            )
        {
            AgentBase = agentBase;
            SessionInterruptedEventVariant2 = sessionInterruptedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SessionInterruptedEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            SessionInterruptedEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsSessionInterruptedEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.SessionInterruptedEventVariant2?, TResult>? sessionInterruptedEventVariant2 = null,
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
            else if (IsSessionInterruptedEventVariant2 && sessionInterruptedEventVariant2 != null)
            {
                return sessionInterruptedEventVariant2(SessionInterruptedEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.SessionInterruptedEventVariant2?>? sessionInterruptedEventVariant2 = null,
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
            else if (IsSessionInterruptedEventVariant2)
            {
                sessionInterruptedEventVariant2?.Invoke(SessionInterruptedEventVariant2!);
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
                SessionInterruptedEventVariant2,
                typeof(global::G.SessionInterruptedEventVariant2),
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
        public bool Equals(SessionInterruptedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SessionInterruptedEventVariant2?>.Default.Equals(SessionInterruptedEventVariant2, other.SessionInterruptedEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SessionInterruptedEvent obj1, SessionInterruptedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SessionInterruptedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SessionInterruptedEvent obj1, SessionInterruptedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SessionInterruptedEvent o && Equals(o);
        }
    }
}
