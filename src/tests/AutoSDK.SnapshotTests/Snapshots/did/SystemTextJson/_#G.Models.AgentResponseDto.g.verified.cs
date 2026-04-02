//HintName: G.Models.AgentResponseDto.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response DTO for agent transformation
    /// </summary>
    public readonly partial struct AgentResponseDto : global::System.IEquatable<AgentResponseDto>
    {
        /// <summary>
        /// Construct a type with the properties of T except for those in type K.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentResponseDtoVariant1? AgentResponseDtoVariant1 { get; init; }
#else
        public global::G.AgentResponseDtoVariant1? AgentResponseDtoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentResponseDtoVariant1))]
#endif
        public bool IsAgentResponseDtoVariant1 => AgentResponseDtoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AgentResponseDtoVariant2? AgentResponseDtoVariant2 { get; init; }
#else
        public global::G.AgentResponseDtoVariant2? AgentResponseDtoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentResponseDtoVariant2))]
#endif
        public bool IsAgentResponseDtoVariant2 => AgentResponseDtoVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentResponseDto(global::G.AgentResponseDtoVariant1 value) => new AgentResponseDto((global::G.AgentResponseDtoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentResponseDtoVariant1?(AgentResponseDto @this) => @this.AgentResponseDtoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AgentResponseDto(global::G.AgentResponseDtoVariant1? value)
        {
            AgentResponseDtoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AgentResponseDto(global::G.AgentResponseDtoVariant2 value) => new AgentResponseDto((global::G.AgentResponseDtoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AgentResponseDtoVariant2?(AgentResponseDto @this) => @this.AgentResponseDtoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AgentResponseDto(global::G.AgentResponseDtoVariant2? value)
        {
            AgentResponseDtoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentResponseDto(
            global::G.AgentResponseDtoVariant1? agentResponseDtoVariant1,
            global::G.AgentResponseDtoVariant2? agentResponseDtoVariant2
            )
        {
            AgentResponseDtoVariant1 = agentResponseDtoVariant1;
            AgentResponseDtoVariant2 = agentResponseDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AgentResponseDtoVariant2 as object ??
            AgentResponseDtoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AgentResponseDtoVariant1?.ToString() ??
            AgentResponseDtoVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgentResponseDtoVariant1 && IsAgentResponseDtoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AgentResponseDtoVariant1?, TResult>? agentResponseDtoVariant1 = null,
            global::System.Func<global::G.AgentResponseDtoVariant2?, TResult>? agentResponseDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentResponseDtoVariant1 && agentResponseDtoVariant1 != null)
            {
                return agentResponseDtoVariant1(AgentResponseDtoVariant1!);
            }
            else if (IsAgentResponseDtoVariant2 && agentResponseDtoVariant2 != null)
            {
                return agentResponseDtoVariant2(AgentResponseDtoVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AgentResponseDtoVariant1?>? agentResponseDtoVariant1 = null,
            global::System.Action<global::G.AgentResponseDtoVariant2?>? agentResponseDtoVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgentResponseDtoVariant1)
            {
                agentResponseDtoVariant1?.Invoke(AgentResponseDtoVariant1!);
            }
            else if (IsAgentResponseDtoVariant2)
            {
                agentResponseDtoVariant2?.Invoke(AgentResponseDtoVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AgentResponseDtoVariant1,
                typeof(global::G.AgentResponseDtoVariant1),
                AgentResponseDtoVariant2,
                typeof(global::G.AgentResponseDtoVariant2),
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
        public bool Equals(AgentResponseDto other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AgentResponseDtoVariant1?>.Default.Equals(AgentResponseDtoVariant1, other.AgentResponseDtoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AgentResponseDtoVariant2?>.Default.Equals(AgentResponseDtoVariant2, other.AgentResponseDtoVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentResponseDto obj1, AgentResponseDto obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentResponseDto>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentResponseDto obj1, AgentResponseDto obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentResponseDto o && Equals(o);
        }
    }
}
