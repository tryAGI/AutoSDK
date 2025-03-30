//HintName: JsonConverters.RemoteAuth.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RemoteAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RemoteAuth>
    {
        /// <inheritdoc />
        public override global::G.RemoteAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RemoteAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RemoteAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RemoteAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BearerAuth? bearer = default;
            if (discriminator?.Type == global::G.RemoteAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BearerAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BearerAuth)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HeaderAuth? header = default;
            if (discriminator?.Type == global::G.RemoteAuthDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeaderAuth> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeaderAuth)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RemoteAuth(
                discriminator?.Type,
                bearer,
                header
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RemoteAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BearerAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BearerAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BearerAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer, typeInfo);
            }
            else if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeaderAuth), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeaderAuth?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeaderAuth).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header, typeInfo);
            }
        }
    }
}