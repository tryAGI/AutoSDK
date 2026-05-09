//HintName: G.JsonConverters.ReferencesItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ReferencesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReferencesItem>
    {
        /// <inheritdoc />
        public override global::G.ReferencesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVideoToVideoRequestGen4AlephReferenceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVideoToVideoRequestGen4AlephReferenceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVideoToVideoRequestGen4AlephReferenceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference? image = default;
            if (discriminator?.Type == "image")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ReferencesItem(
                discriminator?.Type,
                image
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReferencesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateVideoToVideoRequestGen4AlephReferenceImageReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
        }
    }
}