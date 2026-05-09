//HintName: G.JsonConverters.Character.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CharacterJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Character>
    {
        /// <inheritdoc />
        public override global::G.Character Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage? image = default;
            if (discriminator?.Type == global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo? video = default;
            if (discriminator?.Type == global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Character(
                discriminator?.Type,
                image,

                video
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Character value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateCharacterPerformanceRequestActTwoCharacterCharacterVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
        }
    }
}