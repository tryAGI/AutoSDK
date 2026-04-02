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
        public global::G.RawWhereFields? RawWhereFields { get; init; }
#else
        public global::G.RawWhereFields? RawWhereFields { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RawWhereFields))]
#endif
        public bool IsRawWhereFields => RawWhereFields != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GetRequestPayloadVariant2? GetRequestPayloadVariant2 { get; init; }
#else
        public global::G.GetRequestPayloadVariant2? GetRequestPayloadVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GetRequestPayloadVariant2))]
#endif
        public bool IsGetRequestPayloadVariant2 => GetRequestPayloadVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRequestPayload(global::G.RawWhereFields value) => new GetRequestPayload((global::G.RawWhereFields?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RawWhereFields?(GetRequestPayload @this) => @this.RawWhereFields;

        /// <summary>
        /// 
        /// </summary>
        public GetRequestPayload(global::G.RawWhereFields? value)
        {
            RawWhereFields = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetRequestPayload(global::G.GetRequestPayloadVariant2 value) => new GetRequestPayload((global::G.GetRequestPayloadVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GetRequestPayloadVariant2?(GetRequestPayload @this) => @this.GetRequestPayloadVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GetRequestPayload(global::G.GetRequestPayloadVariant2? value)
        {
            GetRequestPayloadVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetRequestPayload(
            global::G.RawWhereFields? rawWhereFields,
            global::G.GetRequestPayloadVariant2? getRequestPayloadVariant2
            )
        {
            RawWhereFields = rawWhereFields;
            GetRequestPayloadVariant2 = getRequestPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GetRequestPayloadVariant2 as object ??
            RawWhereFields as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RawWhereFields?.ToString() ??
            GetRequestPayloadVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRawWhereFields && IsGetRequestPayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.RawWhereFields?, TResult>? rawWhereFields = null,
            global::System.Func<global::G.GetRequestPayloadVariant2?, TResult>? getRequestPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawWhereFields && rawWhereFields != null)
            {
                return rawWhereFields(RawWhereFields!);
            }
            else if (IsGetRequestPayloadVariant2 && getRequestPayloadVariant2 != null)
            {
                return getRequestPayloadVariant2(GetRequestPayloadVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.RawWhereFields?>? rawWhereFields = null,
            global::System.Action<global::G.GetRequestPayloadVariant2?>? getRequestPayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRawWhereFields)
            {
                rawWhereFields?.Invoke(RawWhereFields!);
            }
            else if (IsGetRequestPayloadVariant2)
            {
                getRequestPayloadVariant2?.Invoke(GetRequestPayloadVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RawWhereFields,
                typeof(global::G.RawWhereFields),
                GetRequestPayloadVariant2,
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
                global::System.Collections.Generic.EqualityComparer<global::G.RawWhereFields?>.Default.Equals(RawWhereFields, other.RawWhereFields) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GetRequestPayloadVariant2?>.Default.Equals(GetRequestPayloadVariant2, other.GetRequestPayloadVariant2) 
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
