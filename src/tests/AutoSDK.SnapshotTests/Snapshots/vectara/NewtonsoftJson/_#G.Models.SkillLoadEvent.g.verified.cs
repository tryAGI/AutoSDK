//HintName: G.Models.SkillLoadEvent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An event representing the loading of a skill's content into the conversation.
    /// </summary>
    public readonly partial struct SkillLoadEvent : global::System.IEquatable<SkillLoadEvent>
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
        public global::G.SkillLoadEventVariant2? SkillLoadEventVariant2 { get; init; }
#else
        public global::G.SkillLoadEventVariant2? SkillLoadEventVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SkillLoadEventVariant2))]
#endif
        public bool IsSkillLoadEventVariant2 => SkillLoadEventVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkillLoadEvent(global::G.AgentEventBase value) => new SkillLoadEvent((global::G.AgentEventBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentEventBase?(SkillLoadEvent @this) => @this.AgentBase;

        /// <summary>
        /// 
        /// </summary>
        public SkillLoadEvent(global::G.AgentEventBase? value)
        {
            AgentBase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SkillLoadEvent(global::G.SkillLoadEventVariant2 value) => new SkillLoadEvent((global::G.SkillLoadEventVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SkillLoadEventVariant2?(SkillLoadEvent @this) => @this.SkillLoadEventVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SkillLoadEvent(global::G.SkillLoadEventVariant2? value)
        {
            SkillLoadEventVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SkillLoadEvent(
            global::G.AgentEventBase? agentBase,
            global::G.SkillLoadEventVariant2? skillLoadEventVariant2
            )
        {
            AgentBase = agentBase;
            SkillLoadEventVariant2 = skillLoadEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SkillLoadEventVariant2 as object ??
            AgentBase as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentBase?.ToString() ??
            SkillLoadEventVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentBase && IsSkillLoadEventVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentEventBase?, TResult>? agentBase = null,
            global::System.Func<global::G.SkillLoadEventVariant2?, TResult>? skillLoadEventVariant2 = null,
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
            else if (IsSkillLoadEventVariant2 && skillLoadEventVariant2 != null)
            {
                return skillLoadEventVariant2(SkillLoadEventVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentEventBase?>? agentBase = null,
            global::System.Action<global::G.SkillLoadEventVariant2?>? skillLoadEventVariant2 = null,
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
            else if (IsSkillLoadEventVariant2)
            {
                skillLoadEventVariant2?.Invoke(SkillLoadEventVariant2!);
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
                SkillLoadEventVariant2,
                typeof(global::G.SkillLoadEventVariant2),
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
        public bool Equals(SkillLoadEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentEventBase?>.Default.Equals(AgentBase, other.AgentBase) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SkillLoadEventVariant2?>.Default.Equals(SkillLoadEventVariant2, other.SkillLoadEventVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SkillLoadEvent obj1, SkillLoadEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SkillLoadEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SkillLoadEvent obj1, SkillLoadEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SkillLoadEvent o && Equals(o);
        }
    }
}
