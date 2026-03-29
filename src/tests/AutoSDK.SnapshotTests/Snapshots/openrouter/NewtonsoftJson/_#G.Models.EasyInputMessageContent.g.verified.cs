//HintName: G.Models.EasyInputMessageContent.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EasyInputMessageContent : global::System.IEquatable<EasyInputMessageContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>? EasyInputMessageContent0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>? EasyInputMessageContent0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessageContent0))]
#endif
        public bool IsEasyInputMessageContent0 => EasyInputMessageContent0 != null;

        /// <summary>
        /// 
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
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
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
        public static implicit operator EasyInputMessageContent(string value) => new EasyInputMessageContent((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EasyInputMessageContent @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContent(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EasyInputMessageContent(
            global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>? easyInputMessageContent0,
            string? value2,
            object? value3
            )
        {
            EasyInputMessageContent0 = easyInputMessageContent0;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            Value2 as object ??
            EasyInputMessageContent0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EasyInputMessageContent0?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEasyInputMessageContent0 && !IsValue2 && !IsValue3 || !IsEasyInputMessageContent0 && IsValue2 && !IsValue3 || !IsEasyInputMessageContent0 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>?, TResult>? easyInputMessageContent0 = null,
            global::System.Func<string?, TResult>? value2 = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageContent0 && easyInputMessageContent0 != null)
            {
                return easyInputMessageContent0(EasyInputMessageContent0!);
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
            global::System.Action<global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>?>? easyInputMessageContent0 = null,
            global::System.Action<string?>? value2 = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEasyInputMessageContent0)
            {
                easyInputMessageContent0?.Invoke(EasyInputMessageContent0!);
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
                EasyInputMessageContent0,
                typeof(global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>),
                Value2,
                typeof(string),
                Value3,
                typeof(object),
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
        public bool Equals(EasyInputMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.EasyInputMessageContentOneOf0Items>?>.Default.Equals(EasyInputMessageContent0, other.EasyInputMessageContent0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EasyInputMessageContent obj1, EasyInputMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EasyInputMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EasyInputMessageContent obj1, EasyInputMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EasyInputMessageContent o && Equals(o);
        }
    }
}
