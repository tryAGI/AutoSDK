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

            var
            readerCopy = reader;
            global::G.RequestActTwoCharacterCharacterImage? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwoCharacterCharacterImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwoCharacterCharacterImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwoCharacterCharacterImage).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RequestActTwoCharacterCharacterVideo? video = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwoCharacterCharacterVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwoCharacterCharacterVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwoCharacterCharacterVideo).Name}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Character(
                image,

                video
                );

            if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwoCharacterCharacterImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwoCharacterCharacterImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwoCharacterCharacterImage).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (video != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwoCharacterCharacterVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwoCharacterCharacterVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwoCharacterCharacterVideo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwoCharacterCharacterImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwoCharacterCharacterImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwoCharacterCharacterImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestActTwoCharacterCharacterVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestActTwoCharacterCharacterVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestActTwoCharacterCharacterVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
        }
    }
}