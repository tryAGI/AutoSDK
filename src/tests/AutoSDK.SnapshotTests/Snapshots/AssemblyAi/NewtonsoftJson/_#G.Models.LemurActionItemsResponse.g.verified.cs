//HintName: G.Models.LemurActionItemsResponse.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurActionItemsResponse : global::System.IEquatable<LemurActionItemsResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurStringResponse? String { get; init; }
#else
        public global::G.LemurStringResponse? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurActionItemsResponse(global::G.LemurStringResponse value) => new LemurActionItemsResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurStringResponse?(LemurActionItemsResponse @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public LemurActionItemsResponse(global::G.LemurStringResponse? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurStringResponse?, TResult>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurStringResponse?>? @string = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.LemurStringResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(LemurActionItemsResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurStringResponse?>.Default.Equals(String, other.String) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurActionItemsResponse obj1, LemurActionItemsResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurActionItemsResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurActionItemsResponse obj1, LemurActionItemsResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurActionItemsResponse o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.LemurActionItemsResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LemurActionItemsResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
