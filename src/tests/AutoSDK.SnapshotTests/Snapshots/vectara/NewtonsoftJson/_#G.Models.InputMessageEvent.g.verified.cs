//HintName: G.Models.InputMessageEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An input message event from a user.
    /// </summary>
    public readonly partial struct InputMessageEvent : global::System.IEquatable<InputMessageEvent>
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
        public global::G.InputMessageEventVariant2? InputMessageEventVariant2 { get; init; }
#else
        public global::G.InputMessageEventVariant2? InputMessageEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageEventVariant2))]
#endif
        public bool IsInputMessageEventVariant2 => InputMessageEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageEvent(global::G.AgentEventBase value) => new InputMessageEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(InputMessageEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputMessageEvent(global::G.InputMessageEventVariant2 value) => new InputMessageEvent((global::G.InputMessageEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.InputMessageEventVariant2?(InputMessageEvent @this) => @this.InputMessageEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InputMessageEvent(global::G.InputMessageEventVariant2? value)
        {
            InputMessageEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputMessageEvent(
            global::G.AgentEventBase? agentBase,
            global::G.InputMessageEventVariant2? inputMessageEventVariant2
            )
        {
            AgentBase = agentBase;
            InputMessageEventVariant2 = inputMessageEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputMessageEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            InputMessageEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsInputMessageEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.InputMessageEventVariant2?, TResult>? inputMessageEventVariant2 = null,
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
            else if (IsInputMessageEventVariant2 && inputMessageEventVariant2 != null)
            {
                return inputMessageEventVariant2(InputMessageEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.InputMessageEventVariant2?>? inputMessageEventVariant2 = null,
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
            else if (IsInputMessageEventVariant2)
            {
                inputMessageEventVariant2?.Invoke(InputMessageEventVariant2!);
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
                InputMessageEventVariant2,
                typeof(global::G.InputMessageEventVariant2),
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
        public bool Equals(InputMessageEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.InputMessageEventVariant2?>.Default.Equals(InputMessageEventVariant2, other.InputMessageEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputMessageEvent obj1, InputMessageEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputMessageEvent obj1, InputMessageEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageEvent o && Equals(o);
        }
    }
}
