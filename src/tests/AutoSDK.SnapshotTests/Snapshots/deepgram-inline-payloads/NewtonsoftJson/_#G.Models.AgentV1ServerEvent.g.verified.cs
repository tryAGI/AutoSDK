//HintName: G.Models.AgentV1ServerEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentV1ServerEvent : global::System.IEquatable<AgentV1ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.AgentV1ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Indicates the agent has started.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentStarted? AgentStarted { get; init; }
#else
        public global::G.AgentStarted? AgentStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentStarted))]
#endif
        public bool IsAgentStarted => AgentStarted != null;

        /// <summary>
        /// Indicates the agent is processing.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentThinking? AgentThinking { get; init; }
#else
        public global::G.AgentThinking? AgentThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentThinking))]
#endif
        public bool IsAgentThinking => AgentThinking != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::G.AgentStarted value) => new AgentV1ServerEvent((global::G.AgentStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentStarted?(AgentV1ServerEvent @this) => @this.AgentStarted;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::G.AgentStarted? value)
        {
            AgentStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentV1ServerEvent(global::G.AgentThinking value) => new AgentV1ServerEvent((global::G.AgentThinking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentThinking?(AgentV1ServerEvent @this) => @this.AgentThinking;

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(global::G.AgentThinking? value)
        {
            AgentThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentV1ServerEvent(
            global::G.AgentV1ServerEventDiscriminatorType? type,
            global::G.AgentStarted? agentStarted,
            global::G.AgentThinking? agentThinking
            )
        {
            Type = type;

            AgentStarted = agentStarted;
            AgentThinking = agentThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentThinking as object ??
            AgentStarted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentStarted?.ToString() ??
            AgentThinking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentStarted && !IsAgentThinking || !IsAgentStarted && IsAgentThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentStarted?, TResult>? agentStarted = null,
            global::System.Func<global::G.AgentThinking?, TResult>? agentThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentStarted && agentStarted != null)
            {
                return agentStarted(AgentStarted!);
            }
            else if (IsAgentThinking && agentThinking != null)
            {
                return agentThinking(AgentThinking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentStarted?>? agentStarted = null,
            global::System.Action<global::G.AgentThinking?>? agentThinking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentStarted)
            {
                agentStarted?.Invoke(AgentStarted!);
            }
            else if (IsAgentThinking)
            {
                agentThinking?.Invoke(AgentThinking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentStarted,
                typeof(global::G.AgentStarted),
                AgentThinking,
                typeof(global::G.AgentThinking),
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
        public bool Equals(AgentV1ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentStarted?>.Default.Equals(AgentStarted, other.AgentStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentThinking?>.Default.Equals(AgentThinking, other.AgentThinking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentV1ServerEvent obj1, AgentV1ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentV1ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentV1ServerEvent obj1, AgentV1ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentV1ServerEvent o && Equals(o);
        }
    }
}
