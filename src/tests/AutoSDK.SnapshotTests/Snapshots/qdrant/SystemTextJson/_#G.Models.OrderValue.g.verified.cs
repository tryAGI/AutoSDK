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
        public long? OrderValueVariant1 { get; init; }
#else
        public long? OrderValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrderValueVariant1))]
#endif
        public bool IsOrderValueVariant1 => OrderValueVariant1 != null;

        /// <summary>
        /// Example: 42.5F
        /// </summary>
#if NET6_0_OR_GREATER
        public double? OrderValueVariant2 { get; init; }
#else
        public double? OrderValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrderValueVariant2))]
#endif
        public bool IsOrderValueVariant2 => OrderValueVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderValue(long value) => new OrderValue((long?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator long?(OrderValue @this) => @this.OrderValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public OrderValue(long? value)
        {
            OrderValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderValue(double value) => new OrderValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(OrderValue @this) => @this.OrderValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OrderValue(double? value)
        {
            OrderValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrderValue(
            long? orderValueVariant1,
            double? orderValueVariant2
            )
        {
            OrderValueVariant1 = orderValueVariant1;
            OrderValueVariant2 = orderValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrderValueVariant2 as object ??
            OrderValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OrderValueVariant1?.ToString() ??
            OrderValueVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrderValueVariant1 || IsOrderValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<long?, TResult>? orderValueVariant1 = null,
            global::System.Func<double?, TResult>? orderValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrderValueVariant1 && orderValueVariant1 != null)
            {
                return orderValueVariant1(OrderValueVariant1!);
            }
            else if (IsOrderValueVariant2 && orderValueVariant2 != null)
            {
                return orderValueVariant2(OrderValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<long?>? orderValueVariant1 = null,
            global::System.Action<double?>? orderValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrderValueVariant1)
            {
                orderValueVariant1?.Invoke(OrderValueVariant1!);
            }
            else if (IsOrderValueVariant2)
            {
                orderValueVariant2?.Invoke(OrderValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrderValueVariant1,
                typeof(long),
                OrderValueVariant2,
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
                global::System.Collections.Generic.EqualityComparer<long?>.Default.Equals(OrderValueVariant1, other.OrderValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(OrderValueVariant2, other.OrderValueVariant2) 
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
