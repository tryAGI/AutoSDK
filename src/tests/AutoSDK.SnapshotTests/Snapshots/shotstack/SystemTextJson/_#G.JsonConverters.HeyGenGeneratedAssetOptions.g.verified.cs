//HintName: G.JsonConverters.HeyGenGeneratedAssetOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class HeyGenGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HeyGenGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::G.HeyGenGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeyGenGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.HeyGenTextToAvatarOptions? textToAvatar = default;
            if (discriminator?.Type == global::G.HeyGenGeneratedAssetOptionsDiscriminatorType.TextToAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenTextToAvatarOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenTextToAvatarOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeyGenTextToAvatarOptions)}");
                textToAvatar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.HeyGenGeneratedAssetOptions(
                discriminator?.Type,
                textToAvatar
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HeyGenGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenTextToAvatarOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenTextToAvatarOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeyGenTextToAvatarOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToAvatar, typeInfo);
            }
        }
    }
}