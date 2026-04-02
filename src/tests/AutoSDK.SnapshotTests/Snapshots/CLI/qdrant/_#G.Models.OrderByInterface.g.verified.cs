//HintName: G.Models.OrderByInterface.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrderByInterface : global::System.IEquatable<OrderByInterface>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? OrderByInterfaceVariant1 { get; init; }
#else
        public string? OrderByInterfaceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrderByInterfaceVariant1))]
#endif
        public bool IsOrderByInterfaceVariant1 => OrderByInterfaceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OrderBy? OrderBy { get; init; }
#else
        public global::G.OrderBy? OrderBy { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrderBy))]
#endif
        public bool IsOrderBy => OrderBy != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderByInterface(string value) => new OrderByInterface((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(OrderByInterface @this) => @this.OrderByInterfaceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public OrderByInterface(string? value)
        {
            OrderByInterfaceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderByInterface(global::G.OrderBy value) => new OrderByInterface((global::G.OrderBy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OrderBy?(OrderByInterface @this) => @this.OrderBy;

        /// <summary>
        /// 
        /// </summary>
        public OrderByInterface(global::G.OrderBy? value)
        {
            OrderBy = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrderByInterface(
            string? orderByInterfaceVariant1,
            global::G.OrderBy? orderBy
            )
        {
            OrderByInterfaceVariant1 = orderByInterfaceVariant1;
            OrderBy = orderBy;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrderBy as object ??
            OrderByInterfaceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OrderByInterfaceVariant1?.ToString() ??
            OrderBy?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrderByInterfaceVariant1 || IsOrderBy;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? orderByInterfaceVariant1 = null,
            global::System.Func<global::G.OrderBy?, TResult>? orderBy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrderByInterfaceVariant1 && orderByInterfaceVariant1 != null)
            {
                return orderByInterfaceVariant1(OrderByInterfaceVariant1!);
            }
            else if (IsOrderBy && orderBy != null)
            {
                return orderBy(OrderBy!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? orderByInterfaceVariant1 = null,
            global::System.Action<global::G.OrderBy?>? orderBy = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrderByInterfaceVariant1)
            {
                orderByInterfaceVariant1?.Invoke(OrderByInterfaceVariant1!);
            }
            else if (IsOrderBy)
            {
                orderBy?.Invoke(OrderBy!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrderByInterfaceVariant1,
                typeof(string),
                OrderBy,
                typeof(global::G.OrderBy),
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
        public bool Equals(OrderByInterface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(OrderByInterfaceVariant1, other.OrderByInterfaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OrderBy?>.Default.Equals(OrderBy, other.OrderBy) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrderByInterface obj1, OrderByInterface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrderByInterface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrderByInterface obj1, OrderByInterface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrderByInterface o && Equals(o);
        }
    }
}
