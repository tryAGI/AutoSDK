//HintName: JsonConverters.InputVariant3Item.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputVariant3ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputVariant3Item>
    {
        /// <inheritdoc />
        public override global::G.InputVariant3Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModerationRequestInputVariant3ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModerationRequestInputVariant3ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateModerationRequestInputVariant3ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateModerationRequestInputVariant3ItemVariant1? imageUrl = default;
            if (discriminator?.Type == global::G.CreateModerationRequestInputVariant3ItemDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModerationRequestInputVariant3ItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModerationRequestInputVariant3ItemVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateModerationRequestInputVariant3ItemVariant1)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateModerationRequestInputVariant3ItemVariant2? text = default;
            if (discriminator?.Type == global::G.CreateModerationRequestInputVariant3ItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModerationRequestInputVariant3ItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModerationRequestInputVariant3ItemVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateModerationRequestInputVariant3ItemVariant2)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.InputVariant3Item(
                discriminator?.Type,
                imageUrl,
                text
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputVariant3Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModerationRequestInputVariant3ItemVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModerationRequestInputVariant3ItemVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModerationRequestInputVariant3ItemVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModerationRequestInputVariant3ItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModerationRequestInputVariant3ItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModerationRequestInputVariant3ItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}