//HintName: G.JsonConverters.GenerateStreamText.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GenerateStreamTextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateStreamText>
    {
        /// <inheritdoc />
        public override global::G.GenerateStreamText Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.GenerateStreamEvent? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEvent).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.GenerateStreamTextVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamTextVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamTextVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamTextVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.GenerateStreamText(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamTextVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamTextVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamTextVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateStreamText value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateStreamTextVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateStreamTextVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateStreamTextVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}