//HintName: G.JsonConverters.Request4.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Request4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request4>
    {
        /// <inheritdoc />
        public override global::G.Request4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RequestGen4ImageTurbo? gen4ImageTurbo = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4ImageTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4ImageTurbo).Name}");
                gen4ImageTurbo = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RequestGen4Image? gen4Image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4Image> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4Image).Name}");
                gen4Image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.RequestGemini25Flash? gemini25Flash = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGemini25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGemini25Flash).Name}");
                gemini25Flash = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.Request4(
                gen4ImageTurbo,

                gen4Image,

                gemini25Flash
                );

            if (gen4ImageTurbo != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4ImageTurbo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4ImageTurbo).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (gen4Image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4Image> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4Image).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (gemini25Flash != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGemini25Flash> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGemini25Flash).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4ImageTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4ImageTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4ImageTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4ImageTurbo, typeInfo);
            }
            else if (value.IsGen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Image, typeInfo);
            }
            else if (value.IsGemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGemini25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGemini25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini25Flash, typeInfo);
            }
        }
    }
}