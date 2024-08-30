//HintName: JsonConverters.ChatCompletionStream.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionStreamJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionStream>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionStream Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            var
            readerCopy = reader;
            global::G.ChatCompletionEvent? @event = default;
            try
            {
                @event = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionEvent>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.StreamSentinel? sentinel = default;
            try
            {
                sentinel = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StreamSentinel>(ref readerCopy, options);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatCompletionStream(
                @event,
                sentinel
                );

            if (@event != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ChatCompletionEvent>(ref reader, options);
            }
            else if (sentinel != null)
            {
                _ = global::System.Text.Json.JsonSerializer.Deserialize<global::G.StreamSentinel>(ref reader, options);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionStream value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEvent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Event, typeof(global::G.ChatCompletionEvent), options);
            }
            else if (value.IsSentinel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sentinel, typeof(global::G.StreamSentinel), options);
            }
        }
    }
}