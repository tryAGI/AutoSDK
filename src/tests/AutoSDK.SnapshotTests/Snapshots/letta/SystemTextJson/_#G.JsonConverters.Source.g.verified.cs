//HintName: G.JsonConverters.Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source>
    {
        /// <inheritdoc />
        public override global::G.Source Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageContentSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageContentSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageContentSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.UrlImage? url = default;
            if (discriminator?.Type == global::G.ImageContentSourceDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UrlImage)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.Base64Image? base64 = default;
            if (discriminator?.Type == global::G.ImageContentSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Base64Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Base64Image> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.Base64Image)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LettaImage? letta = default;
            if (discriminator?.Type == global::G.ImageContentSourceDiscriminatorType.Letta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LettaImage)}");
                letta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Source(
                discriminator?.Type,
                url,

                base64,

                letta
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UrlImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UrlImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.UrlImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url!, typeInfo);
            }
            else if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Base64Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Base64Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Base64Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base64!, typeInfo);
            }
            else if (value.IsLetta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LettaImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LettaImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LettaImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Letta!, typeInfo);
            }
        }
    }
}