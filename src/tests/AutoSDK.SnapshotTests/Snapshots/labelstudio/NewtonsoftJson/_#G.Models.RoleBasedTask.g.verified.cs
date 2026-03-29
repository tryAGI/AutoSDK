//HintName: G.Models.RoleBasedTask.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RoleBasedTask : global::System.IEquatable<RoleBasedTask>
    {
        /// <summary>
        /// Data Manager Task Serializer with FSM state support.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LseTask? Lse { get; init; }
#else
        public global::G.LseTask? Lse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lse))]
#endif
        public bool IsLse => Lse != null;

        /// <summary>
        /// Data Manager Task Serializer with FSM state support.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LseTaskSerializerForReviewers? LseSerializerForReviewers { get; init; }
#else
        public global::G.LseTaskSerializerForReviewers? LseSerializerForReviewers { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LseSerializerForReviewers))]
#endif
        public bool IsLseSerializerForReviewers => LseSerializerForReviewers != null;

        /// <summary>
        /// Data Manager Task Serializer with FSM state support.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LseTaskSerializerForAnnotators? LseSerializerForAnnotators { get; init; }
#else
        public global::G.LseTaskSerializerForAnnotators? LseSerializerForAnnotators { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LseSerializerForAnnotators))]
#endif
        public bool IsLseSerializerForAnnotators => LseSerializerForAnnotators != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RoleBasedTask(global::G.LseTask value) => new RoleBasedTask((global::G.LseTask?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LseTask?(RoleBasedTask @this) => @this.Lse;

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(global::G.LseTask? value)
        {
            Lse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RoleBasedTask(global::G.LseTaskSerializerForReviewers value) => new RoleBasedTask((global::G.LseTaskSerializerForReviewers?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LseTaskSerializerForReviewers?(RoleBasedTask @this) => @this.LseSerializerForReviewers;

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(global::G.LseTaskSerializerForReviewers? value)
        {
            LseSerializerForReviewers = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RoleBasedTask(global::G.LseTaskSerializerForAnnotators value) => new RoleBasedTask((global::G.LseTaskSerializerForAnnotators?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LseTaskSerializerForAnnotators?(RoleBasedTask @this) => @this.LseSerializerForAnnotators;

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(global::G.LseTaskSerializerForAnnotators? value)
        {
            LseSerializerForAnnotators = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RoleBasedTask(
            global::G.LseTask? lse,
            global::G.LseTaskSerializerForReviewers? lseSerializerForReviewers,
            global::G.LseTaskSerializerForAnnotators? lseSerializerForAnnotators
            )
        {
            Lse = lse;
            LseSerializerForReviewers = lseSerializerForReviewers;
            LseSerializerForAnnotators = lseSerializerForAnnotators;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LseSerializerForAnnotators as object ??
            LseSerializerForReviewers as object ??
            Lse as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Lse?.ToString() ??
            LseSerializerForReviewers?.ToString() ??
            LseSerializerForAnnotators?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLse && !IsLseSerializerForReviewers && !IsLseSerializerForAnnotators || !IsLse && IsLseSerializerForReviewers && !IsLseSerializerForAnnotators || !IsLse && !IsLseSerializerForReviewers && IsLseSerializerForAnnotators;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LseTask?, TResult>? lse = null,
            global::System.Func<global::G.LseTaskSerializerForReviewers?, TResult>? lseSerializerForReviewers = null,
            global::System.Func<global::G.LseTaskSerializerForAnnotators?, TResult>? lseSerializerForAnnotators = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLse && lse != null)
            {
                return lse(Lse!);
            }
            else if (IsLseSerializerForReviewers && lseSerializerForReviewers != null)
            {
                return lseSerializerForReviewers(LseSerializerForReviewers!);
            }
            else if (IsLseSerializerForAnnotators && lseSerializerForAnnotators != null)
            {
                return lseSerializerForAnnotators(LseSerializerForAnnotators!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LseTask?>? lse = null,
            global::System.Action<global::G.LseTaskSerializerForReviewers?>? lseSerializerForReviewers = null,
            global::System.Action<global::G.LseTaskSerializerForAnnotators?>? lseSerializerForAnnotators = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLse)
            {
                lse?.Invoke(Lse!);
            }
            else if (IsLseSerializerForReviewers)
            {
                lseSerializerForReviewers?.Invoke(LseSerializerForReviewers!);
            }
            else if (IsLseSerializerForAnnotators)
            {
                lseSerializerForAnnotators?.Invoke(LseSerializerForAnnotators!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Lse,
                typeof(global::G.LseTask),
                LseSerializerForReviewers,
                typeof(global::G.LseTaskSerializerForReviewers),
                LseSerializerForAnnotators,
                typeof(global::G.LseTaskSerializerForAnnotators),
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
        public bool Equals(RoleBasedTask other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LseTask?>.Default.Equals(Lse, other.Lse) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LseTaskSerializerForReviewers?>.Default.Equals(LseSerializerForReviewers, other.LseSerializerForReviewers) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LseTaskSerializerForAnnotators?>.Default.Equals(LseSerializerForAnnotators, other.LseSerializerForAnnotators) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RoleBasedTask obj1, RoleBasedTask obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RoleBasedTask>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RoleBasedTask obj1, RoleBasedTask obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RoleBasedTask o && Equals(o);
        }
    }
}
