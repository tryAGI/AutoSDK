//HintName: G.JsonConverters.CreateTextToImageRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToImageRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToImageRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToImageRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToImageRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CreateTextToImageRequestGen4ImageTurbo? gen4ImageTurbo = default;
            if (discriminator?.Model == global::G.CreateTextToImageRequestDiscriminatorModel.Gen4ImageTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4ImageTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToImageRequestGen4ImageTurbo)}");
                gen4ImageTurbo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTextToImageRequestGen4Image? gen4Image = default;
            if (discriminator?.Model == global::G.CreateTextToImageRequestDiscriminatorModel.Gen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4Image> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToImageRequestGen4Image)}");
                gen4Image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CreateTextToImageRequestGemini25Flash? gemini25Flash = default;
            if (discriminator?.Model == global::G.CreateTextToImageRequestDiscriminatorModel.Gemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGemini25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateTextToImageRequestGemini25Flash)}");
                gemini25Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateTextToImageRequest(
                discriminator?.Model,
                gen4ImageTurbo,

                gen4Image,

                gemini25Flash
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToImageRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4ImageTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4ImageTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4ImageTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4ImageTurbo!, typeInfo);
            }
            else if (value.IsGen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Image!, typeInfo);
            }
            else if (value.IsGemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGemini25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGemini25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini25Flash!, typeInfo);
            }
        }
    }
}