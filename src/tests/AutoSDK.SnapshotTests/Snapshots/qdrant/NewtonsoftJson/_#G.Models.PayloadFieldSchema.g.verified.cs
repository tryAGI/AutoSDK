//HintName: G.Models.PayloadFieldSchema.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PayloadFieldSchema : global::System.IEquatable<PayloadFieldSchema>
    {
        /// <summary>
        /// All possible names of payload types
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadSchemaType? Type { get; init; }
#else
        public global::G.PayloadSchemaType? Type { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Type))]
#endif
        public bool IsType => Type != null;

        /// <summary>
        /// Payload type with parameters
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PayloadSchemaParams? Params { get; init; }
#else
        public global::G.PayloadSchemaParams? Params { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Params))]
#endif
        public bool IsParams => Params != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadFieldSchema(global::G.PayloadSchemaType value) => new PayloadFieldSchema((global::G.PayloadSchemaType?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadSchemaType?(PayloadFieldSchema @this) => @this.Type;

        /// <summary>
        /// 
        /// </summary>
        public PayloadFieldSchema(global::G.PayloadSchemaType? value)
        {
            Type = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PayloadFieldSchema(global::G.PayloadSchemaParams value) => new PayloadFieldSchema((global::G.PayloadSchemaParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PayloadSchemaParams?(PayloadFieldSchema @this) => @this.Params;

        /// <summary>
        /// 
        /// </summary>
        public PayloadFieldSchema(global::G.PayloadSchemaParams? value)
        {
            Params = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PayloadFieldSchema(
            global::G.PayloadSchemaType? type,
            global::G.PayloadSchemaParams? @params
            )
        {
            Type = type;
            Params = @params;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Params as object ??
            Type as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Type?.ToValueString() ??
            Params?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsType || IsParams;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PayloadSchemaType?, TResult>? type = null,
            global::System.Func<global::G.PayloadSchemaParams?, TResult>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsType && type != null)
            {
                return type(Type!);
            }
            else if (IsParams && @params != null)
            {
                return @params(Params!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PayloadSchemaType?>? type = null,
            global::System.Action<global::G.PayloadSchemaParams?>? @params = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsType)
            {
                type?.Invoke(Type!);
            }
            else if (IsParams)
            {
                @params?.Invoke(Params!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Type,
                typeof(global::G.PayloadSchemaType),
                Params,
                typeof(global::G.PayloadSchemaParams),
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
        public bool Equals(PayloadFieldSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadSchemaType?>.Default.Equals(Type, other.Type) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PayloadSchemaParams?>.Default.Equals(Params, other.Params) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PayloadFieldSchema obj1, PayloadFieldSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PayloadFieldSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PayloadFieldSchema obj1, PayloadFieldSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PayloadFieldSchema o && Equals(o);
        }
    }
}
