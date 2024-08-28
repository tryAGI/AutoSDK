//HintName: JsonConverters.ChatContentEndEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatContentEndEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatContentEndEvent>
    {
        /// <inheritdoc />
        public override global::G.ChatContentEndEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatStreamEventType? value1 = default;
            try
            {
                value1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamEventType>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatContentEndEventVariant2? value2 = default;
            try
            {
                value2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentEndEventVariant2>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatContentEndEvent(
                value1,
                value2
                );

            if (value1 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatStreamEventType>(ref reader, options);
            }
            else if (value2 != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatContentEndEventVariant2>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatContentEndEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsValue1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(global::G.ChatStreamEventType), options);
            }
            else if (value.IsValue2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(global::G.ChatContentEndEventVariant2), options);
            }
        }
    }
}