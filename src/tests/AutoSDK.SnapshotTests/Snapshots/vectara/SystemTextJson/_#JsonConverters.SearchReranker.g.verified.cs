//HintName: JsonConverters.SearchReranker.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SearchRerankerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SearchReranker>
    {
        /// <inheritdoc />
        public override global::G.SearchReranker Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SearchRerankerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SearchRerankerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SearchRerankerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CustomerSpecificReranker? customerSpecific = default;
            if (discriminator?.Type == global::G.SearchRerankerDiscriminatorType.CustomerReranker)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomerSpecificReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomerSpecificReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CustomerSpecificReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.UserFunctionReranker? userFunction = default;
            if (discriminator?.Type == global::G.SearchRerankerDiscriminatorType.Userfn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserFunctionReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserFunctionReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UserFunctionReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.MMRReranker? mR = default;
            if (discriminator?.Type == global::G.SearchRerankerDiscriminatorType.Mmr)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MMRReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MMRReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.MMRReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ChainReranker? chain = default;
            if (discriminator?.Type == global::G.SearchRerankerDiscriminatorType.Chain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChainReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChainReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ChainReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.NoneReranker? none = default;
            if (discriminator?.Type == global::G.SearchRerankerDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NoneReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NoneReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.NoneReranker)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.SearchReranker(
                discriminator?.Type,
                customerSpecific,
                userFunction,
                mR,
                chain,
                none
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SearchReranker value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCustomerSpecific)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomerSpecificReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomerSpecificReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomerSpecificReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomerSpecific, typeInfo);
            }
            else if (value.IsUserFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserFunctionReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserFunctionReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserFunctionReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserFunction, typeInfo);
            }
            else if (value.IsMR)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MMRReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MMRReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MMRReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MR, typeInfo);
            }
            else if (value.IsChain)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChainReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChainReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChainReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Chain, typeInfo);
            }
            else if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NoneReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NoneReranker?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NoneReranker).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None, typeInfo);
            }
        }
    }
}