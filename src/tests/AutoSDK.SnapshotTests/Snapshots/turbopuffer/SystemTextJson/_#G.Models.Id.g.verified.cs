//HintName: G.Models.Id.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier for a document.
    /// </summary>
    public readonly partial struct Id : global::System.IEquatable<Id>
    {
        /// <summary>
        /// A UUID.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Guid? Value1 { get; init; }
#else
        public global::System.Guid? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// A string ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// An integer ID.
        /// </summary>
#if NET6_0_OR_GREATER
        public int? Value3 { get; init; }
#else
        public int? Value3 { get; }
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
        public static implicit operator Id(global::System.Guid value) => new Id((global::System.Guid?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Guid?(Id @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Id(global::System.Guid? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Id(string value) => new Id((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(Id @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Id(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Id(int value) => new Id((int?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator int?(Id @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Id(int? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Id(
            global::System.Guid? value1,
            string? value2,
            int? value3
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
            global::System.Func<global::System.Guid?, TResult>? value1 = null,
            global::System.Func<string?, TResult>? value2 = null,
            global::System.Func<int?, TResult>? value3 = null,
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
            global::System.Action<global::System.Guid?>? value1 = null,
            global::System.Action<string?>? value2 = null,
            global::System.Action<int?>? value3 = null,
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
                typeof(global::System.Guid),
                Value2,
                typeof(string),
                Value3,
                typeof(int),
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
        public bool Equals(Id other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Guid?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Id obj1, Id obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Id>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Id obj1, Id obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Id o && Equals(o);
        }
    }
}
