//HintName: G.Models.SparseIndexType.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Sparse index types
    /// </summary>
    public readonly partial struct SparseIndexType : global::System.IEquatable<SparseIndexType>
    {
        /// <summary>
        /// Mutable RAM sparse index
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseIndexTypeVariant1? SparseIndexTypeVariant1 { get; init; }
#else
        public global::G.SparseIndexTypeVariant1? SparseIndexTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseIndexTypeVariant1))]
#endif
        public bool IsSparseIndexTypeVariant1 => SparseIndexTypeVariant1 != null;

        /// <summary>
        /// Immutable RAM sparse index
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseIndexTypeVariant2? SparseIndexTypeVariant2 { get; init; }
#else
        public global::G.SparseIndexTypeVariant2? SparseIndexTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseIndexTypeVariant2))]
#endif
        public bool IsSparseIndexTypeVariant2 => SparseIndexTypeVariant2 != null;

        /// <summary>
        /// Mmap sparse index
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseIndexTypeVariant3? SparseIndexTypeVariant3 { get; init; }
#else
        public global::G.SparseIndexTypeVariant3? SparseIndexTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseIndexTypeVariant3))]
#endif
        public bool IsSparseIndexTypeVariant3 => SparseIndexTypeVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SparseIndexType(global::G.SparseIndexTypeVariant1 value) => new SparseIndexType((global::G.SparseIndexTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseIndexTypeVariant1?(SparseIndexType @this) => @this.SparseIndexTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SparseIndexType(global::G.SparseIndexTypeVariant1? value)
        {
            SparseIndexTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SparseIndexType(global::G.SparseIndexTypeVariant2 value) => new SparseIndexType((global::G.SparseIndexTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseIndexTypeVariant2?(SparseIndexType @this) => @this.SparseIndexTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SparseIndexType(global::G.SparseIndexTypeVariant2? value)
        {
            SparseIndexTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SparseIndexType(global::G.SparseIndexTypeVariant3 value) => new SparseIndexType((global::G.SparseIndexTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseIndexTypeVariant3?(SparseIndexType @this) => @this.SparseIndexTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public SparseIndexType(global::G.SparseIndexTypeVariant3? value)
        {
            SparseIndexTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SparseIndexType(
            global::G.SparseIndexTypeVariant1? sparseIndexTypeVariant1,
            global::G.SparseIndexTypeVariant2? sparseIndexTypeVariant2,
            global::G.SparseIndexTypeVariant3? sparseIndexTypeVariant3
            )
        {
            SparseIndexTypeVariant1 = sparseIndexTypeVariant1;
            SparseIndexTypeVariant2 = sparseIndexTypeVariant2;
            SparseIndexTypeVariant3 = sparseIndexTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SparseIndexTypeVariant3 as object ??
            SparseIndexTypeVariant2 as object ??
            SparseIndexTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SparseIndexTypeVariant1?.ToValueString() ??
            SparseIndexTypeVariant2?.ToValueString() ??
            SparseIndexTypeVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSparseIndexTypeVariant1 && !IsSparseIndexTypeVariant2 && !IsSparseIndexTypeVariant3 || !IsSparseIndexTypeVariant1 && IsSparseIndexTypeVariant2 && !IsSparseIndexTypeVariant3 || !IsSparseIndexTypeVariant1 && !IsSparseIndexTypeVariant2 && IsSparseIndexTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SparseIndexTypeVariant1?, TResult>? sparseIndexTypeVariant1 = null,
            global::System.Func<global::G.SparseIndexTypeVariant2?, TResult>? sparseIndexTypeVariant2 = null,
            global::System.Func<global::G.SparseIndexTypeVariant3?, TResult>? sparseIndexTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSparseIndexTypeVariant1 && sparseIndexTypeVariant1 != null)
            {
                return sparseIndexTypeVariant1(SparseIndexTypeVariant1!);
            }
            else if (IsSparseIndexTypeVariant2 && sparseIndexTypeVariant2 != null)
            {
                return sparseIndexTypeVariant2(SparseIndexTypeVariant2!);
            }
            else if (IsSparseIndexTypeVariant3 && sparseIndexTypeVariant3 != null)
            {
                return sparseIndexTypeVariant3(SparseIndexTypeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SparseIndexTypeVariant1?>? sparseIndexTypeVariant1 = null,
            global::System.Action<global::G.SparseIndexTypeVariant2?>? sparseIndexTypeVariant2 = null,
            global::System.Action<global::G.SparseIndexTypeVariant3?>? sparseIndexTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSparseIndexTypeVariant1)
            {
                sparseIndexTypeVariant1?.Invoke(SparseIndexTypeVariant1!);
            }
            else if (IsSparseIndexTypeVariant2)
            {
                sparseIndexTypeVariant2?.Invoke(SparseIndexTypeVariant2!);
            }
            else if (IsSparseIndexTypeVariant3)
            {
                sparseIndexTypeVariant3?.Invoke(SparseIndexTypeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SparseIndexTypeVariant1,
                typeof(global::G.SparseIndexTypeVariant1),
                SparseIndexTypeVariant2,
                typeof(global::G.SparseIndexTypeVariant2),
                SparseIndexTypeVariant3,
                typeof(global::G.SparseIndexTypeVariant3),
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
        public bool Equals(SparseIndexType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SparseIndexTypeVariant1?>.Default.Equals(SparseIndexTypeVariant1, other.SparseIndexTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SparseIndexTypeVariant2?>.Default.Equals(SparseIndexTypeVariant2, other.SparseIndexTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SparseIndexTypeVariant3?>.Default.Equals(SparseIndexTypeVariant3, other.SparseIndexTypeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SparseIndexType obj1, SparseIndexType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SparseIndexType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SparseIndexType obj1, SparseIndexType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SparseIndexType o && Equals(o);
        }
    }
}
