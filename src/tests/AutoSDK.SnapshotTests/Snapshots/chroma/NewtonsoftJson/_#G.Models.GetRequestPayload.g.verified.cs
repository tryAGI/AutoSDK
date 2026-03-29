//HintName: G.Models.GetRequestPayload.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Records can be retrieved by their IDs or by a metadata filter. At least one of `ids` or `where`<br/>
    /// must be provided. Use `include` to specify which fields to return in the response.
    /// </summary>
    public readonly partial struct GetRequestPayload : global::System.IEquatable<GetRequestPayload>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RawWhereFields? Value1 { get; init; }
#else
        public global::G.RawWhereFields? Value1 { get; }
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
        public global::G.GetRequestPayloadVariant2? Value2 { get; init; }
#else
        public global::G.GetRequestPayloadVariant2? Value2 { get; }
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
        public static implicit operator GetRequestPayload(global::G.RawWhereFields value) => new GetRequestPayload((global::G.RawWhereFields?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RawWhereFields?(GetRequestPayload @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public GetRequestPayload(global::G.RawWhereFields? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRequestPayload(global::G.GetRequestPayloadVariant2 value) => new GetRequestPayload((global::G.GetRequestPayloadVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetRequestPayloadVariant2?(GetRequestPayload @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public GetRequestPayload(global::G.GetRequestPayloadVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetRequestPayload(
            global::G.RawWhereFields? value1,
            global::G.GetRequestPayloadVariant2? value2
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
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RawWhereFields?, TResult>? value1 = null,
            global::System.Func<global::G.GetRequestPayloadVariant2?, TResult>? value2 = null,
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
            global::System.Action<global::G.RawWhereFields?>? value1 = null,
            global::System.Action<global::G.GetRequestPayloadVariant2?>? value2 = null,
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
                typeof(global::G.RawWhereFields),
                Value2,
                typeof(global::G.GetRequestPayloadVariant2),
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
        public bool Equals(GetRequestPayload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.RawWhereFields?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetRequestPayloadVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetRequestPayload obj1, GetRequestPayload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetRequestPayload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetRequestPayload obj1, GetRequestPayload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetRequestPayload o && Equals(o);
        }
    }
}
