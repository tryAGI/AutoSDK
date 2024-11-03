//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
    /// </summary>
    public readonly partial struct CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy : global::System.IEquatable<CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Auto { get; init; }
#else
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1 value) => new CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? value)
        {
            Auto = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Static { get; init; }
#else
        public global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? Static { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2 value) => new CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy(
            global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? type,
            global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1? auto,
            global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2? @static
            )
        {
            Type = type;

            Auto = auto;
            Static = @static;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Static as object ??
            Auto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuto && !IsStatic || !IsAuto && IsStatic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?, TResult>? auto = null,
            global::System.Func<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?, TResult>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }
            else if (IsStatic && @static != null)
            {
                return @static(Static!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>? auto = null,
            global::System.Action<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>? @static = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
            else if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Auto,
                typeof(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1),
                Static,
                typeof(global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2),
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
        public bool Equals(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2?>.Default.Equals(Static, other.Static) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj1, CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy o && Equals(o);
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
        public static global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy?>(serializer.Deserialize<global::G.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategy>(jsonReader));
        }

    }
}
