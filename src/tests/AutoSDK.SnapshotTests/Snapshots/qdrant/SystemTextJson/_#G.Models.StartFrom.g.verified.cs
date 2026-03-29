//HintName: G.Models.StartFrom.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StartFrom : global::System.IEquatable<StartFrom>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public long? Value1 { get; init; }
#else
        public long? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? Value2 { get; init; }
#else
        public double? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.DateTime? Value3 { get; init; }
#else
        public global::System.DateTime? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartFrom(long value) => new StartFrom((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(StartFrom @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(long? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartFrom(double value) => new StartFrom((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(StartFrom @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(double? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StartFrom(global::System.DateTime value) => new StartFrom((global::System.DateTime?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.DateTime?(StartFrom @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(global::System.DateTime? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public StartFrom(
            long? value1,
            double? value2,
            global::System.DateTime? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<long?, TResult>? value1 = null,
            global::System.Func<double?, TResult>? value2 = null,
            global::System.Func<global::System.DateTime?, TResult>? value3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<long?>? value1 = null,
            global::System.Action<double?>? value2 = null,
            global::System.Action<global::System.DateTime?>? value3 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(long),
                Value2,
                typeof(double),
                Value3,
                typeof(global::System.DateTime),
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
        public bool Equals(StartFrom other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.DateTime?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StartFrom obj1, StartFrom obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StartFrom>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StartFrom obj1, StartFrom obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StartFrom o && Equals(o);
        }
    }
}
