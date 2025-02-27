//HintName: JsonConverters.Source4.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Source4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source4>
    {
        /// <inheritdoc />
        public override global::G.Source4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestImageBlockSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestImageBlockSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RequestImageBlockSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.Base64ImageSource? base64 = default;
            if (discriminator?.Type == global::G.RequestImageBlockSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Base64ImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Base64ImageSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.Base64ImageSource)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.URLImageSource? url = default;
            if (discriminator?.Type == global::G.RequestImageBlockSourceDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.URLImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.URLImageSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.URLImageSource)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.Source4(
                discriminator?.Type,
                base64,
                url
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Base64ImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Base64ImageSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Base64ImageSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64, typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.URLImageSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.URLImageSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.URLImageSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
        }
    }
}