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
        public global::G.VectorStorageTypeVariant1? Value1 { get; init; }
#else
        public global::G.VectorStorageTypeVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Storage in mmap file, not appendable<br/>
        /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant2? Value2 { get; init; }
#else
        public global::G.VectorStorageTypeVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// Storage in chunked mmap files, appendable<br/>
        /// Search performance is defined by disk speed and the fraction of vectors that fit in memory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant3? Value3 { get; init; }
#else
        public global::G.VectorStorageTypeVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// Same as `ChunkedMmap`, but vectors are forced to be locked in RAM In this way we avoid cold requests to disk, but risk to run out of memory<br/>
        /// Designed as a replacement for `Memory`, which doesn't depend on RocksDB
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant4? Value4 { get; init; }
#else
        public global::G.VectorStorageTypeVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// Storage in a single mmap file, not appendable Pre-fetched into RAM on load
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.VectorStorageTypeVariant5? Value5 { get; init; }
#else
        public global::G.VectorStorageTypeVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant1 value) => new VectorStorageType((global::G.VectorStorageTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant1?(VectorStorageType @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant2 value) => new VectorStorageType((global::G.VectorStorageTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant2?(VectorStorageType @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant3 value) => new VectorStorageType((global::G.VectorStorageTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant3?(VectorStorageType @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant4 value) => new VectorStorageType((global::G.VectorStorageTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant4?(VectorStorageType @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStorageType(global::G.VectorStorageTypeVariant5 value) => new VectorStorageType((global::G.VectorStorageTypeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.VectorStorageTypeVariant5?(VectorStorageType @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(global::G.VectorStorageTypeVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStorageType(
            global::G.VectorStorageTypeVariant1? value1,
            global::G.VectorStorageTypeVariant2? value2,
            global::G.VectorStorageTypeVariant3? value3,
            global::G.VectorStorageTypeVariant4? value4,
            global::G.VectorStorageTypeVariant5? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToValueString() ??
            Value3?.ToValueString() ??
            Value4?.ToValueString() ??
            Value5?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.VectorStorageTypeVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.VectorStorageTypeVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.VectorStorageTypeVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.VectorStorageTypeVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.VectorStorageTypeVariant5?, TResult>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.VectorStorageTypeVariant1?>? value1 = null,
            global::System.Action<global::G.VectorStorageTypeVariant2?>? value2 = null,
            global::System.Action<global::G.VectorStorageTypeVariant3?>? value3 = null,
            global::System.Action<global::G.VectorStorageTypeVariant4?>? value4 = null,
            global::System.Action<global::G.VectorStorageTypeVariant5?>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.VectorStorageTypeVariant1),
                Value2,
                typeof(global::G.VectorStorageTypeVariant2),
                Value3,
                typeof(global::G.VectorStorageTypeVariant3),
                Value4,
                typeof(global::G.VectorStorageTypeVariant4),
                Value5,
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
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.VectorStorageTypeVariant5?>.Default.Equals(Value5, other.Value5) 
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
