//HintName: G.JsonConverters.DIDGeneratedAssetOptions.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DIDGeneratedAssetOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DIDGeneratedAssetOptions>
    {
        /// <inheritdoc />
        public override global::G.DIDGeneratedAssetOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDGeneratedAssetOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDGeneratedAssetOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DIDGeneratedAssetOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.DIDTextToAvatarOptions? textToAvatar = default;
            if (discriminator?.Type == global::G.DIDGeneratedAssetOptionsDiscriminatorType.TextToAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDTextToAvatarOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDTextToAvatarOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.DIDTextToAvatarOptions)}");
                textToAvatar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.DIDGeneratedAssetOptions(
                discriminator?.Type,
                textToAvatar
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DIDGeneratedAssetOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextToAvatar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDTextToAvatarOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDTextToAvatarOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DIDTextToAvatarOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToAvatar, typeInfo);
            }
        }
    }
}