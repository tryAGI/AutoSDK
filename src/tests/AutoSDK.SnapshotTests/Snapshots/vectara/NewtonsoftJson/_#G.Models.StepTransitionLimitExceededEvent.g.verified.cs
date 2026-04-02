//HintName: G.Models.StepTransitionLimitExceededEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A transient event indicating the agent exceeded the maximum number of step transitions,<br/>
    /// which may indicate an infinite loop between steps.<br/>
    /// This event is not persisted to the session history.
    /// </summary>
    public readonly partial struct StepTransitionLimitExceededEvent : global::System.IEquatable<StepTransitionLimitExceededEvent>
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
        public global::G.StepTransitionLimitExceededEventVariant2? StepTransitionLimitExceededEventVariant2 { get; init; }
#else
        public global::G.StepTransitionLimitExceededEventVariant2? StepTransitionLimitExceededEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepTransitionLimitExceededEventVariant2))]
#endif
        public bool IsStepTransitionLimitExceededEventVariant2 => StepTransitionLimitExceededEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepTransitionLimitExceededEvent(global::G.AgentEventBase value) => new StepTransitionLimitExceededEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(StepTransitionLimitExceededEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionLimitExceededEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StepTransitionLimitExceededEvent(global::G.StepTransitionLimitExceededEventVariant2 value) => new StepTransitionLimitExceededEvent((global::G.StepTransitionLimitExceededEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StepTransitionLimitExceededEventVariant2?(StepTransitionLimitExceededEvent @this) => @this.StepTransitionLimitExceededEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionLimitExceededEvent(global::G.StepTransitionLimitExceededEventVariant2? value)
        {
            StepTransitionLimitExceededEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StepTransitionLimitExceededEvent(
            global::G.AgentEventBase? agentBase,
            global::G.StepTransitionLimitExceededEventVariant2? stepTransitionLimitExceededEventVariant2
            )
        {
            AgentBase = agentBase;
            StepTransitionLimitExceededEventVariant2 = stepTransitionLimitExceededEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StepTransitionLimitExceededEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            StepTransitionLimitExceededEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsStepTransitionLimitExceededEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.StepTransitionLimitExceededEventVariant2?, TResult>? stepTransitionLimitExceededEventVariant2 = null,
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
            else if (IsStepTransitionLimitExceededEventVariant2 && stepTransitionLimitExceededEventVariant2 != null)
            {
                return stepTransitionLimitExceededEventVariant2(StepTransitionLimitExceededEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.StepTransitionLimitExceededEventVariant2?>? stepTransitionLimitExceededEventVariant2 = null,
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
            else if (IsStepTransitionLimitExceededEventVariant2)
            {
                stepTransitionLimitExceededEventVariant2?.Invoke(StepTransitionLimitExceededEventVariant2!);
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
                StepTransitionLimitExceededEventVariant2,
                typeof(global::G.StepTransitionLimitExceededEventVariant2),
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
        public bool Equals(StepTransitionLimitExceededEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.StepTransitionLimitExceededEventVariant2?>.Default.Equals(StepTransitionLimitExceededEventVariant2, other.StepTransitionLimitExceededEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StepTransitionLimitExceededEvent obj1, StepTransitionLimitExceededEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepTransitionLimitExceededEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StepTransitionLimitExceededEvent obj1, StepTransitionLimitExceededEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepTransitionLimitExceededEvent o && Equals(o);
        }
    }
}
