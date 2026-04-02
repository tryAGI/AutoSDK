//HintName: G.Models.VectorStorageType.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Storage types for vectors
    /// </summary>
    public readonly partial struct VectorStorageType : global::System.IEquatable<VectorStorageType>
    {
        /// <summary>
        /// Storage in memory (RAM)<br/>
        /// Will be very fast at the cost of consuming a lot of memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant1? VectorStorageTypeVariant1 { get; init; }
#else
        public global::G.VectorStorageTypeVariant1? VectorStorageTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant1))]
#endif
        public bool IsVectorStorageTypeVariant1 => VectorStorageTypeVariant1 != null;

        /// <summary>
        /// Storage in mmap file, not appendable<br/>
        /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant2? VectorStorageTypeVariant2 { get; init; }
#else
        public global::G.VectorStorageTypeVariant2? VectorStorageTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant2))]
#endif
        public bool IsVectorStorageTypeVariant2 => VectorStorageTypeVariant2 != null;

        /// <summary>
        /// Storage in chunked mmap files, appendable<br/>
        /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant3? VectorStorageTypeVariant3 { get; init; }
#else
        public global::G.VectorStorageTypeVariant3? VectorStorageTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant3))]
#endif
        public bool IsVectorStorageTypeVariant3 => VectorStorageTypeVariant3 != null;

        /// <summary>
        /// Same as `ChunkedMmap`, but vectors are forced to be locked in RAM In this way we avoid cold requests to disk, but risk to run out of memory<br/>
        /// Designed as a replacement for `Memory`, which doesn't depend on RocksDB
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant4? VectorStorageTypeVariant4 { get; init; }
#else
        public global::G.VectorStorageTypeVariant4? VectorStorageTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant4))]
#endif
        public bool IsVectorStorageTypeVariant4 => VectorStorageTypeVariant4 != null;

        /// <summary>
        /// Storage in a single mmap file, not appendable Pre-fetched into RAM on load
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant5? VectorStorageTypeVariant5 { get; init; }
#else
        public global::G.VectorStorageTypeVariant5? VectorStorageTypeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorStorageTypeVariant5))]
#endif
        public bool IsVectorStorageTypeVariant5 => VectorStorageTypeVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant1 value) => new VectorStorageType((global::G.VectorStorageTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant1?(VectorStorageType @this) => @this.VectorStorageTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant1? value)
        {
            VectorStorageTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant2 value) => new VectorStorageType((global::G.VectorStorageTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant2?(VectorStorageType @this) => @this.VectorStorageTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant2? value)
        {
            VectorStorageTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant3 value) => new VectorStorageType((global::G.VectorStorageTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant3?(VectorStorageType @this) => @this.VectorStorageTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant3? value)
        {
            VectorStorageTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant4 value) => new VectorStorageType((global::G.VectorStorageTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant4?(VectorStorageType @this) => @this.VectorStorageTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant4? value)
        {
            VectorStorageTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant5 value) => new VectorStorageType((global::G.VectorStorageTypeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant5?(VectorStorageType @this) => @this.VectorStorageTypeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant5? value)
        {
            VectorStorageTypeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(
            global::G.VectorStorageTypeVariant1? vectorStorageTypeVariant1,
            global::G.VectorStorageTypeVariant2? vectorStorageTypeVariant2,
            global::G.VectorStorageTypeVariant3? vectorStorageTypeVariant3,
            global::G.VectorStorageTypeVariant4? vectorStorageTypeVariant4,
            global::G.VectorStorageTypeVariant5? vectorStorageTypeVariant5
            )
        {
            VectorStorageTypeVariant1 = vectorStorageTypeVariant1;
            VectorStorageTypeVariant2 = vectorStorageTypeVariant2;
            VectorStorageTypeVariant3 = vectorStorageTypeVariant3;
            VectorStorageTypeVariant4 = vectorStorageTypeVariant4;
            VectorStorageTypeVariant5 = vectorStorageTypeVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorStorageTypeVariant5 as object ??
            VectorStorageTypeVariant4 as object ??
            VectorStorageTypeVariant3 as object ??
            VectorStorageTypeVariant2 as object ??
            VectorStorageTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VectorStorageTypeVariant1?.ToValueString() ??
            VectorStorageTypeVariant2?.ToValueString() ??
            VectorStorageTypeVariant3?.ToValueString() ??
            VectorStorageTypeVariant4?.ToValueString() ??
            VectorStorageTypeVariant5?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 || !IsVectorStorageTypeVariant1 && IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && IsVectorStorageTypeVariant4 && !IsVectorStorageTypeVariant5 || !IsVectorStorageTypeVariant1 && !IsVectorStorageTypeVariant2 && !IsVectorStorageTypeVariant3 && !IsVectorStorageTypeVariant4 && IsVectorStorageTypeVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VectorStorageTypeVariant1?, TResult>? vectorStorageTypeVariant1 = null,
            global::System.Func<global::G.VectorStorageTypeVariant2?, TResult>? vectorStorageTypeVariant2 = null,
            global::System.Func<global::G.VectorStorageTypeVariant3?, TResult>? vectorStorageTypeVariant3 = null,
            global::System.Func<global::G.VectorStorageTypeVariant4?, TResult>? vectorStorageTypeVariant4 = null,
            global::System.Func<global::G.VectorStorageTypeVariant5?, TResult>? vectorStorageTypeVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStorageTypeVariant1 && vectorStorageTypeVariant1 != null)
            {
                return vectorStorageTypeVariant1(VectorStorageTypeVariant1!);
            }
            else if (IsVectorStorageTypeVariant2 && vectorStorageTypeVariant2 != null)
            {
                return vectorStorageTypeVariant2(VectorStorageTypeVariant2!);
            }
            else if (IsVectorStorageTypeVariant3 && vectorStorageTypeVariant3 != null)
            {
                return vectorStorageTypeVariant3(VectorStorageTypeVariant3!);
            }
            else if (IsVectorStorageTypeVariant4 && vectorStorageTypeVariant4 != null)
            {
                return vectorStorageTypeVariant4(VectorStorageTypeVariant4!);
            }
            else if (IsVectorStorageTypeVariant5 && vectorStorageTypeVariant5 != null)
            {
                return vectorStorageTypeVariant5(VectorStorageTypeVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VectorStorageTypeVariant1?>? vectorStorageTypeVariant1 = null,
            global::System.Action<global::G.VectorStorageTypeVariant2?>? vectorStorageTypeVariant2 = null,
            global::System.Action<global::G.VectorStorageTypeVariant3?>? vectorStorageTypeVariant3 = null,
            global::System.Action<global::G.VectorStorageTypeVariant4?>? vectorStorageTypeVariant4 = null,
            global::System.Action<global::G.VectorStorageTypeVariant5?>? vectorStorageTypeVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVectorStorageTypeVariant1)
            {
                vectorStorageTypeVariant1?.Invoke(VectorStorageTypeVariant1!);
            }
            else if (IsVectorStorageTypeVariant2)
            {
                vectorStorageTypeVariant2?.Invoke(VectorStorageTypeVariant2!);
            }
            else if (IsVectorStorageTypeVariant3)
            {
                vectorStorageTypeVariant3?.Invoke(VectorStorageTypeVariant3!);
            }
            else if (IsVectorStorageTypeVariant4)
            {
                vectorStorageTypeVariant4?.Invoke(VectorStorageTypeVariant4!);
            }
            else if (IsVectorStorageTypeVariant5)
            {
                vectorStorageTypeVariant5?.Invoke(VectorStorageTypeVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VectorStorageTypeVariant1,
                typeof(global::G.VectorStorageTypeVariant1),
                VectorStorageTypeVariant2,
                typeof(global::G.VectorStorageTypeVariant2),
                VectorStorageTypeVariant3,
                typeof(global::G.VectorStorageTypeVariant3),
                VectorStorageTypeVariant4,
                typeof(global::G.VectorStorageTypeVariant4),
                VectorStorageTypeVariant5,
                typeof(global::G.VectorStorageTypeVariant5),
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
        public bool Equals(VectorStorageType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant1?>.Default.Equals(VectorStorageTypeVariant1, other.VectorStorageTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant2?>.Default.Equals(VectorStorageTypeVariant2, other.VectorStorageTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant3?>.Default.Equals(VectorStorageTypeVariant3, other.VectorStorageTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant4?>.Default.Equals(VectorStorageTypeVariant4, other.VectorStorageTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant5?>.Default.Equals(VectorStorageTypeVariant5, other.VectorStorageTypeVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStorageType obj1, VectorStorageType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStorageType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStorageType obj1, VectorStorageType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStorageType o && Equals(o);
        }
    }
}
