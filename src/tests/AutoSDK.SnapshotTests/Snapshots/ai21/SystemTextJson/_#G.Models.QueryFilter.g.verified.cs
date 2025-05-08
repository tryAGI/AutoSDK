//HintName: G.Models.QueryFilter.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct QueryFilter : global::System.IEquatable<QueryFilter>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value1 { get; init; }
#else
        public object? Value1 { get; }
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
        public QueryFilter(object? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? Value2 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? Value2 { get; }
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
        public static implicit operator QueryFilter(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>> value) => new QueryFilter((global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?(QueryFilter @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, object>? Value3 { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, object>? Value3 { get; }
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
        public static implicit operator QueryFilter(global::System.Collections.Generic.Dictionary<string, object> value) => new QueryFilter((global::System.Collections.Generic.Dictionary<string, object>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, object>?(QueryFilter @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(global::System.Collections.Generic.Dictionary<string, object>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public QueryFilter(
            object? value1,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? value2,
            global::System.Collections.Generic.Dictionary<string, object>? value3
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
            global::System.Func<object?, TResult>? value1 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?, TResult>? value2 = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, object>?, TResult>? value3 = null,
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
            global::System.Action<object?>? value1 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?>? value2 = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, object>?>? value3 = null,
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
                typeof(object),
                Value2,
                typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>),
                Value3,
                typeof(global::System.Collections.Generic.Dictionary<string, object>),
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
        public bool Equals(QueryFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, object>?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(QueryFilter obj1, QueryFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<QueryFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(QueryFilter obj1, QueryFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is QueryFilter o && Equals(o);
        }
    }
}
