//HintName: G.Models.ExtendedPointId.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Type, used for specifying point ID in user interface
    /// </summary>
    public readonly partial struct ExtendedPointId : global::System.IEquatable<ExtendedPointId>
    {
        /// <summary>
        /// Example: 42
        /// </summary>
#if NET6_0_OR_GREATER
        public int? Value1 { get; init; }
#else
        public int? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Guid? Value2 { get; init; }
#else
        public global::System.Guid? Value2 { get; }
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
        public static implicit operator ExtendedPointId(int value) => new ExtendedPointId((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(ExtendedPointId @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ExtendedPointId(int? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExtendedPointId(global::System.Guid value) => new ExtendedPointId((global::System.Guid?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Guid?(ExtendedPointId @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ExtendedPointId(global::System.Guid? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExtendedPointId(
            int? value1,
            global::System.Guid? value2
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
            global::System.Func<int?, TResult>? value1 = null,
            global::System.Func<global::System.Guid?, TResult>? value2 = null,
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
            global::System.Action<int?>? value1 = null,
            global::System.Action<global::System.Guid?>? value2 = null,
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
                typeof(int),
                Value2,
                typeof(global::System.Guid),
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
        public bool Equals(ExtendedPointId other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Guid?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExtendedPointId obj1, ExtendedPointId obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExtendedPointId>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExtendedPointId obj1, ExtendedPointId obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtendedPointId o && Equals(o);
        }
    }
}
