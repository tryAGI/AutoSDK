//HintName: G.JsonConverters.TextResponseFormatConfiguration.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TextResponseFormatConfigurationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TextResponseFormatConfiguration>
    {
        /// <inheritdoc />
        public override global::G.TextResponseFormatConfiguration Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ResponseFormatText? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFormatText).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.TextResponseFormatJsonSchema? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormatJsonSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormatJsonSchema).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ResponseFormatJsonObject? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatJsonObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFormatJsonObject).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.TextResponseFormatConfiguration(
                value1,
                value2,
                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFormatText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormatJsonSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormatJsonSchema).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatJsonObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFormatJsonObject).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TextResponseFormatConfiguration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFormatText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextResponseFormatJsonSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextResponseFormatJsonSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextResponseFormatJsonSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResponseFormatJsonObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResponseFormatJsonObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResponseFormatJsonObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}