//HintName: G.Models.VectorStoreFileObjectChunkingStrategy.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The strategy used to chunk the file.
    /// </summary>
    public readonly partial struct VectorStoreFileObjectChunkingStrategy : global::System.IEquatable<VectorStoreFileObjectChunkingStrategy>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.VectorStoreFileObjectChunkingStrategyDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.StaticChunkingStrategyResponseParam? StaticResponseParam { get; init; }
#else
        public global::G.StaticChunkingStrategyResponseParam? StaticResponseParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticResponseParam))]
#endif
        public bool IsStaticResponseParam => StaticResponseParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStoreFileObjectChunkingStrategy(global::G.StaticChunkingStrategyResponseParam value) => new VectorStoreFileObjectChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.StaticChunkingStrategyResponseParam?(VectorStoreFileObjectChunkingStrategy @this) => @this.StaticResponseParam;

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(global::G.StaticChunkingStrategyResponseParam? value)
        {
            StaticResponseParam = value;
        }

        /// <summary>
        /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OtherChunkingStrategyResponseParam? OtherResponseParam { get; init; }
#else
        public global::G.OtherChunkingStrategyResponseParam? OtherResponseParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OtherResponseParam))]
#endif
        public bool IsOtherResponseParam => OtherResponseParam != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorStoreFileObjectChunkingStrategy(global::G.OtherChunkingStrategyResponseParam value) => new VectorStoreFileObjectChunkingStrategy(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OtherChunkingStrategyResponseParam?(VectorStoreFileObjectChunkingStrategy @this) => @this.OtherResponseParam;

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(global::G.OtherChunkingStrategyResponseParam? value)
        {
            OtherResponseParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreFileObjectChunkingStrategy(
            global::G.VectorStoreFileObjectChunkingStrategyDiscriminatorType? type,
            global::G.StaticChunkingStrategyResponseParam? staticResponseParam,
            global::G.OtherChunkingStrategyResponseParam? otherResponseParam
            )
        {
            Type = type;

            StaticResponseParam = staticResponseParam;
            OtherResponseParam = otherResponseParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OtherResponseParam as object ??
            StaticResponseParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStaticResponseParam && !IsOtherResponseParam || !IsStaticResponseParam && IsOtherResponseParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.StaticChunkingStrategyResponseParam?, TResult>? staticResponseParam = null,
            global::System.Func<global::G.OtherChunkingStrategyResponseParam?, TResult>? otherResponseParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStaticResponseParam && staticResponseParam != null)
            {
                return staticResponseParam(StaticResponseParam!);
            }
            else if (IsOtherResponseParam && otherResponseParam != null)
            {
                return otherResponseParam(OtherResponseParam!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.StaticChunkingStrategyResponseParam?>? staticResponseParam = null,
            global::System.Action<global::G.OtherChunkingStrategyResponseParam?>? otherResponseParam = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStaticResponseParam)
            {
                staticResponseParam?.Invoke(StaticResponseParam!);
            }
            else if (IsOtherResponseParam)
            {
                otherResponseParam?.Invoke(OtherResponseParam!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StaticResponseParam,
                typeof(global::G.StaticChunkingStrategyResponseParam),
                OtherResponseParam,
                typeof(global::G.OtherChunkingStrategyResponseParam),
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
        public bool Equals(VectorStoreFileObjectChunkingStrategy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.StaticChunkingStrategyResponseParam?>.Default.Equals(StaticResponseParam, other.StaticResponseParam) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OtherChunkingStrategyResponseParam?>.Default.Equals(OtherResponseParam, other.OtherResponseParam) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorStoreFileObjectChunkingStrategy obj1, VectorStoreFileObjectChunkingStrategy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorStoreFileObjectChunkingStrategy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorStoreFileObjectChunkingStrategy obj1, VectorStoreFileObjectChunkingStrategy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorStoreFileObjectChunkingStrategy o && Equals(o);
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
        public static global::G.VectorStoreFileObjectChunkingStrategy? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.VectorStoreFileObjectChunkingStrategy>(
                json,
                jsonSerializerOptions);
        }

    }
}
