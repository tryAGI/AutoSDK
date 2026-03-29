//HintName: G.Models.OrderValue.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrderValue : global::System.IEquatable<OrderValue>
    {
        /// <summary>
        /// Example: 42
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
        /// Example: 42.5F
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
        public static implicit operator OrderValue(long value) => new OrderValue((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(OrderValue @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public OrderValue(long? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderValue(double value) => new OrderValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(OrderValue @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public OrderValue(double? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrderValue(
            long? value1,
            double? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<long?, TResult>? value1 = null,
            global::System.Func<double?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<long?>? value1 = null,
            global::System.Action<double?>? value2 = null,
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
        public bool Equals(OrderValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrderValue obj1, OrderValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrderValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrderValue obj1, OrderValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrderValue o && Equals(o);
        }
    }
}
