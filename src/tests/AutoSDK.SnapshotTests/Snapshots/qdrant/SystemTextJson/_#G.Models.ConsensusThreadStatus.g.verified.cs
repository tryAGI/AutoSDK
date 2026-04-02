//HintName: G.Models.ConsensusThreadStatus.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Information about current consensus thread status
    /// </summary>
    public readonly partial struct ConsensusThreadStatus : global::System.IEquatable<ConsensusThreadStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConsensusThreadStatusVariant1? ConsensusThreadStatusVariant1 { get; init; }
#else
        public global::G.ConsensusThreadStatusVariant1? ConsensusThreadStatusVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConsensusThreadStatusVariant1))]
#endif
        public bool IsConsensusThreadStatusVariant1 => ConsensusThreadStatusVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConsensusThreadStatusVariant2? ConsensusThreadStatusVariant2 { get; init; }
#else
        public global::G.ConsensusThreadStatusVariant2? ConsensusThreadStatusVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConsensusThreadStatusVariant2))]
#endif
        public bool IsConsensusThreadStatusVariant2 => ConsensusThreadStatusVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ConsensusThreadStatusVariant3? ConsensusThreadStatusVariant3 { get; init; }
#else
        public global::G.ConsensusThreadStatusVariant3? ConsensusThreadStatusVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConsensusThreadStatusVariant3))]
#endif
        public bool IsConsensusThreadStatusVariant3 => ConsensusThreadStatusVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsensusThreadStatus(global::G.ConsensusThreadStatusVariant1 value) => new ConsensusThreadStatus((global::G.ConsensusThreadStatusVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConsensusThreadStatusVariant1?(ConsensusThreadStatus @this) => @this.ConsensusThreadStatusVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ConsensusThreadStatus(global::G.ConsensusThreadStatusVariant1? value)
        {
            ConsensusThreadStatusVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsensusThreadStatus(global::G.ConsensusThreadStatusVariant2 value) => new ConsensusThreadStatus((global::G.ConsensusThreadStatusVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConsensusThreadStatusVariant2?(ConsensusThreadStatus @this) => @this.ConsensusThreadStatusVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ConsensusThreadStatus(global::G.ConsensusThreadStatusVariant2? value)
        {
            ConsensusThreadStatusVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ConsensusThreadStatus(global::G.ConsensusThreadStatusVariant3 value) => new ConsensusThreadStatus((global::G.ConsensusThreadStatusVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ConsensusThreadStatusVariant3?(ConsensusThreadStatus @this) => @this.ConsensusThreadStatusVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ConsensusThreadStatus(global::G.ConsensusThreadStatusVariant3? value)
        {
            ConsensusThreadStatusVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ConsensusThreadStatus(
            global::G.ConsensusThreadStatusVariant1? consensusThreadStatusVariant1,
            global::G.ConsensusThreadStatusVariant2? consensusThreadStatusVariant2,
            global::G.ConsensusThreadStatusVariant3? consensusThreadStatusVariant3
            )
        {
            ConsensusThreadStatusVariant1 = consensusThreadStatusVariant1;
            ConsensusThreadStatusVariant2 = consensusThreadStatusVariant2;
            ConsensusThreadStatusVariant3 = consensusThreadStatusVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConsensusThreadStatusVariant3 as object ??
            ConsensusThreadStatusVariant2 as object ??
            ConsensusThreadStatusVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ConsensusThreadStatusVariant1?.ToString() ??
            ConsensusThreadStatusVariant2?.ToString() ??
            ConsensusThreadStatusVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConsensusThreadStatusVariant1 && !IsConsensusThreadStatusVariant2 && !IsConsensusThreadStatusVariant3 || !IsConsensusThreadStatusVariant1 && IsConsensusThreadStatusVariant2 && !IsConsensusThreadStatusVariant3 || !IsConsensusThreadStatusVariant1 && !IsConsensusThreadStatusVariant2 && IsConsensusThreadStatusVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ConsensusThreadStatusVariant1?, TResult>? consensusThreadStatusVariant1 = null,
            global::System.Func<global::G.ConsensusThreadStatusVariant2?, TResult>? consensusThreadStatusVariant2 = null,
            global::System.Func<global::G.ConsensusThreadStatusVariant3?, TResult>? consensusThreadStatusVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConsensusThreadStatusVariant1 && consensusThreadStatusVariant1 != null)
            {
                return consensusThreadStatusVariant1(ConsensusThreadStatusVariant1!);
            }
            else if (IsConsensusThreadStatusVariant2 && consensusThreadStatusVariant2 != null)
            {
                return consensusThreadStatusVariant2(ConsensusThreadStatusVariant2!);
            }
            else if (IsConsensusThreadStatusVariant3 && consensusThreadStatusVariant3 != null)
            {
                return consensusThreadStatusVariant3(ConsensusThreadStatusVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ConsensusThreadStatusVariant1?>? consensusThreadStatusVariant1 = null,
            global::System.Action<global::G.ConsensusThreadStatusVariant2?>? consensusThreadStatusVariant2 = null,
            global::System.Action<global::G.ConsensusThreadStatusVariant3?>? consensusThreadStatusVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConsensusThreadStatusVariant1)
            {
                consensusThreadStatusVariant1?.Invoke(ConsensusThreadStatusVariant1!);
            }
            else if (IsConsensusThreadStatusVariant2)
            {
                consensusThreadStatusVariant2?.Invoke(ConsensusThreadStatusVariant2!);
            }
            else if (IsConsensusThreadStatusVariant3)
            {
                consensusThreadStatusVariant3?.Invoke(ConsensusThreadStatusVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ConsensusThreadStatusVariant1,
                typeof(global::G.ConsensusThreadStatusVariant1),
                ConsensusThreadStatusVariant2,
                typeof(global::G.ConsensusThreadStatusVariant2),
                ConsensusThreadStatusVariant3,
                typeof(global::G.ConsensusThreadStatusVariant3),
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
        public bool Equals(ConsensusThreadStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ConsensusThreadStatusVariant1?>.Default.Equals(ConsensusThreadStatusVariant1, other.ConsensusThreadStatusVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConsensusThreadStatusVariant2?>.Default.Equals(ConsensusThreadStatusVariant2, other.ConsensusThreadStatusVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ConsensusThreadStatusVariant3?>.Default.Equals(ConsensusThreadStatusVariant3, other.ConsensusThreadStatusVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ConsensusThreadStatus obj1, ConsensusThreadStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ConsensusThreadStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ConsensusThreadStatus obj1, ConsensusThreadStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ConsensusThreadStatus o && Equals(o);
        }
    }
}
