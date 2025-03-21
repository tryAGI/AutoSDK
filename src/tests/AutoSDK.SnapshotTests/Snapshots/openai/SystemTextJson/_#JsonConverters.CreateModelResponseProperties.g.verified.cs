//HintName: JsonConverters.CreateModelResponseProperties.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateModelResponsePropertiesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateModelResponseProperties>
    {
        /// <inheritdoc />
        public override global::G.CreateModelResponseProperties Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ModelResponseProperties? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelResponseProperties).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.CreateModelResponseProperties(
                value1
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelResponseProperties).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateModelResponseProperties value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelResponseProperties?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelResponseProperties).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
        }
    }
}