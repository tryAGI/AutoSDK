//HintName: G.Models.ToolInputEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An event representing input to a tool call.
    /// </summary>
    public readonly partial struct ToolInputEvent : global::System.IEquatable<ToolInputEvent>
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
        public global::G.ToolInputEventVariant2? ToolInputEventVariant2 { get; init; }
#else
        public global::G.ToolInputEventVariant2? ToolInputEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolInputEventVariant2))]
#endif
        public bool IsToolInputEventVariant2 => ToolInputEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolInputEvent(global::G.AgentEventBase value) => new ToolInputEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(ToolInputEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public ToolInputEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolInputEvent(global::G.ToolInputEventVariant2 value) => new ToolInputEvent((global::G.ToolInputEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ToolInputEventVariant2?(ToolInputEvent @this) => @this.ToolInputEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ToolInputEvent(global::G.ToolInputEventVariant2? value)
        {
            ToolInputEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolInputEvent(
            global::G.AgentEventBase? agentBase,
            global::G.ToolInputEventVariant2? toolInputEventVariant2
            )
        {
            AgentBase = agentBase;
            ToolInputEventVariant2 = toolInputEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolInputEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            ToolInputEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsToolInputEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.ToolInputEventVariant2?, TResult>? toolInputEventVariant2 = null,
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
            else if (IsToolInputEventVariant2 && toolInputEventVariant2 != null)
            {
                return toolInputEventVariant2(ToolInputEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.ToolInputEventVariant2?>? toolInputEventVariant2 = null,
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
            else if (IsToolInputEventVariant2)
            {
                toolInputEventVariant2?.Invoke(ToolInputEventVariant2!);
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
                ToolInputEventVariant2,
                typeof(global::G.ToolInputEventVariant2),
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
        public bool Equals(ToolInputEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ToolInputEventVariant2?>.Default.Equals(ToolInputEventVariant2, other.ToolInputEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolInputEvent obj1, ToolInputEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolInputEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolInputEvent obj1, ToolInputEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolInputEvent o && Equals(o);
        }
    }
}
