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

            var
            readerCopy = reader;
            global::G.CustomerSpecificReranker? customerSpecific = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomerSpecificReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomerSpecificReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomerSpecificReranker).Name}");
                customerSpecific = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.UserFunctionReranker? userFunction = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserFunctionReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserFunctionReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserFunctionReranker).Name}");
                userFunction = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.MMRReranker? mR = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MMRReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MMRReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MMRReranker).Name}");
                mR = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChainReranker? chain = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChainReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChainReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChainReranker).Name}");
                chain = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.NoneReranker? none = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NoneReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NoneReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NoneReranker).Name}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.SearchReranker(
                customerSpecific,
                userFunction,
                mR,
                chain,
                none
                );

            if (customerSpecific != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CustomerSpecificReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CustomerSpecificReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CustomerSpecificReranker).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (userFunction != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UserFunctionReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UserFunctionReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UserFunctionReranker).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (mR != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MMRReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MMRReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MMRReranker).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (chain != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChainReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChainReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChainReranker).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (none != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NoneReranker), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NoneReranker> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NoneReranker).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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