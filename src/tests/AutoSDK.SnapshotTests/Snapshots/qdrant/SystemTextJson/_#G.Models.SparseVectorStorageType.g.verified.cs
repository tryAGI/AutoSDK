//HintName: G.Models.SparseVectorStorageType.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SparseVectorStorageType : global::System.IEquatable<SparseVectorStorageType>
    {
        /// <summary>
        /// Storage on disk (rocksdb storage)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseVectorStorageTypeVariant1? SparseVectorStorageTypeVariant1 { get; init; }
#else
        public global::G.SparseVectorStorageTypeVariant1? SparseVectorStorageTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseVectorStorageTypeVariant1))]
#endif
        public bool IsSparseVectorStorageTypeVariant1 => SparseVectorStorageTypeVariant1 != null;

        /// <summary>
        /// Storage in memory maps (gridstore storage)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SparseVectorStorageTypeVariant2? SparseVectorStorageTypeVariant2 { get; init; }
#else
        public global::G.SparseVectorStorageTypeVariant2? SparseVectorStorageTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SparseVectorStorageTypeVariant2))]
#endif
        public bool IsSparseVectorStorageTypeVariant2 => SparseVectorStorageTypeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SparseVectorStorageType(global::G.SparseVectorStorageTypeVariant1 value) => new SparseVectorStorageType((global::G.SparseVectorStorageTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseVectorStorageTypeVariant1?(SparseVectorStorageType @this) => @this.SparseVectorStorageTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SparseVectorStorageType(global::G.SparseVectorStorageTypeVariant1? value)
        {
            SparseVectorStorageTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SparseVectorStorageType(global::G.SparseVectorStorageTypeVariant2 value) => new SparseVectorStorageType((global::G.SparseVectorStorageTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SparseVectorStorageTypeVariant2?(SparseVectorStorageType @this) => @this.SparseVectorStorageTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SparseVectorStorageType(global::G.SparseVectorStorageTypeVariant2? value)
        {
            SparseVectorStorageTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SparseVectorStorageType(
            global::G.SparseVectorStorageTypeVariant1? sparseVectorStorageTypeVariant1,
            global::G.SparseVectorStorageTypeVariant2? sparseVectorStorageTypeVariant2
            )
        {
            SparseVectorStorageTypeVariant1 = sparseVectorStorageTypeVariant1;
            SparseVectorStorageTypeVariant2 = sparseVectorStorageTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SparseVectorStorageTypeVariant2 as object ??
            SparseVectorStorageTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SparseVectorStorageTypeVariant1?.ToValueString() ??
            SparseVectorStorageTypeVariant2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSparseVectorStorageTypeVariant1 && !IsSparseVectorStorageTypeVariant2 || !IsSparseVectorStorageTypeVariant1 && IsSparseVectorStorageTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.SparseVectorStorageTypeVariant1?, TResult>? sparseVectorStorageTypeVariant1 = null,
            global::System.Func<global::G.SparseVectorStorageTypeVariant2?, TResult>? sparseVectorStorageTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSparseVectorStorageTypeVariant1 && sparseVectorStorageTypeVariant1 != null)
            {
                return sparseVectorStorageTypeVariant1(SparseVectorStorageTypeVariant1!);
            }
            else if (IsSparseVectorStorageTypeVariant2 && sparseVectorStorageTypeVariant2 != null)
            {
                return sparseVectorStorageTypeVariant2(SparseVectorStorageTypeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.SparseVectorStorageTypeVariant1?>? sparseVectorStorageTypeVariant1 = null,
            global::System.Action<global::G.SparseVectorStorageTypeVariant2?>? sparseVectorStorageTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSparseVectorStorageTypeVariant1)
            {
                sparseVectorStorageTypeVariant1?.Invoke(SparseVectorStorageTypeVariant1!);
            }
            else if (IsSparseVectorStorageTypeVariant2)
            {
                sparseVectorStorageTypeVariant2?.Invoke(SparseVectorStorageTypeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SparseVectorStorageTypeVariant1,
                typeof(global::G.SparseVectorStorageTypeVariant1),
                SparseVectorStorageTypeVariant2,
                typeof(global::G.SparseVectorStorageTypeVariant2),
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
        public bool Equals(SparseVectorStorageType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.SparseVectorStorageTypeVariant1?>.Default.Equals(SparseVectorStorageTypeVariant1, other.SparseVectorStorageTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SparseVectorStorageTypeVariant2?>.Default.Equals(SparseVectorStorageTypeVariant2, other.SparseVectorStorageTypeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SparseVectorStorageType obj1, SparseVectorStorageType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SparseVectorStorageType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SparseVectorStorageType obj1, SparseVectorStorageType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SparseVectorStorageType o && Equals(o);
        }
    }
}
