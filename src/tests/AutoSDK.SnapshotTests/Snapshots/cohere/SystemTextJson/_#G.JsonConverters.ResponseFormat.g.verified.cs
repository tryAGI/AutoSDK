//HintName: G.JsonConverters.ResponseFormat.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResponseFormat>
    {
        /// <inheritdoc />
        public override global::G.ResponseFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.TextResponseFormat? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormat).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.JSONResponseFormat? jSON = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JSONResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JSONResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.JSONResponseFormat).Name}");
                jSON = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ResponseFormat(
                text,
                jSON
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormat).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (jSON != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JSONResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JSONResponseFormat> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.JSONResponseFormat).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsJSON)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.JSONResponseFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.JSONResponseFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.JSONResponseFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.JSON, typeInfo);
            }
        }
    }
}