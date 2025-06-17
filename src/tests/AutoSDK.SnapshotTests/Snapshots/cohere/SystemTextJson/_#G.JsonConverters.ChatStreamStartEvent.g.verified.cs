//HintName: G.JsonConverters.ChatStreamStartEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatStreamStartEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatStreamStartEvent>
    {
        /// <inheritdoc />
        public override global::G.ChatStreamStartEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ChatStreamEvent? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEvent).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatStreamStartEventVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEventVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatStreamStartEvent(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEvent).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEventVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatStreamStartEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatStreamStartEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatStreamStartEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatStreamStartEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}