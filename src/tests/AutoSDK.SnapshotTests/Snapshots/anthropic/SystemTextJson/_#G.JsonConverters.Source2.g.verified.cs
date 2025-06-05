//HintName: G.JsonConverters.Source2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Source2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source2>
    {
        /// <inheritdoc />
        public override global::G.Source2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaRequestImageBlockSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaRequestImageBlockSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaRequestImageBlockSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BetaBase64ImageSource? base64 = default;
            if (discriminator?.Type == global::G.BetaRequestImageBlockSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBase64ImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBase64ImageSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaBase64ImageSource)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.BetaURLImageSource? url = default;
            if (discriminator?.Type == global::G.BetaRequestImageBlockSourceDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaURLImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaURLImageSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BetaURLImageSource)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Source2(
                discriminator?.Type,
                base64,
                url
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaBase64ImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaBase64ImageSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaBase64ImageSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BetaURLImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BetaURLImageSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BetaURLImageSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
        }
    }
}